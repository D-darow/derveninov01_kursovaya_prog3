using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_kursovaya_prog3
{
    /// <summary>
    /// Заполненный опросник,
    /// Состоит из списка ответов
    /// </summary>
    public class FilledQuestionnaire : List<Answer>
    {
    }
    /// <summary>
    /// Ответ опрашиваемого на вопрос
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Текст ответа на вопрос
        /// </summary>
        public string AnswerText;

        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string QuestionTitle;

        public override string ToString()
        {
            string s = QuestionTitle + ": " + AnswerText;
            return s;
        }
    }
}
