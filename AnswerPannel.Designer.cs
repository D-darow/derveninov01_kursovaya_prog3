
namespace derveninov01_kursovaya_prog3
{
    partial class AnswerPannel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbQuestionTitle = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbQuestionTitle
            // 
            this.lbQuestionTitle.Location = new System.Drawing.Point(3, 0);
            this.lbQuestionTitle.Name = "lbQuestionTitle";
            this.lbQuestionTitle.Size = new System.Drawing.Size(322, 33);
            this.lbQuestionTitle.TabIndex = 0;
            this.lbQuestionTitle.Text = "Текст вопроса";
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(3, 36);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(322, 33);
            this.pnMain.TabIndex = 1;
            // 
            // AnswerPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.lbQuestionTitle);
            this.Name = "AnswerPannel";
            this.Size = new System.Drawing.Size(326, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQuestionTitle;
        private System.Windows.Forms.FlowLayoutPanel pnMain;
    }
}
