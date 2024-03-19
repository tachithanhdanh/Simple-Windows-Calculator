namespace Simple_Windows_Calculator
{
    partial class SimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleCalculator));
            btnBack = new Button();
            btnClear = new Button();
            btnClearEntry = new Button();
            btnPercent = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNum0 = new Button();
            btnPlusMinus = new Button();
            btnEqual = new Button();
            btnDot = new Button();
            btnNum2 = new Button();
            btnNum7 = new Button();
            btnNum3 = new Button();
            btnAdd = new Button();
            btnNum6 = new Button();
            btnNum5 = new Button();
            btnNum1 = new Button();
            btnSubtract = new Button();
            btnNum9 = new Button();
            btnNum8 = new Button();
            btnNum4 = new Button();
            btnMultiply = new Button();
            btnSquare = new Button();
            btnInverse = new Button();
            btnSquareRoot = new Button();
            btnDivide = new Button();
            textMainDisplay = new TextBox();
            textFormulaDisplay = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = Color.FromArgb(50, 50, 50);
            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 14F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(378, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 93);
            btnBack.TabIndex = 2;
            btnBack.TabStop = false;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += ButtonBack_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.FromArgb(50, 50, 50);
            btnClear.Dock = DockStyle.Fill;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 14F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(253, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 93);
            btnClear.TabIndex = 3;
            btnClear.TabStop = false;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += ButtonClear_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.AutoSize = true;
            btnClearEntry.BackColor = Color.FromArgb(50, 50, 50);
            btnClearEntry.Dock = DockStyle.Fill;
            btnClearEntry.FlatAppearance.BorderSize = 0;
            btnClearEntry.FlatStyle = FlatStyle.Flat;
            btnClearEntry.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearEntry.ForeColor = Color.White;
            btnClearEntry.Location = new Point(128, 3);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(119, 93);
            btnClearEntry.TabIndex = 1;
            btnClearEntry.TabStop = false;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += ButtonClearEntry_Click;
            // 
            // btnPercent
            // 
            btnPercent.AutoSize = true;
            btnPercent.BackColor = Color.FromArgb(50, 50, 50);
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.FlatAppearance.BorderSize = 0;
            btnPercent.FlatStyle = FlatStyle.Flat;
            btnPercent.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPercent.ForeColor = Color.White;
            btnPercent.Location = new Point(3, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(119, 93);
            btnPercent.TabIndex = 0;
            btnPercent.TabStop = false;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += ButtonSpecialOperation_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnNum0, 0, 5);
            tableLayoutPanel1.Controls.Add(btnPlusMinus, 0, 5);
            tableLayoutPanel1.Controls.Add(btnEqual, 0, 5);
            tableLayoutPanel1.Controls.Add(btnDot, 0, 5);
            tableLayoutPanel1.Controls.Add(btnNum2, 0, 4);
            tableLayoutPanel1.Controls.Add(btnNum7, 0, 1);
            tableLayoutPanel1.Controls.Add(btnNum3, 0, 4);
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 4);
            tableLayoutPanel1.Controls.Add(btnNum6, 0, 3);
            tableLayoutPanel1.Controls.Add(btnNum5, 0, 3);
            tableLayoutPanel1.Controls.Add(btnNum1, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSubtract, 0, 3);
            tableLayoutPanel1.Controls.Add(btnNum9, 0, 2);
            tableLayoutPanel1.Controls.Add(btnNum8, 0, 2);
            tableLayoutPanel1.Controls.Add(btnNum4, 0, 2);
            tableLayoutPanel1.Controls.Add(btnMultiply, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSquare, 0, 1);
            tableLayoutPanel1.Controls.Add(btnInverse, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSquareRoot, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDivide, 0, 1);
            tableLayoutPanel1.Controls.Add(btnPercent, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClearEntry, 1, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel1.Controls.Add(btnBack, 3, 0);
            tableLayoutPanel1.Location = new Point(12, 165);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(501, 597);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNum0
            // 
            btnNum0.AutoSize = true;
            btnNum0.BackColor = Color.FromArgb(59, 59, 59);
            btnNum0.Dock = DockStyle.Fill;
            btnNum0.FlatAppearance.BorderSize = 0;
            btnNum0.FlatStyle = FlatStyle.Flat;
            btnNum0.Font = new Font("Segoe UI Semibold", 16F);
            btnNum0.ForeColor = Color.White;
            btnNum0.Location = new Point(128, 498);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(119, 96);
            btnNum0.TabIndex = 28;
            btnNum0.TabStop = false;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += ButtonNumbers_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.AutoSize = true;
            btnPlusMinus.BackColor = Color.FromArgb(59, 59, 59);
            btnPlusMinus.Dock = DockStyle.Fill;
            btnPlusMinus.FlatAppearance.BorderSize = 0;
            btnPlusMinus.FlatStyle = FlatStyle.Flat;
            btnPlusMinus.Font = new Font("Segoe UI Semibold", 16F);
            btnPlusMinus.ForeColor = Color.White;
            btnPlusMinus.Location = new Point(3, 498);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(119, 96);
            btnPlusMinus.TabIndex = 27;
            btnPlusMinus.TabStop = false;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += ButtonPlusMinus_Click;
            // 
            // btnEqual
            // 
            btnEqual.AutoSize = true;
            btnEqual.BackColor = Color.FromArgb(76, 194, 255);
            btnEqual.Dock = DockStyle.Fill;
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Segoe UI Semibold", 18F);
            btnEqual.ForeColor = Color.FromArgb(21, 54, 71);
            btnEqual.Location = new Point(378, 498);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(120, 96);
            btnEqual.TabIndex = 26;
            btnEqual.TabStop = false;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += ButtonEqual_Click;
            // 
            // btnDot
            // 
            btnDot.AutoSize = true;
            btnDot.BackColor = Color.FromArgb(59, 59, 59);
            btnDot.Dock = DockStyle.Fill;
            btnDot.FlatAppearance.BorderSize = 0;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Segoe UI Semibold", 16F);
            btnDot.ForeColor = Color.White;
            btnDot.Location = new Point(253, 498);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(119, 96);
            btnDot.TabIndex = 25;
            btnDot.TabStop = false;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += ButtonDot_Click;
            // 
            // btnNum2
            // 
            btnNum2.AutoSize = true;
            btnNum2.BackColor = Color.FromArgb(59, 59, 59);
            btnNum2.Dock = DockStyle.Fill;
            btnNum2.FlatAppearance.BorderSize = 0;
            btnNum2.FlatStyle = FlatStyle.Flat;
            btnNum2.Font = new Font("Segoe UI Semibold", 16F);
            btnNum2.ForeColor = Color.White;
            btnNum2.Location = new Point(128, 399);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(119, 93);
            btnNum2.TabIndex = 24;
            btnNum2.TabStop = false;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += ButtonNumbers_Click;
            // 
            // btnNum7
            // 
            btnNum7.AutoSize = true;
            btnNum7.BackColor = Color.FromArgb(59, 59, 59);
            btnNum7.Dock = DockStyle.Fill;
            btnNum7.FlatAppearance.BorderSize = 0;
            btnNum7.FlatStyle = FlatStyle.Flat;
            btnNum7.Font = new Font("Segoe UI Semibold", 16F);
            btnNum7.ForeColor = Color.White;
            btnNum7.Location = new Point(3, 201);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(119, 93);
            btnNum7.TabIndex = 23;
            btnNum7.TabStop = false;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += ButtonNumbers_Click;
            // 
            // btnNum3
            // 
            btnNum3.AutoSize = true;
            btnNum3.BackColor = Color.FromArgb(59, 59, 59);
            btnNum3.Dock = DockStyle.Fill;
            btnNum3.FlatAppearance.BorderSize = 0;
            btnNum3.FlatStyle = FlatStyle.Flat;
            btnNum3.Font = new Font("Segoe UI Semibold", 16F);
            btnNum3.ForeColor = Color.White;
            btnNum3.Location = new Point(253, 399);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(119, 93);
            btnNum3.TabIndex = 22;
            btnNum3.TabStop = false;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += ButtonNumbers_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(50, 50, 50);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 18F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(378, 399);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 93);
            btnAdd.TabIndex = 21;
            btnAdd.TabStop = false;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += ButtonBasicOperation_Click;
            // 
            // btnNum6
            // 
            btnNum6.AutoSize = true;
            btnNum6.BackColor = Color.FromArgb(59, 59, 59);
            btnNum6.Dock = DockStyle.Fill;
            btnNum6.FlatAppearance.BorderSize = 0;
            btnNum6.FlatStyle = FlatStyle.Flat;
            btnNum6.Font = new Font("Segoe UI Semibold", 16F);
            btnNum6.ForeColor = Color.White;
            btnNum6.Location = new Point(253, 300);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(119, 93);
            btnNum6.TabIndex = 20;
            btnNum6.TabStop = false;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += ButtonNumbers_Click;
            // 
            // btnNum5
            // 
            btnNum5.AutoSize = true;
            btnNum5.BackColor = Color.FromArgb(59, 59, 59);
            btnNum5.Dock = DockStyle.Fill;
            btnNum5.FlatAppearance.BorderSize = 0;
            btnNum5.FlatStyle = FlatStyle.Flat;
            btnNum5.Font = new Font("Segoe UI Semibold", 16F);
            btnNum5.ForeColor = Color.White;
            btnNum5.Location = new Point(128, 300);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(119, 93);
            btnNum5.TabIndex = 19;
            btnNum5.TabStop = false;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += ButtonNumbers_Click;
            // 
            // btnNum1
            // 
            btnNum1.AutoSize = true;
            btnNum1.BackColor = Color.FromArgb(59, 59, 59);
            btnNum1.Dock = DockStyle.Fill;
            btnNum1.FlatAppearance.BorderSize = 0;
            btnNum1.FlatStyle = FlatStyle.Flat;
            btnNum1.Font = new Font("Segoe UI Semibold", 16F);
            btnNum1.ForeColor = Color.White;
            btnNum1.Location = new Point(3, 399);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(119, 93);
            btnNum1.TabIndex = 18;
            btnNum1.TabStop = false;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += ButtonNumbers_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.AutoSize = true;
            btnSubtract.BackColor = Color.FromArgb(50, 50, 50);
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.FlatAppearance.BorderSize = 0;
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Segoe UI Semibold", 18F);
            btnSubtract.ForeColor = Color.White;
            btnSubtract.Location = new Point(378, 300);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(120, 93);
            btnSubtract.TabIndex = 17;
            btnSubtract.TabStop = false;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += ButtonBasicOperation_Click;
            // 
            // btnNum9
            // 
            btnNum9.AutoSize = true;
            btnNum9.BackColor = Color.FromArgb(59, 59, 59);
            btnNum9.Dock = DockStyle.Fill;
            btnNum9.FlatAppearance.BorderSize = 0;
            btnNum9.FlatStyle = FlatStyle.Flat;
            btnNum9.Font = new Font("Segoe UI Semibold", 16F);
            btnNum9.ForeColor = Color.White;
            btnNum9.Location = new Point(253, 201);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(119, 93);
            btnNum9.TabIndex = 16;
            btnNum9.TabStop = false;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += ButtonNumbers_Click;
            // 
            // btnNum8
            // 
            btnNum8.AutoSize = true;
            btnNum8.BackColor = Color.FromArgb(59, 59, 59);
            btnNum8.Dock = DockStyle.Fill;
            btnNum8.FlatAppearance.BorderSize = 0;
            btnNum8.FlatStyle = FlatStyle.Flat;
            btnNum8.Font = new Font("Segoe UI Semibold", 16F);
            btnNum8.ForeColor = Color.White;
            btnNum8.Location = new Point(128, 201);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(119, 93);
            btnNum8.TabIndex = 15;
            btnNum8.TabStop = false;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += ButtonNumbers_Click;
            // 
            // btnNum4
            // 
            btnNum4.AutoSize = true;
            btnNum4.BackColor = Color.FromArgb(59, 59, 59);
            btnNum4.Dock = DockStyle.Fill;
            btnNum4.FlatAppearance.BorderSize = 0;
            btnNum4.FlatStyle = FlatStyle.Flat;
            btnNum4.Font = new Font("Segoe UI Semibold", 16F);
            btnNum4.ForeColor = Color.White;
            btnNum4.Location = new Point(3, 300);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(119, 93);
            btnNum4.TabIndex = 14;
            btnNum4.TabStop = false;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += ButtonNumbers_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.AutoSize = true;
            btnMultiply.BackColor = Color.FromArgb(50, 50, 50);
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI Semibold", 18F);
            btnMultiply.ForeColor = Color.White;
            btnMultiply.Location = new Point(378, 201);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(120, 93);
            btnMultiply.TabIndex = 13;
            btnMultiply.TabStop = false;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += ButtonBasicOperation_Click;
            // 
            // btnSquare
            // 
            btnSquare.AutoSize = true;
            btnSquare.BackColor = Color.FromArgb(50, 50, 50);
            btnSquare.Dock = DockStyle.Fill;
            btnSquare.FlatAppearance.BorderSize = 0;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Segoe UI Semibold", 14F);
            btnSquare.ForeColor = Color.White;
            btnSquare.Location = new Point(128, 102);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(119, 93);
            btnSquare.TabIndex = 12;
            btnSquare.TabStop = false;
            btnSquare.Text = "x²";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += ButtonSpecialOperation_Click;
            // 
            // btnInverse
            // 
            btnInverse.AutoSize = true;
            btnInverse.BackColor = Color.FromArgb(50, 50, 50);
            btnInverse.Dock = DockStyle.Fill;
            btnInverse.FlatAppearance.BorderSize = 0;
            btnInverse.FlatStyle = FlatStyle.Flat;
            btnInverse.Font = new Font("Segoe UI Semibold", 14F);
            btnInverse.ForeColor = Color.White;
            btnInverse.Location = new Point(3, 102);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(119, 93);
            btnInverse.TabIndex = 11;
            btnInverse.TabStop = false;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = false;
            btnInverse.Click += ButtonSpecialOperation_Click;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.AutoSize = true;
            btnSquareRoot.BackColor = Color.FromArgb(50, 50, 50);
            btnSquareRoot.Dock = DockStyle.Fill;
            btnSquareRoot.FlatAppearance.BorderSize = 0;
            btnSquareRoot.FlatStyle = FlatStyle.Flat;
            btnSquareRoot.Font = new Font("Segoe UI Semibold", 14F);
            btnSquareRoot.ForeColor = Color.White;
            btnSquareRoot.Location = new Point(253, 102);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(119, 93);
            btnSquareRoot.TabIndex = 10;
            btnSquareRoot.TabStop = false;
            btnSquareRoot.Text = "√x";
            btnSquareRoot.UseVisualStyleBackColor = false;
            btnSquareRoot.Click += ButtonSpecialOperation_Click;
            // 
            // btnDivide
            // 
            btnDivide.AutoSize = true;
            btnDivide.BackColor = Color.FromArgb(50, 50, 50);
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI Semibold", 18F);
            btnDivide.ForeColor = Color.White;
            btnDivide.Location = new Point(378, 102);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(120, 93);
            btnDivide.TabIndex = 9;
            btnDivide.TabStop = false;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += ButtonBasicOperation_Click;
            // 
            // textMainDisplay
            // 
            textMainDisplay.BackColor = Color.FromArgb(32, 32, 32);
            textMainDisplay.BorderStyle = BorderStyle.None;
            textMainDisplay.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            textMainDisplay.ForeColor = Color.White;
            textMainDisplay.Location = new Point(12, 90);
            textMainDisplay.Name = "textMainDisplay";
            textMainDisplay.Size = new Size(501, 64);
            textMainDisplay.TabIndex = 1;
            textMainDisplay.TabStop = false;
            textMainDisplay.Text = "0";
            textMainDisplay.TextAlign = HorizontalAlignment.Right;
            textMainDisplay.MouseDown += MainDisplay_MouseDown;
            // 
            // textFormulaDisplay
            // 
            textFormulaDisplay.BackColor = Color.FromArgb(32, 32, 32);
            textFormulaDisplay.BorderStyle = BorderStyle.None;
            textFormulaDisplay.Enabled = false;
            textFormulaDisplay.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            textFormulaDisplay.ForeColor = Color.White;
            textFormulaDisplay.Location = new Point(15, 26);
            textFormulaDisplay.Name = "textFormulaDisplay";
            textFormulaDisplay.ReadOnly = true;
            textFormulaDisplay.Size = new Size(501, 43);
            textFormulaDisplay.TabIndex = 2;
            textFormulaDisplay.TabStop = false;
            textFormulaDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(525, 774);
            Controls.Add(textFormulaDisplay);
            Controls.Add(textMainDisplay);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "SimpleCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator";
            Load += Form1_Load;
            KeyDown += SimpleCalculator_KeyDown;
            KeyPress += SimpleCalculator_KeyPress;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnBack;
        private Button btnClear;
        private Button btnClearEntry;
        private Button btnPercent;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNum0;
        private Button btnPlusMinus;
        private Button btnEqual;
        private Button btnDot;
        private Button btnNum2;
        private Button btnNum7;
        private Button btnNum3;
        private Button btnAdd;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnNum1;
        private Button btnSubtract;
        private Button btnNum9;
        private Button btnNum8;
        private Button btnNum4;
        private Button btnMultiply;
        private Button btnSquare;
        private Button btnInverse;
        private Button btnSquareRoot;
        private Button btnDivide;
        private TextBox textMainDisplay;
        private TextBox textFormulaDisplay;
    }
}
