
namespace derveninov01_kursovaya_prog3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnOpenQuest = new System.Windows.Forms.ToolStripButton();
            this.btnSaveQuest = new System.Windows.Forms.ToolStripButton();
            this.btnAddQuest = new System.Windows.Forms.ToolStripButton();
            this.btnStartQuest = new System.Windows.Forms.ToolStripButton();
            this.MainPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenQuest,
            this.btnSaveQuest,
            this.btnAddQuest,
            this.btnStartQuest});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(455, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // btnOpenQuest
            // 
            this.btnOpenQuest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenQuest.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenQuest.Image")));
            this.btnOpenQuest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenQuest.Name = "btnOpenQuest";
            this.btnOpenQuest.Size = new System.Drawing.Size(23, 22);
            this.btnOpenQuest.Text = "Открыть опросник";
            this.btnOpenQuest.Click += new System.EventHandler(this.btnOpenQuest_Click);
            // 
            // btnSaveQuest
            // 
            this.btnSaveQuest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveQuest.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveQuest.Image")));
            this.btnSaveQuest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveQuest.Name = "btnSaveQuest";
            this.btnSaveQuest.Size = new System.Drawing.Size(23, 22);
            this.btnSaveQuest.Text = "Сохранить опросник";
            this.btnSaveQuest.Click += new System.EventHandler(this.btnSaveQuest_Click);
            // 
            // btnAddQuest
            // 
            this.btnAddQuest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddQuest.Image = ((System.Drawing.Image)(resources.GetObject("btnAddQuest.Image")));
            this.btnAddQuest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddQuest.Name = "btnAddQuest";
            this.btnAddQuest.Size = new System.Drawing.Size(23, 22);
            this.btnAddQuest.Text = "Добавить вопрос";
            this.btnAddQuest.Click += new System.EventHandler(this.btnAddQuest_Click);
            // 
            // btnStartQuest
            // 
            this.btnStartQuest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStartQuest.Image = ((System.Drawing.Image)(resources.GetObject("btnStartQuest.Image")));
            this.btnStartQuest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartQuest.Name = "btnStartQuest";
            this.btnStartQuest.Size = new System.Drawing.Size(23, 22);
            this.btnStartQuest.Text = "Начать опрос";
            this.btnStartQuest.Click += new System.EventHandler(this.btnStartQuest_Click);
            // 
            // MainPannel
            // 
            this.MainPannel.AutoScroll = true;
            this.MainPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPannel.Location = new System.Drawing.Point(0, 25);
            this.MainPannel.Name = "MainPannel";
            this.MainPannel.Size = new System.Drawing.Size(455, 425);
            this.MainPannel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.MainPannel);
            this.Controls.Add(this.MainToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Опрос пациента";
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton btnOpenQuest;
        private System.Windows.Forms.ToolStripButton btnSaveQuest;
        private System.Windows.Forms.ToolStripButton btnAddQuest;
        private System.Windows.Forms.ToolStripButton btnStartQuest;
        private System.Windows.Forms.FlowLayoutPanel MainPannel;
    }
}

