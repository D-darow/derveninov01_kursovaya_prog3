using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derveninov01_kursovaya_prog3
{
    /// <summary>
    /// Вопрос,
    /// Каждый вопрос содержит список вариантов ответа
    /// </summary>
    [Serializable]
    public class Question : List<Variant>
    {
        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string Title;

        /// <summary>
        /// Тип ответа на вопрос
        /// </summary>
        public QuestionType questionType = QuestionType.FreeAnswer;

        /// <summary>
        /// Добавить вариант ответа
        /// </summary>
        public Variant AddVariant(Question question)
        {
            // Создание варианта ответа
            var variant = new Variant() { Title = "Вариант ответа" };
            question.Add(variant);
            return variant;
        }
        /// <summary>
        /// Передвинуть вариант ответа
        /// </summary>
        public void MoveVariant(Question question, Variant variant, int where)
        {
            int i = question.IndexOf(variant);

            // Если вопрос первый - не можем переместить вверх
            if (i == 0 && where < 0) return;
            // Если вопрос последний - не можем переместить вниз
            if (i >= question.Count - 1 && where > 0) return;
            // Передвинуть вверх
            if (where < 0)
            {
                question.RemoveAt(i);
                question.Insert(i - 1, variant);
            }
            // Передвинуть вниз
            if (where > 0)
            {
                question.RemoveAt(i);
                question.Insert(i + 1, variant);
            }
        }
    }
    /// <summary>
    /// Вариант ответа
    /// </summary>
    [Serializable]
    public class Variant
    {
        /// <summary>
        /// Текст варианта ответа
        /// </summary>
        public string Title;
    }
    /// <summary>
    /// Тип ответа
    /// </summary>
    [Serializable]
    public enum QuestionType
    {
        /// <summary>
        /// Свободный ответ (текст)
        /// </summary>
        FreeAnswer = 0,
        /// <summary>
        /// Выбор одного варианта ответа из нескольких
        /// </summary>
        SingleAnswer = 1
    }
}
