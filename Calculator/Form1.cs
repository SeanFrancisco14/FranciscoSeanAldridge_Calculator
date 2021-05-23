using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result_Value = 0;
        string calcu_Operation = "";
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

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_Answer.Text == "0")
                textBox_Answer.Clear();

           Button button = (Button)sender;
            textBox_Answer.Text = textBox_Answer.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calcu_Operation = button.Text;
            result_Value = Double.Parse(textBox_Answer.Text); 
        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            textBox_Answer.Text = "0";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox_Answer.Text = "0";
            result_Value = 0;
        }
    }
}
