using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Assignment4._1._2Calculator
{
    internal interface ICalculator<T>
    {
        public T Add( T x, T y );
        public T Subtract( T x, T y );
        public T Multiply( T x, T y );
        public T Divide( T x, T y );
        public string AppendNum(TextBox currentText, string num);

        public void AllClear(TextBox inputText, TextBox resultText);
        public void ClearLine(TextBox inputText);
    }
}
