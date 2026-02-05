using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Assignment4._1._2Calculator
{
    internal class Calculator : ICalculator<double>
    { 
        public string Number { get; set; } = string.Empty;
        public double Add(double x, double y)
        {
            return x + y;
        }

        public void AllClear(TextBox input, TextBox result)
        {
            input.Text = "";
            result.Text = "";
        }

        public string AppendNum(TextBox currentText, string num)
        {
            if (currentText.Text == "0" && num != ".")
            {
                return num.ToString();
            }
            if (currentText.Text.Length == 7)
            {
                return currentText.Text;
            }
            if (num == "." && currentText.Text.Contains("."))
            {
                return currentText.Text;
            }
            StringBuilder input = new StringBuilder();
            this.Number = input.Append(currentText.Text).Append(num).ToString();
            return this.Number;
        }

        public void ClearLine(TextBox input)
        {
            input.Text = "";
            
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
