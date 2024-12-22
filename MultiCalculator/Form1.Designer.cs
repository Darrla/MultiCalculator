namespace MultiCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnASin = new System.Windows.Forms.Button();
            this.btnACos = new System.Windows.Forms.Button();
            this.btnATan = new System.Windows.Forms.Button();
            this.btnCot = new System.Windows.Forms.Button();
            this.btnACot = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(282, 77);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(351, 22);
            this.resultTextBox.TabIndex = 0;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(405, 243);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(31, 23);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(368, 156);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(31, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(405, 156);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(31, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(442, 156);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(31, 23);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(368, 185);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(31, 23);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(405, 185);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(31, 23);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(442, 185);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(31, 23);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(368, 214);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(31, 23);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(405, 214);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(31, 23);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(442, 214);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(31, 23);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(479, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(479, 185);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(31, 23);
            this.btnSubtract.TabIndex = 12;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(516, 185);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(31, 23);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(516, 156);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(31, 23);
            this.btnDivide.TabIndex = 14;
            this.btnDivide.Text = "\\";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(479, 214);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(31, 23);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(516, 214);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(31, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(304, 214);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(42, 23);
            this.btnPower.TabIndex = 17;
            this.btnPower.Text = "x^y";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(304, 185);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(42, 23);
            this.btnSqrt.TabIndex = 18;
            this.btnSqrt.Text = "√x";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(572, 156);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(42, 23);
            this.btnSin.TabIndex = 19;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(572, 185);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(42, 23);
            this.btnCos.TabIndex = 20;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(572, 214);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(42, 23);
            this.btnTan.TabIndex = 21;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnASin
            // 
            this.btnASin.Location = new System.Drawing.Point(620, 156);
            this.btnASin.Name = "btnASin";
            this.btnASin.Size = new System.Drawing.Size(54, 23);
            this.btnASin.TabIndex = 22;
            this.btnASin.Text = "arcsin";
            this.btnASin.UseVisualStyleBackColor = true;
            this.btnASin.Click += new System.EventHandler(this.btnASin_Click);
            // 
            // btnACos
            // 
            this.btnACos.Location = new System.Drawing.Point(620, 185);
            this.btnACos.Name = "btnACos";
            this.btnACos.Size = new System.Drawing.Size(54, 23);
            this.btnACos.TabIndex = 23;
            this.btnACos.Text = "arccos";
            this.btnACos.UseVisualStyleBackColor = true;
            this.btnACos.Click += new System.EventHandler(this.btnACos_Click);
            // 
            // btnATan
            // 
            this.btnATan.Location = new System.Drawing.Point(620, 214);
            this.btnATan.Name = "btnATan";
            this.btnATan.Size = new System.Drawing.Size(54, 23);
            this.btnATan.TabIndex = 24;
            this.btnATan.Text = "arctan";
            this.btnATan.UseVisualStyleBackColor = true;
            this.btnATan.Click += new System.EventHandler(this.btnATan_Click);
            // 
            // btnCot
            // 
            this.btnCot.Location = new System.Drawing.Point(572, 243);
            this.btnCot.Name = "btnCot";
            this.btnCot.Size = new System.Drawing.Size(42, 23);
            this.btnCot.TabIndex = 25;
            this.btnCot.Text = "cot";
            this.btnCot.UseVisualStyleBackColor = true;
            this.btnCot.Click += new System.EventHandler(this.btnCot_Click);
            // 
            // btnACot
            // 
            this.btnACot.Location = new System.Drawing.Point(620, 243);
            this.btnACot.Name = "btnACot";
            this.btnACot.Size = new System.Drawing.Size(54, 23);
            this.btnACot.TabIndex = 26;
            this.btnACot.Text = "arccot";
            this.btnACot.UseVisualStyleBackColor = true;
            this.btnACot.Click += new System.EventHandler(this.btnACot_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.Location = new System.Drawing.Point(304, 156);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(42, 23);
            this.btnNegate.TabIndex = 27;
            this.btnNegate.Text = "+/-";
            this.btnNegate.UseVisualStyleBackColor = true;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 16;
            this.historyListBox.Location = new System.Drawing.Point(59, 77);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(180, 164);
            this.historyListBox.TabIndex = 28;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(59, 243);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(180, 23);
            this.btnClearHistory.TabIndex = 29;
            this.btnClearHistory.Text = "Очистить историю";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.btnNegate);
            this.Controls.Add(this.btnACot);
            this.Controls.Add(this.btnCot);
            this.Controls.Add(this.btnATan);
            this.Controls.Add(this.btnACos);
            this.Controls.Add(this.btnASin);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.resultTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnASin;
        private System.Windows.Forms.Button btnACos;
        private System.Windows.Forms.Button btnATan;
        private System.Windows.Forms.Button btnCot;
        private System.Windows.Forms.Button btnACot;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button btnClearHistory;
    }
}


