using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace derveninov01_kursovaya_prog3
{
    public partial class InterviewForm : Form
    {
        // Процесс прохождения опроса
        private Interview interview;
        // Текущий опросник
        private Questionnaire questionnaire;
        // Заполненный опросник
        private FilledQuestionnaire filledQuestionnaire;
        public InterviewForm()
        {
            InitializeComponent();
        }
        public InterviewForm(Questionnaire questionnaire)
        {
            InitializeComponent();
            this.questionnaire = questionnaire;
        }

        private void InterviewForm_OnLoad(object sender, EventArgs e)
        {
            filledQuestionnaire = new FilledQuestionnaire();
            if (questionnaire == null)
            {
                var ofd = new OpenFileDialog() { Filter = "Опросник|*.q", Title = "Выберите опросник" };
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    questionnaire = FileHelper.LoadQuest<Questionnaire>(ofd.FileName);
                }
                else
                {
                    
                    Close();
                    return;
                }
            }
            foreach (Question question in questionnaire)
            {
                Answer answer = new Answer() { QuestionTitle = question.Title };
                filledQuestionnaire.Add(answer);
            }
            interview = new Interview(questionnaire, filledQuestionnaire);
            Build();
        }
        /// <summary>
        /// Построить интерфейс опросника
        /// </summary>
        public void Build()
        {
            // Очистить панель ответов
            pnMain.Controls.Clear();
            // Отобразить отвеченные вопросы
            for (int i = 0; i < interview.CurrentQuestionIndex; i++)
            {
                // Создать панель ответа
                var pn = new AnswerPannel();
                // Построить панель ответа
                pn.Build(interview, questionnaire[i], filledQuestionnaire[i], true);
                // Добавить панель на форму
                pn.Parent = pnMain;
            }
            // Отобразить текущий вопрос, на который не дан ответ
            if (interview.CurrentQuestionIndex < questionnaire.Count)
            {
                // Создать панель ответа
                var pn = new AnswerPannel();
                // Построить панель ответа
                pn.Build(interview, questionnaire[interview.CurrentQuestionIndex], filledQuestionnaire[interview.CurrentQuestionIndex], false);
                // Добавить панель на форму
                pn.Parent = pnMain;
            }
            // Отображение кнопок "След. вопрос" и "Завершить опрос"
            if (interview.IsFinished) btEnd.Parent = pnMain;
            else btNext.Parent = pnMain;
        }
        /// <summary>
        /// Переход к следующему вопросу
        /// </summary>
        private void btNext_Click(object sender, EventArgs e)
        {
            interview.NextQuestion();
            Build();
        }
        /// <summary>
        /// Завершить опрос
        /// </summary>
        private void btEnd_Click(object sender, EventArgs e)
        {
            // Сохранение заполненного опросника
            if (MessageBox.Show("Сохранить результат опроса?", "Сохранение результата опроса", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var sfd = new SaveFileDialog() { Filter = "Результат опроса | *.txt", FileName = Guid.NewGuid().ToString() };
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    TextWriter tw = new StreamWriter(sfd.FileName);
                    foreach (Answer item in filledQuestionnaire)
                    {
                        tw.WriteLine(item.ToString());
                    }
                    tw.Close();
                }
            }
            Close();
        }
    }
}
