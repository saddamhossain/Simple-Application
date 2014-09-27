using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        Calculator aCalculator = new Calculator();
        private double firstNumber;
        private double secondNumber;
        private double result;

        private void addButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNumberAndSecondNumber();
            result = aCalculator.Add(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void InitializeFirstNumberAndSecondNumber()
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNumberAndSecondNumber();
            result = aCalculator.Subtract(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }


        private void multiplyButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNumberAndSecondNumber();
            result = aCalculator.Multiply(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNumberAndSecondNumber();
            result = aCalculator.Divide(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }
    }
}
