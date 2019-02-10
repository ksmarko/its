using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ITS_KoefShortlifa
{
    public partial class Form1 : Form
    {
        private CalculatorService _service;

        public Form1()
        {
            InitializeComponent();
            _service = new CalculatorService();
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            Validator.ValidateInput(sender as TextBox);
        }

        #region Критерій 1. Стійкість функціонування

        #region Метрика 1. Засоби відновлення при помилках на вході

        // Очистити значення оцінок метрики 1. Засоби відновлення при помилках на вході
        private void k1m1btnClear_Click(object sender, EventArgs e)
        {
            k1m1o1txt.Text = string.Empty;
            k1m1o2txt.Text = string.Empty;
            k1m1o3txt.Text = string.Empty;
            k1m1o4txt.Text = string.Empty;
            k1m1o5txt.Text = string.Empty;
            k1m1o6txt.Text = string.Empty;
            k1m1o7txt.Text = string.Empty;
            k1m1o8txt.Text = string.Empty;
            k1m1o9txt.Text = string.Empty;
            k1m1o10txt.Text = string.Empty;

            k1m1lblValue.Text = "0";
            k1m1lblNewValue.Text = "0";
        }

        // Отримати значення метрики 1. Засоби відновлення при помилках на вході
        private void k1m1btnOk_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(k1m1o1txt.Text, k1m1o2txt.Text, k1m1o3txt.Text,
                k1m1o4txt.Text, k1m1o5txt.Text, k1m1o6txt.Text,
                k1m1o7txt.Text, k1m1o8txt.Text, k1m1o9txt.Text, k1m1o10txt.Text))
            {
                MessageBox.Show("Для обчислення метрики необхідно ввести оціночні критерії.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = _service.GetValue(
                Parser.Parse(k1m1o1txt.Text),
                Parser.Parse(k1m1o2txt.Text),
                Parser.Parse(k1m1o3txt.Text),
                Parser.Parse(k1m1o4txt.Text),
                Parser.Parse(k1m1o5txt.Text),
                Parser.Parse(k1m1o6txt.Text),
                Parser.Parse(k1m1o7txt.Text),
                Parser.Parse(k1m1o8txt.Text),
                Parser.Parse(k1m1o9txt.Text),
                Parser.Parse(k1m1o10txt.Text));

            k1m1lblValue.Text = value.ToString();
        }

        // Скорегувати значення метрики 1. Засоби відновлення при помилках на вході за Шортліфом
        private void k1m1btnShot_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmptyLabel(k1m1lblValue))
            {
                MessageBox.Show("Для обчислення метрики необхідно ввести оціночні критерії.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = Parser.Parse(k1m1lblValue.Text);
            var form = new Form2();
            form.ShowDialog();
            var newValue = _service.GetNewValue(value, form.e1, form.e2);

            k1m1lblNewValue.Text = newValue.ToString();
        }

        #endregion
        
        #region Метрикa 2. Засоби відновлення після збоїв обладнання

        // Очистити значення оцінок метрики 2. Засоби відновлення після збоїв обладнання
        private void k1m2btnClear_Click(object sender, EventArgs e)
        {
            k1m2o1txt.Text = string.Empty;
            k1m2o2txt.Text = string.Empty;
            k1m2o3txt.Text = string.Empty;
            k1m2o4txt.Text = string.Empty;
            k1m2o5txt.Text = string.Empty;

            k1m2lblValue.Text = "0";
            k1m2lblNewValue.Text = "0";
        }

        // Отримати значення метрики 2. Засоби відновлення після збоїв обладнання
        private void k1m2btnOk_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(k1m2o1txt.Text, k1m2o2txt.Text, k1m2o3txt.Text, k1m2o4txt.Text, k1m2o5txt.Text))
            {
                MessageBox.Show("Для обчислення метрики необхідно ввести оціночні критерії.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = _service.GetValue(
                Parser.Parse(k1m2o1txt.Text),
                Parser.Parse(k1m2o2txt.Text),
                Parser.Parse(k1m2o3txt.Text),
                Parser.Parse(k1m2o4txt.Text),
                Parser.Parse(k1m2o5txt.Text));

            k1m2lblValue.Text = value.ToString();
        }

        // Скорегувати значення метрики 2. Засоби відновлення після збоїв обладнання
        private void k1m2btnShot_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmptyLabel(k1m2lblValue))
            {
                MessageBox.Show("Для обчислення метрики необхідно ввести оціночні критерії.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = Parser.Parse(k1m2lblValue.Text);
            var form = new Form2();
            form.ShowDialog();
            var newValue = _service.GetNewValue(value, form.e1, form.e2);

            k1m2lblNewValue.Text = newValue.ToString();
        }
        #endregion

        #region Метрика 3. Реалізація управління засобами відновлення

        // Очистити значення оцінок метрики 3. Реалізація управління засобами відновлення
        private void k1m3btnClear_Click(object sender, EventArgs e)
        {
            k1m3o1txt.Text = string.Empty;
            k1m3o2txt.Text = string.Empty;
            k1m3o3txt.Text = string.Empty;
            k1m3o4txt.Text = string.Empty;
            k1m3o5txt.Text = string.Empty;

            k1m3lblValue.Text = "0";
            k1m3lblNewValue.Text = "0";
        }

        // Отримати значення метрики 3. Реалізація управління засобами відновлення
        private void k1m3btnOk_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(k1m3o1txt.Text, k1m3o2txt.Text, k1m3o3txt.Text, k1m3o4txt.Text, k1m3o5txt.Text))
            {
                MessageBox.Show("Для обчислення метрики необхідно ввести оціночні критерії.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = _service.GetValue(
                Parser.Parse(k1m3o1txt.Text),
                Parser.Parse(k1m3o2txt.Text),
                Parser.Parse(k1m3o3txt.Text),
                Parser.Parse(k1m3o4txt.Text),
                Parser.Parse(k1m3o5txt.Text));

            k1m3lblValue.Text = value.ToString();
        }

        // Скорегувати значення метрики 3. Реалізація управління засобами відновлення
        private void k1m3btnShot_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmptyLabel(k1m3lblValue))
            {
                MessageBox.Show("Для обчислення метрики необхідно ввести оціночні критерії.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = Parser.Parse(k1m3lblValue.Text);
            var form = new Form2();
            form.ShowDialog();
            var newValue = _service.GetNewValue(value, form.e1, form.e2);

            k1m3lblNewValue.Text = newValue.ToString();
        }
        #endregion
        
        //Обчислити значення критерію 1. Стійкість функціонування
        private void k1Ok_Click(object sender, EventArgs e)
        {
            // Validate values and new values for all metrics of this criterio
            if (Validator.IsEmptyLabel(k1m1lblValue)
                || Validator.IsEmptyLabel(k1m1lblNewValue)
                || Validator.IsEmptyLabel(k1m2lblValue)
                || Validator.IsEmptyLabel(k1m2lblNewValue)
                || Validator.IsEmptyLabel(k1m3lblValue)
                || Validator.IsEmptyLabel(k1m3lblNewValue))
            {
                MessageBox.Show("Для обчислення необхідно визначити значення метрик.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var metrics = new List<string>
            {
                "Засоби відновлення при помилках на вході",
                "Засоби відновлення при збоях обладнання",
                "Реалізація управління засобами відновлення"
            };

            var form = new Form3(false, metrics);
            form.ShowDialog();

            if (form.IsStandart)
            {
                k1lblValue.Text = _service.GetMax(
                    Parser.Parse(k1m1lblNewValue.Text),
                    Parser.Parse(k1m2lblNewValue.Text),
                    Parser.Parse(k1m3lblNewValue.Text)).ToString();
            }
            else
            {
                switch(form.Index)
                {
                    case 0:
                        k1lblValue.Text = k1m1lblNewValue.Text; break;
                    case 1:
                        k1lblValue.Text = k1m2lblNewValue.Text; break;
                    case 2:
                        k1lblValue.Text = k1m3lblNewValue.Text; break;
                }
            }
        }

        // Скорегувати значення критерію 1. Стійкість функціонування
        private void k1Shot_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmptyLabel(k1lblValue))
            {
                MessageBox.Show("Для обчислення критерію необхідно обчислити значення метрик.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = Parser.Parse(k1lblValue.Text);
            var form = new Form2();
            form.ShowDialog();
            var newValue = _service.GetNewValue(value, form.e1, form.e2);

            k1lblNewValue.Text = newValue.ToString();
        }

        #endregion

        #region Критерій 2. Працездатність

        #region Метрика 4. Функціонування в заданих умовах

        // Очистити значення оцінок метрики 4. Функціонування в заданих умовах
        private void k2m1btnClear_Click(object sender, EventArgs e)
        {
            k2m1o1txt.Text = string.Empty;

            k2m1lblValue.Text = "0";
            k2m1lblNewValue.Text = "0";
        }

        // Отримати значення метрики 4. Функціонування в заданих умовах
        private void k2m1btnOk_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(k2m1o1txt.Text))
            {
                MessageBox.Show("Для обчислення метрики необхідно ввести оціночні критерії.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = _service.GetValue(
                Parser.Parse(k2m1o1txt.Text));

            k2m1lblValue.Text = value.ToString();
        }

        // Скорегувати значення метрики 4. Функціонування в заданих умовах
        private void k2m1btnShot_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmptyLabel(k2m1lblValue))
            {
                MessageBox.Show("Для обчислення метрики необхідно ввести оціночні критерії.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = Parser.Parse(k2m1lblValue.Text);
            var form = new Form2();
            form.ShowDialog();
            var newValue = _service.GetNewValue(value, form.e1, form.e2);

            k2m1lblNewValue.Text = newValue.ToString();
        }

        #endregion

        #region Метрика 5. Забезпечення обробки заданого об'єму інформації

        // Очистити значення оцінок метрики 5. Забезпечення обробки заданого об'єму інформації
        private void k2m2btnClear_Click(object sender, EventArgs e)
        {
            k2m2o1txt.Text = string.Empty;
            k2m2o2txt.Text = string.Empty;

            k2m2lblValue.Text = "0";
            k2m2lblNewValue.Text = "0";
        }

        // Отримати значення метрики 5. Забезпечення обробки заданого об'єму інформації
        private void k2m2btnOk_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(k2m2o1txt.Text, k2m2o2txt.Text))
            {
                MessageBox.Show("Для обчислення метрики необхідно ввести оціночні критерії.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = _service.GetValue(
                Parser.Parse(k2m2o1txt.Text),
                Parser.Parse(k2m2o2txt.Text));

            k2m2lblValue.Text = value.ToString();
        }

        // Скорегувати значення метрики 5. Забезпечення обробки заданого об'єму інформації
        private void k2m2btnShot_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmptyLabel(k2m2lblValue))
            {
                MessageBox.Show("Для обчислення метрики необхідно ввести оціночні критерії.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = Parser.Parse(k2m2lblValue.Text);
            var form = new Form2();
            form.ShowDialog();
            var newValue = _service.GetNewValue(value, form.e1, form.e2);

            k2m2lblNewValue.Text = newValue.ToString();
        }


        #endregion

        //Обчислити значення критерію 2. Працездатність
        private void k2Ok_Click(object sender, EventArgs e)
        {
            // Validate values and new values for all metrics of this criterio
            if (Validator.IsEmptyLabel(k2m1lblValue)
                || Validator.IsEmptyLabel(k2m1lblNewValue)
                || Validator.IsEmptyLabel(k2m2lblValue)
                || Validator.IsEmptyLabel(k2m2lblNewValue))
            {
                MessageBox.Show("Для обчислення необхідно визначити значення метрик.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var metrics = new List<string>
            {
                "Функціонування в заданих режимах",
                "Забезпечення обробки заданого об'єму інформації"
            };

            var form = new Form3(false, metrics);
            form.ShowDialog();

            if (form.IsStandart)
            {
                k2lblValue.Text = _service.GetMax(
                    Parser.Parse(k2m1lblNewValue.Text),
                    Parser.Parse(k2m2lblNewValue.Text)).ToString();
            }
            else
            {
                switch (form.Index)
                {
                    case 0:
                        k2lblValue.Text = k2m1lblNewValue.Text; break;
                    case 1:
                        k2lblValue.Text = k2m2lblNewValue.Text; break;
                }
            }
        }

        // Скорегувати значення критерію 2. Працездатність
        private void k2Shot_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmptyLabel(k2lblValue))
            {
                MessageBox.Show("Для обчислення критерію необхідно обчислити значення метрик.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var value = Parser.Parse(k2lblValue.Text);
            var form = new Form2();
            form.ShowDialog();
            var newValue = _service.GetNewValue(value, form.e1, form.e2);

            k2lblNewValue.Text = newValue.ToString();
        }

        #endregion

        private void fOk_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmptyLabel(k1lblValue)
                || Validator.IsEmptyLabel(k1lblNewValue)
                || Validator.IsEmptyLabel(k2lblValue)
                || Validator.IsEmptyLabel(k2lblNewValue))
            {
                MessageBox.Show("Для обчислення необхідно визначити значення критеріїв.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var criterias = new List<string>
            {
                "Стійкість функціонування",
                "Працездатність"
            };

            var form = new Form3(true, criterias);
            form.ShowDialog();

            if (form.IsStandart)
            {
                fLblValue.Text = _service.GetMax(
                    Parser.Parse(k1lblNewValue.Text),
                    Parser.Parse(k2lblNewValue.Text)).ToString();
            }
            else
            {
                switch (form.Index)
                {
                    case 0:
                        fLblValue.Text = k1lblNewValue.Text; break;
                    case 1:
                        fLblValue.Text = k2lblNewValue.Text; break;
                }
            }
        }        
    }
}
