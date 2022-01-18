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
    public partial class AnswerPannel : UserControl
    {
        // Текущий вопрос
        private Question question;
        // Текущий вопрос
        private Answer answer;
        // Текущий процесс прохождения опроса
        private Interview interview;
        public AnswerPannel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Построить интерфейс
        /// </summary>
        public void Build(Interview interview, Question question, Answer answer, bool passed)
        {
            this.question = question;
            this.answer = answer;
            this.interview = interview;
            lbQuestionTitle.Text = question.Title;
            
            if (passed) // Если вопрос отвечен
            {
                var lb = new Label();
                lb.Text = "Ваш ответ: " + answer.AnswerText;
                lb.Parent = pnMain;
            }
            else
            {
                switch (question.questionType)
                {
                    case QuestionType.FreeAnswer:
                        // Создание TextBox элемента
                        var tb = new TextBox();
                        tb.Parent = pnMain;
                        // Добавить событие "Текст изменен"
                        tb.TextChanged += (o, O) =>
                        {
                            answer.AnswerText = tb.Text;
                        };
                        break;
                    case QuestionType.SingleAnswer:
                        // Создание ComboBox элемента
                        var cb = new ComboBox();
                        List<string> variants = new List<string>();
                        foreach (Variant variant in question)
                        {
                            variants.Add(variant.Title);
                        }
                        cb.DataSource = variants;
                        cb.DropDownStyle = ComboBoxStyle.DropDownList;
                        cb.Parent = pnMain;
                        // Добавить событие "Изменен выбор ComboBox"
                        cb.SelectedValueChanged += (o, O) =>
                        {
                            answer.AnswerText = cb.SelectedValue.ToString();
                        };
                        if (variants.Count > 0) answer.AnswerText = variants[0];
                        break;
                }
            }
        }
    }
}
