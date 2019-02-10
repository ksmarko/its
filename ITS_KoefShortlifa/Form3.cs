using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ITS_KoefShortlifa
{
    public partial class Form3 : Form
    {
        public bool IsStandart;
        public int Index;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(bool isCriterio, IEnumerable<string> collection)
        {
            InitializeComponent();

            if (isCriterio)
            {
                lblText.Text += "критерій)?";
            }
            else
            {
                lblText.Text += "метрику)?";
            }

            var cBoxItems = collection.Select(x => (object)x).ToArray();
            cBoxMetrSelect.Items.AddRange(cBoxItems);
            cBoxMetrSelect.SelectedIndex = 0;
        }

        private void btnMetrOk_Click(object sender, EventArgs e)
        {
            Index = cBoxMetrSelect.SelectedIndex;
            Close();
        }

        private void btnMetrSelect_Click(object sender, EventArgs e)
        {
            cBoxMetrSelect.Visible = true;
            lblMetrSelect.Visible = true;
            btnMetrOk.Visible = true;
        }

        private void btnMaxOk_Click(object sender, EventArgs e)
        {
            IsStandart = true;
            Close();
        }
    }
}
