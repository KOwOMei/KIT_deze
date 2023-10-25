using System;
using System.Windows.Forms;

namespace DesignCalc
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            this.Text = "Design-Calc";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(FirstNumberTextBox.Text, out double num1) &&
                double.TryParse(SecondNumberTextBox.Text, out double num2))
            {
                if (OperationComboBox.SelectedItem != null)
                {
                    string selectedOperation = OperationComboBox.SelectedItem.ToString();
                    double result = 0;

                    switch (selectedOperation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                            }
                            else
                            {
                                MessageBox.Show("Ошибка: деление на ноль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        default:
                            MessageBox.Show("Ошибка: Неверная операция.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    ResultLabel.Text = "Результат: " + result;
                    FirstNumberTextBox.Clear();
                    SecondNumberTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите операцию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

