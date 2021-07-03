﻿using System;
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

        public double Result_Value { get => result_Value; set => result_Value = value; }
        public string Calcu_Operation { get => calcu_Operation; set => calcu_Operation = value; }
        public bool IsOperationPerformed { get => isOperationPerformed; set => isOperationPerformed = value; }
        public bool IsInfinityException { get => isInfinityException; set => isInfinityException = value; }
        public double A { get; set; }
        public double B { get; set; }

        public static double Addition(Double A, Double B) { return A + B; }
        public static double Subtract(Double A, Double B) { return A - B; }
        public static double Multiply(Double A, Double B) { return A * B; }
        public static double Divide(Double A, Double B) { return A / B; }

    }
}
