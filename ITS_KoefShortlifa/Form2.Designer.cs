namespace ITS_KoefShortlifa
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.e1txt = new System.Windows.Forms.TextBox();
            this.e2txt = new System.Windows.Forms.TextBox();
            this.shortBtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для обчислення скорегованого значення введіть е1 і е2, по яким буде проводитись р" +
    "озрахунок коефіцієнту Шортліфа.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "е1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "е2";
            // 
            // e1txt
            // 
            this.e1txt.Location = new System.Drawing.Point(49, 57);
            this.e1txt.Name = "e1txt";
            this.e1txt.Size = new System.Drawing.Size(55, 20);
            this.e1txt.TabIndex = 3;
            this.e1txt.TextChanged += new System.EventHandler(this.ValidateInput);
            // 
            // e2txt
            // 
            this.e2txt.Location = new System.Drawing.Point(49, 85);
            this.e2txt.Name = "e2txt";
            this.e2txt.Size = new System.Drawing.Size(55, 20);
            this.e2txt.TabIndex = 4;
            this.e2txt.TextChanged += new System.EventHandler(this.ValidateInput);
            // 
            // shortBtnOk
            // 
            this.shortBtnOk.Location = new System.Drawing.Point(345, 85);
            this.shortBtnOk.Name = "shortBtnOk";
            this.shortBtnOk.Size = new System.Drawing.Size(75, 23);
            this.shortBtnOk.TabIndex = 5;
            this.shortBtnOk.Text = "OK";
            this.shortBtnOk.UseVisualStyleBackColor = true;
            this.shortBtnOk.Click += new System.EventHandler(this.shortBtnOk_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 118);
            this.Controls.Add(this.shortBtnOk);
            this.Controls.Add(this.e2txt);
            this.Controls.Add(this.e1txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox e1txt;
        private System.Windows.Forms.TextBox e2txt;
        private System.Windows.Forms.Button shortBtnOk;
    }
}