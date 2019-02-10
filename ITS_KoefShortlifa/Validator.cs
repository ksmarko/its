using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ITS_KoefShortlifa
{
    class Validator
    {
        public static bool IsEmptyLabel(Label label)
        {
            return IsEmpty(label.Text) || label.Text == "0" || label.Text == "NaN";
        }

        public static bool IsEmpty(params string[] values)
        {
            return values.All(str => string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str));
        }

        public static void ValidateInput(TextBox textBox)
        {
            if (!Regex.IsMatch(textBox.Text, "[0-9,]$"))
            {
                if (textBox.Text.Length > 0)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.Select(textBox.Text.Length, 0);
                }
                else
                    textBox.Text = "";
            }
        }
    }
}
