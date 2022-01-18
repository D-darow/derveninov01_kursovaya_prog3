using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_kursovaya_prog3
{
    /// <summary>
    /// Процесс прохождения опроса
    /// </summary>
    public class Interview
    {
        // Текущий опросник
        private Questionnaire questionnaire;
        // Заполненный опросник
        private FilledQuestionnaire filledQuestionnaire;
        /// <summary>
        /// Список отвеченных вопросов
        /// </summary>
        public List<Question> PassedQuestions = new List<Question>();
        /// <summary>
        /// Индекс текущего вопроса (не отвеченного)
        /// </summary>
        public int CurrentQuestionIndex = 0;
        /// <summary>
        /// Опрос завершен?
        /// </summary>
        public bool IsFinished;

        public Interview(Questionnaire questionnaire, FilledQuestionnaire filledQuestionnaire)
        {
            this.questionnaire = questionnaire;
            this.filledQuestionnaire = filledQuestionnaire;
        }
        /// <summary>
        /// Переход к следующему вопросу
        /// </summary>
        public void NextQuestion()
        {
            if (CurrentQuestionIndex < questionnaire.Count) // Если опросник не завершен
            {
                PassedQuestions.Add(questionnaire[CurrentQuestionIndex]);
                if (CurrentQuestionIndex == questionnaire.Count - 1) IsFinished = true; // Опросник завершен
                CurrentQuestionIndex++;
                return;
            }
        }
    }
}
