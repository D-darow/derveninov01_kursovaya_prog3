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
    public partial class VariantPannel : UserControl
    {
        // Текущий вопрос
        private Question question;
        // Текущий вариант ответа
        private Variant variant;
        // Событие "Вариант изменился"
        public event Action VariantChanged;
        public VariantPannel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Построить интерфейс варианта ответа
        /// </summary>
        public void Build(Question question, Variant variant)
        {
            this.question = question;
            this.variant = variant;

            tbTitle.Text = variant.Title;
        }
        /// <summary>
        /// Передвинуть вариант ответа вверх
        /// </summary>
        private void btUp_Click(object sender, EventArgs e)
        {
            question.MoveVariant(question, variant, -1);
            VariantChanged();
        }
        /// <summary>
        /// Передвинуть вариант ответа ввниз
        /// </summary>
        private void btDown_Click(object sender, EventArgs e)
        {
            question.MoveVariant(question, variant, 1);
            VariantChanged();
        }
        /// <summary>
        /// Удаление варианта ответа
        /// </summary>
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить вариант ответа?", "Удаление варианта ответа", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //удаляем вопрос
                question.Remove(variant);
                //сигнализируем наверх о том, что список вопросов поменялся
                VariantChanged();
            }
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            variant.Title = tbTitle.Text;
        }
    }
}
