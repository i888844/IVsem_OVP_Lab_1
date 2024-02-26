using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab._1.Classes;

namespace Lab._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ErrorProvider errorProvider = new ErrorProvider();

        private double valueTextBoxFirstA = 0.0;
        private double valueTextBoxFirstB = 0.0;
        private double valueTextBoxSecondA = 0.0;
        private double valueTextBoxSecondB = 0.0;
        private List<string> complexNumbersOfZ = new List<string>();

        private void textBoxFirstA_Click(object sender, EventArgs e)
        {
            textBoxFirstA.Text = string.Empty;
        }

        private void textBoxFirstB_Click(object sender, EventArgs e)
        {
            textBoxFirstB.Text = string.Empty;
        }

        private void textBoxSecondA_Click(object sender, EventArgs e)
        {
            textBoxSecondA.Text = string.Empty;
        }

        private void textBoxSecondB_Click(object sender, EventArgs e)
        {
            textBoxSecondB.Text = string.Empty;
        }

        //private bool valuesIsNotDefault()
        //{
        //    bool result = false;

        //    if (textBoxFirstA.Text != "a"
        //        && textBoxFirstB.Text != "b"
        //        && textBoxSecondA.Text != "a"
        //        && textBoxSecondB.Text != "b")
        //    {
        //        result = true;
        //    }

        //    return result;
        //}

        private bool valuesIsNumber()
        {
            bool result = false;

            if (double.TryParse(textBoxFirstA.Text, out valueTextBoxFirstA)
                && double.TryParse(textBoxFirstB.Text, out valueTextBoxFirstB)
                && double.TryParse(textBoxSecondA.Text, out valueTextBoxSecondA)
                && double.TryParse(textBoxSecondB.Text, out valueTextBoxSecondB))
            {
                result = true;
            }

            return result;
        }

        private void operating()
        {
            try
            {
                ComplexNumberOperator Z = new ComplexNumberOperator(valueTextBoxFirstA, valueTextBoxFirstB, valueTextBoxSecondA, valueTextBoxSecondB);

                string result = "";

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        result = Z.Add().ToString();
                        labelInputComplexNumberValue.Text = Z.ToString();
                        labelOperationValue.Text = "сложение";
                        labelResultValue.Text = $"Z = {result}";
                        break;
                    case 1:
                        result = Z.Subtract().ToString();
                        labelInputComplexNumberValue.Text = Z.ToString();
                        labelOperationValue.Text = "вычитание";
                        labelResultValue.Text = $"Z = {result}";
                        break;
                    case 2:
                        result = Z.Multiply().ToString();
                        labelInputComplexNumberValue.Text = Z.ToString();
                        labelOperationValue.Text = "умножение";
                        labelResultValue.Text = $"Z = {result}";
                        break;
                    case 3:
                        result = Z.Divide().ToString();
                        labelInputComplexNumberValue.Text = Z.ToString();
                        labelOperationValue.Text = "деление";
                        labelResultValue.Text = $"Z = {result}";
                        break;
                    default:
                        throw new InvalidOperationException("Выбрана недопустимая операция.");
                }

                complexNumbersOfZ.Clear();
                complexNumbersOfZ.Add(Z.СomplexNumbers[0].ToString());
                complexNumbersOfZ.Add(Z.СomplexNumbers[1].ToString());
                errorProvider.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при выполнении операции: {ex.Message}",
                    "Ошибка выполнения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                errorProvider.SetError(button1, ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox1.SelectedIndex <= 3)
            {
                if (valuesIsNumber())
                {
                    operating();
                }
                else
                {
                    errorProvider.SetError(button1, "Значения комплексного числа введены некорректно. Операция над не может быть выполнена");
                }
            }
            else
            {
                errorProvider.SetError(button1, "Операция над комплексными числами выбрана некорректно");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 1)
                {
                    MessageBox.Show($"Z[{comboBox2.SelectedIndex}] = {complexNumbersOfZ[comboBox2.SelectedIndex]}",
                        $"Комплексное число с индексом {comboBox2.SelectedIndex}",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider.SetError(button2, "Значение индекса комплексного числа выбрано некорректно");
                }
            }
            catch (Exception ex)
            {
                errorProvider.SetError(button2, $"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
