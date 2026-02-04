namespace Wk4Assignment4._1._2Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnEqual = new Button();
            btAC = new Button();
            txtResult = new TextBox();
            btndivide = new Button();
            btnMultiply = new Button();
            btnClearInput = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnPlus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.Black;
            txtInput.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.ForeColor = SystemColors.Menu;
            txtInput.Location = new Point(13, 117);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(234, 71);
            txtInput.TabIndex = 0;
            txtInput.Text = "0";
            txtInput.TextAlign = HorizontalAlignment.Right;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(0, 64, 0);
            btnEqual.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.ForeColor = SystemColors.ButtonFace;
            btnEqual.ImageAlign = ContentAlignment.MiddleLeft;
            btnEqual.Location = new Point(193, 371);
            btnEqual.Name = "btnEqual";
            btnEqual.Padding = new Padding(3, 0, 0, 0);
            btnEqual.Size = new Size(54, 112);
            btnEqual.TabIndex = 12;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            // 
            // btAC
            // 
            btAC.BackColor = Color.Red;
            btAC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAC.ForeColor = SystemColors.ButtonFace;
            btAC.Location = new Point(13, 195);
            btAC.Name = "btAC";
            btAC.Size = new Size(54, 53);
            btAC.TabIndex = 18;
            btAC.Text = "AC";
            btAC.UseVisualStyleBackColor = false;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.Black;
            txtResult.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.WhiteSmoke;
            txtResult.Location = new Point(13, 31);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(234, 71);
            txtResult.TabIndex = 19;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btndivide
            // 
            btndivide.BackColor = Color.DarkGoldenrod;
            btndivide.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndivide.ForeColor = SystemColors.ButtonFace;
            btndivide.Location = new Point(73, 195);
            btndivide.Name = "btndivide";
            btndivide.Padding = new Padding(0, 0, 0, 4);
            btndivide.Size = new Size(54, 53);
            btndivide.TabIndex = 20;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.DarkGoldenrod;
            btnMultiply.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.ForeColor = SystemColors.ButtonFace;
            btnMultiply.Location = new Point(133, 195);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Padding = new Padding(2, 4, 0, 0);
            btnMultiply.Size = new Size(54, 53);
            btnMultiply.TabIndex = 21;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnClearInput
            // 
            btnClearInput.BackColor = Color.DarkGoldenrod;
            btnClearInput.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearInput.ForeColor = SystemColors.ButtonFace;
            btnClearInput.Location = new Point(193, 195);
            btnClearInput.Name = "btnClearInput";
            btnClearInput.Size = new Size(54, 53);
            btnClearInput.TabIndex = 22;
            btnClearInput.Text = "C";
            btnClearInput.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DarkGoldenrod;
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.ButtonFace;
            btn7.Location = new Point(13, 254);
            btn7.Name = "btn7";
            btn7.Size = new Size(54, 53);
            btn7.TabIndex = 23;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DarkGoldenrod;
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.ButtonFace;
            btn8.Location = new Point(73, 254);
            btn8.Name = "btn8";
            btn8.Size = new Size(54, 53);
            btn8.TabIndex = 24;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DarkGoldenrod;
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.ButtonFace;
            btn9.Location = new Point(133, 254);
            btn9.Name = "btn9";
            btn9.Size = new Size(54, 53);
            btn9.TabIndex = 25;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.DarkGoldenrod;
            btnPlus.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.ForeColor = SystemColors.ButtonFace;
            btnPlus.Location = new Point(193, 254);
            btnPlus.Name = "btnPlus";
            btnPlus.Padding = new Padding(0, 0, 0, 4);
            btnPlus.Size = new Size(54, 53);
            btnPlus.TabIndex = 26;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DarkGoldenrod;
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.ButtonFace;
            btn4.Location = new Point(13, 313);
            btn4.Name = "btn4";
            btn4.Size = new Size(54, 53);
            btn4.TabIndex = 27;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DarkGoldenrod;
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.ButtonFace;
            btn5.Location = new Point(73, 313);
            btn5.Name = "btn5";
            btn5.Size = new Size(54, 53);
            btn5.TabIndex = 28;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DarkGoldenrod;
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.ButtonFace;
            btn6.Location = new Point(133, 313);
            btn6.Name = "btn6";
            btn6.Size = new Size(54, 53);
            btn6.TabIndex = 29;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.DarkGoldenrod;
            btnMinus.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = SystemColors.ButtonFace;
            btnMinus.Location = new Point(193, 312);
            btnMinus.Name = "btnMinus";
            btnMinus.Padding = new Padding(0, 0, 0, 4);
            btnMinus.Size = new Size(54, 53);
            btnMinus.TabIndex = 30;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DarkGoldenrod;
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(13, 371);
            btn1.Name = "btn1";
            btn1.Size = new Size(54, 53);
            btn1.TabIndex = 31;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DarkGoldenrod;
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.ButtonFace;
            btn2.Location = new Point(73, 371);
            btn2.Name = "btn2";
            btn2.Size = new Size(54, 53);
            btn2.TabIndex = 32;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DarkGoldenrod;
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.ButtonFace;
            btn3.Location = new Point(133, 371);
            btn3.Name = "btn3";
            btn3.Size = new Size(54, 53);
            btn3.TabIndex = 33;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.DarkGoldenrod;
            btnDot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDot.ForeColor = SystemColors.ButtonFace;
            btnDot.Location = new Point(133, 427);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(54, 53);
            btnDot.TabIndex = 34;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.DarkGoldenrod;
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = SystemColors.ButtonFace;
            btn0.Location = new Point(13, 430);
            btn0.Name = "btn0";
            btn0.Size = new Size(114, 53);
            btn0.TabIndex = 35;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(259, 492);
            Controls.Add(btn0);
            Controls.Add(btnDot);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnClearInput);
            Controls.Add(btnMultiply);
            Controls.Add(btndivide);
            Controls.Add(txtResult);
            Controls.Add(btAC);
            Controls.Add(btnEqual);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnEqual;
        private Button btAC;
        private TextBox txtResult;
        private Button btndivide;
        private Button btnMultiply;
        private Button btnClearInput;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnPlus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnDot;
        private Button btn0;
    }
}
