using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechner
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            input += "1";
            setTextField(input);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input += "2";
            setTextField(input);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input += "3";
            setTextField(input);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input += "4";
            setTextField(input);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input += "5";
            setTextField(input);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input += "6";
            setTextField(input);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input += "7";
            setTextField(input);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input += "8";
            setTextField(input);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input += "9";
            setTextField(input);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input += "0";
            setTextField(input);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            input += ".";
            setTextField(input);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setOperand1();
            setTextField(operation.ToString());
            operation = '+';
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            setOperand1();
            operation = '-';
            setTextField(operation.ToString());
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            setOperand1();
            operation = '*';
            setTextField(operation.ToString());
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            setOperand1();
            operation = '/';
            setTextField(operation.ToString());
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            operation = (char)0;
            result = 0.0;

            setTextField(input);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            setTextField("");
            //txtBox.Text = "";
            //txtBox.Text = result.ToString();
        }

        private void setOperand1()
        {
            operand1 = input;
            input = string.Empty;
        }

        private void setTextField(string input)
        {
            txtBox.Text = "";
            txtBox.Text += operand1;
            txtBox.Text += operation;

            if(result > 0.0)
            {
                txtBox.Text += operand2;
                txtBox.Text += "=";
                txtBox.Text += result.ToString();
            }
            else if(!string.IsNullOrEmpty(operation.ToString()) && !string.IsNullOrEmpty(this.input))
            {
                txtBox.Text += input;
            }
        }
    }
}
