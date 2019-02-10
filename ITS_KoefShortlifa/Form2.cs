using System;
using System.Windows.Forms;

namespace ITS_KoefShortlifa
{
    public partial class Form2 : Form
    {
        public double e1;
        public double e2;

        public Form2()
        {
            InitializeComponent();
        }

        private void shortBtnOk_Click(object sender, EventArgs e)
        {
            e1 = Parser.Parse(e1txt.Text);
            e2 = Parser.Parse(e2txt.Text);
            this.Close();
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            Validator.ValidateInput(sender as TextBox);
        }
    }
}
