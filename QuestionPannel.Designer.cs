
namespace derveninov01_kursovaya_prog3
{
    partial class QuestionPannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionPannel));
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.VariantsPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.rbFreeAnswer = new System.Windows.Forms.RadioButton();
            this.rbSingleAnswer = new System.Windows.Forms.RadioButton();
            this.btAddVariant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(3, 4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(326, 23);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // btUp
            // 
            this.btUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUp.BackgroundImage")));
            this.btUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUp.Location = new System.Drawing.Point(337, 4);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(25, 23);
            this.btUp.TabIndex = 2;
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDown
            // 
            this.btDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDown.BackgroundImage")));
            this.btDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDown.Location = new System.Drawing.Point(368, 4);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(25, 23);
            this.btDown.TabIndex = 3;
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDelete.Location = new System.Drawing.Point(399, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(25, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // VariantsPannel
            // 
            this.VariantsPannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantsPannel.AutoSize = true;
            this.VariantsPannel.Location = new System.Drawing.Point(3, 82);
            this.VariantsPannel.Name = "VariantsPannel";
            this.VariantsPannel.Size = new System.Drawing.Size(424, 10);
            this.VariantsPannel.TabIndex = 7;
            // 
            // rbFreeAnswer
            // 
            this.rbFreeAnswer.AutoSize = true;
            this.rbFreeAnswer.Checked = true;
            this.rbFreeAnswer.Location = new System.Drawing.Point(189, 33);
            this.rbFreeAnswer.Name = "rbFreeAnswer";
            this.rbFreeAnswer.Size = new System.Drawing.Size(121, 19);
            this.rbFreeAnswer.TabIndex = 8;
            this.rbFreeAnswer.TabStop = true;
            this.rbFreeAnswer.Text = "Свободный ответ";
            this.rbFreeAnswer.UseVisualStyleBackColor = true;
            this.rbFreeAnswer.CheckedChanged += new System.EventHandler(this.rbFreeAnswer_CheckedChanged);
            // 
            // rbSingleAnswer
            // 
            this.rbSingleAnswer.AutoSize = true;
            this.rbSingleAnswer.Location = new System.Drawing.Point(316, 33);
            this.rbSingleAnswer.Name = "rbSingleAnswer";
            this.rbSingleAnswer.Size = new System.Drawing.Size(108, 19);
            this.rbSingleAnswer.TabIndex = 9;
            this.rbSingleAnswer.Text = "Вариант ответа";
            this.rbSingleAnswer.UseVisualStyleBackColor = true;
            this.rbSingleAnswer.CheckedChanged += new System.EventHandler(this.rbSingleAnswer_CheckedChanged);
            // 
            // btAddVariant
            // 
            this.btAddVariant.Location = new System.Drawing.Point(3, 33);
            this.btAddVariant.Name = "btAddVariant";
            this.btAddVariant.Size = new System.Drawing.Size(108, 43);
            this.btAddVariant.TabIndex = 10;
            this.btAddVariant.Text = "Добавить вариант ответа";
            this.btAddVariant.UseVisualStyleBackColor = true;
            this.btAddVariant.Click += new System.EventHandler(this.btAddVariant_Click_1);
            // 
            // QuestionPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btAddVariant);
            this.Controls.Add(this.rbSingleAnswer);
            this.Controls.Add(this.rbFreeAnswer);
            this.Controls.Add(this.VariantsPannel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.tbTitle);
            this.Name = "QuestionPannel";
            this.Size = new System.Drawing.Size(432, 104);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.FlowLayoutPanel VariantsPannel;
        private System.Windows.Forms.RadioButton rbFreeAnswer;
        private System.Windows.Forms.RadioButton rbSingleAnswer;
        private System.Windows.Forms.Button btAddVariant;
    }
}
