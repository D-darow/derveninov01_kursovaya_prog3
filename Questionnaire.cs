using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_kursovaya_prog3
{
    /// <summary>
    /// Опросник,
    /// Состоит из списка вопросов
    /// </summary>
    [Serializable]
    public class Questionnaire : List<Question>
    {
        /// <summary>
        /// Добавить вопрос
        /// </summary>
        public Question AddQuestion(Questionnaire questionnaire)
        {
            // Создание вопроса
            Question question = new Question() { Title = "Текст вопроса" };
            questionnaire.Add(question);
            return question;
        }
        /// <summary>
        /// Переместить вопрос в списке
        /// </summary>
        public void MoveQuestion(Questionnaire questionnaire, Question question, int where)
        {
            int i = questionnaire.IndexOf(question);

            // Если вопрос первый - не можем переместить вверх
            if (i == 0 && where < 0) return;
            // Если вопрос последний - не можем переместить вниз
            if (i >= questionnaire.Count - 1 && where > 0) return;
            // Передвинуть вверх
            if (where < 0)
            {
                questionnaire.RemoveAt(i);
                questionnaire.Insert(i - 1, question);
            }
            // Передвинуть вниз
            if (where > 0)
            {
                questionnaire.RemoveAt(i);
                questionnaire.Insert(i + 1, question);
            }
        }
    }
}
