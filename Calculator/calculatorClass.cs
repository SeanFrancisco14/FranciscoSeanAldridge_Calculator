using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calculatorClass
    {
        private Double result_Value = 0;
        private string calcu_Operation = "";
        private bool isOperationPerformed = false;
        private bool isInfinityException = false;
        private String num1 = "";
        private String num2 = "";

        public double Result_Value { get => result_Value; set => result_Value = value; }
        public string Calcu_Operation { get => calcu_Operation; set => calcu_Operation = value; }
        public bool IsOperationPerformed { get => isOperationPerformed; set => isOperationPerformed = value; }
        public bool IsInfinityException { get => isInfinityException; set => isInfinityException = value; }
        public string Num1 { get => num1; set => num1 = value; }
        public string Num2 { get => num2; set => num2 = value; }
    }
}
