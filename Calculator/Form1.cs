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

        public void Label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox_Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void equalsSign_Click(object sender, EventArgs e)
        {
            switch (calc.Calcu_Operation)
            {
                case "+":
                    textBox_Result.Text = (calc.Result_Value + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (calc.Result_Value - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (calc.Result_Value * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (calc.Result_Value / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            calc.Result_Value = Double.Parse(textBox_Result.Text);
            currentOperation_Label.Text = "";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || calc.IsOperationPerformed)
            { textBox_Result.Clear(); }

            calc.IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (calc.Result_Value != 0)
            {
                btnEquals.PerformClick();
                calc.Calcu_Operation = button.Text;
                calc.Result_Value = Double.Parse(textBox_Result.Text);
                currentOperation_Label.Text = calc.Result_Value + "" + calc.Calcu_Operation;
                calc.IsOperationPerformed = true;
            }
            else
            {
                calc.Calcu_Operation = button.Text;
                calc.Calcu_Operation = Double.Parse(textBox_Result.Text).ToString();
                currentOperation_Label.Text = calc.Result_Value + "" + calc.Calcu_Operation;
                calc.IsOperationPerformed = true;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (!calc.IsInfinityException)
            { textBox_Result.Text = (double.Parse(textBox_Result.Text) * -1).ToString(); }
        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            textBox_Result.ResetText();
            currentOperation_Label.Text = "";
            calc.Result_Value = 0;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox_Result.ResetText();
            currentOperation_Label.Text = "";
            calc.Result_Value = 0;
        }
    }
}