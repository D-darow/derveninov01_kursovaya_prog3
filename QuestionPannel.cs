using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace derveninov01_kursovaya_prog3
{
    public partial class QuestionPannel : UserControl
    {
        // Текущий опросник
        private Questionnaire questionnaire;
        // Текущий вопрос
        private Question question;
        // Событие "Изменен опросник"
        public event Action QuestionnaireChanged = delegate { };

        public QuestionPannel()
        {
            InitializeComponent();
        }

        public void Build(Questionnaire questionnaire, Question question)
        {
            this.questionnaire = questionnaire;
            this.question = question;

            tbTitle.Text = question.Title;
            // Очистить панель вариантов ответа
            VariantsPannel.Controls.Clear();
            // Создание вариантов ответа для каждого вопроса
            foreach (Variant item in question)
            {
                VariantPannel pn = new VariantPannel();
                pn.Build(question, item);
                pn.VariantChanged += () =>
                {
                    Build(questionnaire, question);
                    QuestionnaireChanged();
                };
                VariantsPannel.Controls.Add(pn);
            }
            // Вызов сборщика мусора
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        /// <summary>
        /// Переместить вопрос вверх
        /// </summary>
        private void btUp_Click(object sender, EventArgs e)
        {
            questionnaire.MoveQuestion(questionnaire, question, -1);
            QuestionnaireChanged();
        }
        /// <summary>
        /// Переместить вопрос вниз
        /// </summary>
        private void btDown_Click(object sender, EventArgs e)
        {
            questionnaire.MoveQuestion(questionnaire, question, 1);
            QuestionnaireChanged();
        }
        /// <summary>
        /// Удалить вопрос
        /// </summary>
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить вопрос?", "Удаление вопроса", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //удаляем вопрос
                questionnaire.Remove(question);
                //сигнализируем наверх о том, что список вопросов поменялся
                QuestionnaireChanged();
            }
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            question.Title = tbTitle.Text;
        }
        /// <summary>
        /// Добавить вариант ответа
        /// </summary>
        private void btAddVariant_Click_1(object sender, EventArgs e)
        {
            // Добавить вариант ответа
            question.AddVariant(question);
            // Перестроить интерфейс
            Build(questionnaire, question);
        }

        private void rbFreeAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFreeAnswer.Checked) question.questionType = QuestionType.FreeAnswer;
            else question.questionType = QuestionType.SingleAnswer;
        }

        private void rbSingleAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFreeAnswer.Checked) question.questionType = QuestionType.FreeAnswer;
            else question.questionType = QuestionType.SingleAnswer;
        }
    }
}
