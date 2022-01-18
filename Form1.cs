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
    public partial class Form1 : Form
    {
        // Текущий опросник
        private Questionnaire questionnaire = new Questionnaire();

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Построить интерфейс
        /// </summary>
        private void Build()
        {
            // Очистить главную панель
            MainPannel.Controls.Clear();
            // Создать панели для каждого вопроса
            foreach (Question item in questionnaire)
            {
                QuestionPannel pn = new QuestionPannel();
                pn.Build(questionnaire, item);
                pn.QuestionnaireChanged += () =>
                {
                    Build();
                };
                MainPannel.Controls.Add(pn);
            }
            // Вызов сборщика мусора
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        /// <summary>
        /// Открыть готовый опросник
        /// </summary>
        private void btnOpenQuest_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog() { Filter = "Опросник|*.quest" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                questionnaire = FileHelper.LoadQuest<Questionnaire>(openFileDialog.FileName);
                Build();
            }
        }
        /// <summary>
        /// Сохранить опросник
        /// </summary>
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (questionnaire.Count == 0)
            {
                throw new Exception("Опросник пуст. Невозможно сохранить опросник...");
            }
            var saveFileDialog = new SaveFileDialog() { Filter = "Опросник|*.quest" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileHelper.SaveQuest(questionnaire, saveFileDialog.FileName);
            }
        }
        /// <summary>
        /// Добавить вопрос
        /// </summary>
        private void btnAddQuest_Click(object sender, EventArgs e)
        {
            questionnaire.AddQuestion(questionnaire);
            Build();
        }
        /// <summary>
        /// Начать опрос
        /// </summary>
        private void btnStartQuest_Click(object sender, EventArgs e)
        {
            if (questionnaire.Count == 0)
            {
                throw new Exception("Опросник пуст. Невозможно начать опрос...");
            }
            foreach (Question question in questionnaire)
            {
                if (question.Count == 0 && question.questionType == QuestionType.SingleAnswer) 
                {
                    throw new Exception("Не во всех вопросах есть варианты ответа...");
                }
            }
            new InterviewForm(questionnaire).ShowDialog();
        }
    }
}
