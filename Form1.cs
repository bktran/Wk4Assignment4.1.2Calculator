namespace Wk4Assignment4._1._2Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator calc = new Calculator();
        Operation currentOperation = Operation.None;
        double left = 0;
        double result = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Text = "0";
            txtResult.Text = "";
        }

        private void btAC_Click(object sender, EventArgs e)
        {
            calc.AllClear(txtInput, txtResult);
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            calc.ClearLine(txtInput);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, "1");
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, "2");
            
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, "3");
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, "4");
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, "5");
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, "6");
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, "7");
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, "8");
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, "9");
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, "0");
            
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtInput.Text = calc.AppendNum(txtInput, ".");
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            currentOperation = Operation.Add;
            if (txtInput.Text == "")
            {
                if (!txtResult.Text.EndsWith("+"))
                {
                    txtResult.Text = txtResult.Text + "+";
                }

                left = double.Parse(txtResult.Text.TrimEnd('+'));
                return;
            }

            left = double.Parse(txtInput.Text);
            txtResult.Text = txtInput.Text + "+";

            txtInput.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            currentOperation = Operation.Subtract;
            if (txtInput.Text == "")
            {
                if (!txtResult.Text.EndsWith("-"))
                {
                    txtResult.Text = txtResult.Text + "-";
                }

                left = double.Parse(txtResult.Text.TrimEnd('-'));
                return;
            }

            left = double.Parse(txtInput.Text);
            txtResult.Text = txtInput.Text + "-";

            txtInput.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            currentOperation = Operation.Multiply;
            if (txtInput.Text == "")
            {
                if (!txtResult.Text.EndsWith("x"))
                {
                    txtResult.Text = txtResult.Text + "x";
                }

                left = double.Parse(txtResult.Text.TrimEnd('x'));
                return;
            }

            left = double.Parse(txtInput.Text);
            txtResult.Text = txtInput.Text + "x";

            txtInput.Text = "";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            currentOperation = Operation.Divide;
            if (txtInput.Text == "")
            {
                if (!txtResult.Text.EndsWith("/"))
                {
                    txtResult.Text = txtResult.Text + "/";
                }

                left = double.Parse(txtResult.Text.TrimEnd('/'));
                return;
            }

            left = double.Parse(txtInput.Text);
            txtResult.Text = txtInput.Text + "/";

            txtInput.Text = "";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInput.Text, out double right))
            {
                return;
            }
            switch (currentOperation)
            {
                case Operation.Add:
                    result = calc.Add(left, right);
                    break;
                case Operation.Subtract:
                    result = calc.Subtract(left, right);
                    break;
                case Operation.Multiply:
                    result = calc.Multiply(left, right);
                    break;
                case Operation.Divide:
                    result = calc.Divide(left, right);
                    break;
                default:
                    return;                      
            }

            left = result;
            txtResult.Text = result.ToString();
            txtInput.Text = "";
            currentOperation = Operation.None;

        }
    }
}
