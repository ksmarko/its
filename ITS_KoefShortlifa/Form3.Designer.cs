namespace ITS_KoefShortlifa
{
    partial class Form3
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnMaxOk = new System.Windows.Forms.Button();
            this.btnMetrSelect = new System.Windows.Forms.Button();
            this.lblMetrSelect = new System.Windows.Forms.Label();
            this.btnMetrOk = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cBoxMetrSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(12, 19);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(424, 38);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Продовжити стандартний шляхом (визначення максимального значення) чи продовжити (" +
    "необхідно обрати ";
            // 
            // btnMaxOk
            // 
            this.btnMaxOk.Location = new System.Drawing.Point(15, 60);
            this.btnMaxOk.Name = "btnMaxOk";
            this.btnMaxOk.Size = new System.Drawing.Size(115, 23);
            this.btnMaxOk.TabIndex = 1;
            this.btnMaxOk.Text = "Стандарт";
            this.btnMaxOk.UseVisualStyleBackColor = true;
            this.btnMaxOk.Click += new System.EventHandler(this.btnMaxOk_Click);
            // 
            // btnMetrSelect
            // 
            this.btnMetrSelect.Location = new System.Drawing.Point(148, 60);
            this.btnMetrSelect.Name = "btnMetrSelect";
            this.btnMetrSelect.Size = new System.Drawing.Size(115, 23);
            this.btnMetrSelect.TabIndex = 2;
            this.btnMetrSelect.Text = "Вибрати";
            this.btnMetrSelect.UseVisualStyleBackColor = true;
            this.btnMetrSelect.Click += new System.EventHandler(this.btnMetrSelect_Click);
            // 
            // lblMetrSelect
            // 
            this.lblMetrSelect.AutoSize = true;
            this.lblMetrSelect.Location = new System.Drawing.Point(15, 104);
            this.lblMetrSelect.Name = "lblMetrSelect";
            this.lblMetrSelect.Size = new System.Drawing.Size(54, 13);
            this.lblMetrSelect.TabIndex = 3;
            this.lblMetrSelect.Text = "Виберіть:";
            this.lblMetrSelect.Visible = false;
            // 
            // btnMetrOk
            // 
            this.btnMetrOk.Location = new System.Drawing.Point(321, 135);
            this.btnMetrOk.Name = "btnMetrOk";
            this.btnMetrOk.Size = new System.Drawing.Size(115, 23);
            this.btnMetrOk.TabIndex = 5;
            this.btnMetrOk.Text = "OK";
            this.btnMetrOk.UseVisualStyleBackColor = true;
            this.btnMetrOk.Visible = false;
            this.btnMetrOk.Click += new System.EventHandler(this.btnMetrOk_Click);
            // 
            // cBoxMetrSelect
            // 
            this.cBoxMetrSelect.FormattingEnabled = true;
            this.cBoxMetrSelect.Location = new System.Drawing.Point(15, 135);
            this.cBoxMetrSelect.Name = "cBoxMetrSelect";
            this.cBoxMetrSelect.Size = new System.Drawing.Size(248, 21);
            this.cBoxMetrSelect.TabIndex = 6;
            this.cBoxMetrSelect.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 175);
            this.Controls.Add(this.cBoxMetrSelect);
            this.Controls.Add(this.btnMetrOk);
            this.Controls.Add(this.lblMetrSelect);
            this.Controls.Add(this.btnMetrSelect);
            this.Controls.Add(this.btnMaxOk);
            this.Controls.Add(this.lblText);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnMaxOk;
        private System.Windows.Forms.Button btnMetrSelect;
        private System.Windows.Forms.Label lblMetrSelect;
        private System.Windows.Forms.Button btnMetrOk;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cBoxMetrSelect;
    }
}