using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        calculatorClass calc = new calculatorClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void equalsSign_Click(object sender, EventArgs e)
        {
            switch (calc.Calcu_Operation)
            {
                case "+":
                    textBox_Answer.Text = (calc.Result_Value + Double.Parse(textBox_Answer.Text)).ToString();
                    break;

                case "-":
                    textBox_Answer.Text = (calc.Result_Value - Double.Parse(textBox_Answer.Text)).ToString();
                    break;

                case "*":
                    textBox_Answer.Text = (calc.Result_Value * Double.Parse(textBox_Answer.Text)).ToString();
                    break;

                case "/":
                    textBox_Answer.Text = (calc.Result_Value / Double.Parse(textBox_Answer.Text)).ToString();
                    break;
                default:
                    break;
            }
            calc.Result_Value = Double.Parse(textBox_Answer.Text);
            currentOperation_Label.Text = "";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Answer.Text == "0") || calc.IsOperationPerformed)
                textBox_Answer.Clear();

            calc.IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Answer.Text.Contains("."))
                    textBox_Answer.Text = textBox_Answer.Text + button.Text;
            }
            else
            textBox_Answer.Text = textBox_Answer.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (calc.Result_Value != 0)
            {
                btnEquals.PerformClick();
                calc.Calcu_Operation = button.Text;
                calc.Result_Value = Double.Parse(textBox_Answer.Text);
                currentOperation_Label.Text = calc.Result_Value + "" + calc.Calcu_Operation;
                calc.IsOperationPerformed = true;
            }
            else
            {
                calc.Calcu_Operation = button.Text;
                calc.Calcu_Operation = Double.Parse(textBox_Answer.Text).ToString();
                currentOperation_Label.Text = calc.Result_Value + "" + calc.Calcu_Operation;
                calc.IsOperationPerformed = true;
            }
        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            textBox_Answer.Text = "0";
            currentOperation_Label.Text = "";
            calc.Result_Value = 0;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox_Answer.Text = "0";
            currentOperation_Label.Text = "";
            calc.Result_Value = 0;
        }

        private void textBox_Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (!calc.IsInfinityException)
            {
                textBox_Answer.Text = (double.Parse(textBox_Answer.Text) * -1).ToString();
            }
        }
    }
}