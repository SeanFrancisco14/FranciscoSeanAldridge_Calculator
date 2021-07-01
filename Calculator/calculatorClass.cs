using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calculatorClass
    {
        Form1 form1 = new Form1();
        private Double result_Value = 0;
        private string calcu_Operation = "";
        private bool isOperationPerformed = false;
        private bool isInfinityException = false;

        public double Result_Value { get => result_Value; set => result_Value = value; }
        public string Calcu_Operation { get => calcu_Operation; set => calcu_Operation = value; }
        public bool IsOperationPerformed { get => isOperationPerformed; set => isOperationPerformed = value; }
        public bool IsInfinityException { get => isInfinityException; set => isInfinityException = value; }
        public Form1 Form1 { get => form1; set => form1 = value; }

        public void Clear()
        {
            Form1.textBox_Answer.Text = "0";
            Form1.currentOperation_Label.Text = "";
            result_Value = 0;
        }
    }
}
