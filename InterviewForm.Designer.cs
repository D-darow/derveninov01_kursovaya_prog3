
namespace derveninov01_kursovaya_prog3
{
    partial class InterviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterviewForm));
            this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btNext = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.btNext);
            this.pnMain.Controls.Add(this.btEnd);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(405, 344);
            this.pnMain.TabIndex = 0;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(3, 3);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(139, 29);
            this.btNext.TabIndex = 0;
            this.btNext.Text = "Следующий вопрос";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(148, 3);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(139, 29);
            this.btEnd.TabIndex = 1;
            this.btEnd.Text = "Завершить опрос";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // InterviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 344);
            this.Controls.Add(this.pnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Опросник";
            this.Load += new System.EventHandler(this.InterviewForm_OnLoad);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnMain;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btEnd;
    }
}