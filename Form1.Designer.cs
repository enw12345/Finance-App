namespace Finance_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Principal_textBox = new System.Windows.Forms.TextBox();
            this.Invest_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoanAmount_textBox = new System.Windows.Forms.TextBox();
            this.Principal_label = new System.Windows.Forms.Label();
            this.Rate_label = new System.Windows.Forms.Label();
            this.Rate_textBox = new System.Windows.Forms.TextBox();
            this.Time_label = new System.Windows.Forms.Label();
            this.Time_textBox = new System.Windows.Forms.TextBox();
            this.Intrest_Calculate_Button = new System.Windows.Forms.Button();
            this.Calculation_label = new System.Windows.Forms.Label();
            this.LoanAmount_label = new System.Windows.Forms.Label();
            this.AnnualRate_textBox = new System.Windows.Forms.TextBox();
            this.n_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Borrow_Time_label = new System.Windows.Forms.Label();
            this.Borrow_Calculate_button = new System.Windows.Forms.Button();
            this.Borrow_Calculation_label = new System.Windows.Forms.Label();
            this.InvestFormulaSelect = new System.Windows.Forms.ComboBox();
            this.BorrowFormulaSelect = new System.Windows.Forms.ComboBox();
            this.BorrowSelectFormulaLabel = new System.Windows.Forms.Label();
            this.InvestSelectFormula = new System.Windows.Forms.Label();
            this.InvestConvertToMonthsTime = new System.Windows.Forms.CheckBox();
            this.InvestConvertToMonthsRate = new System.Windows.Forms.CheckBox();
            this.BorrowConvertToMonthsTime = new System.Windows.Forms.CheckBox();
            this.BorrowConvertToMonthsRate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Principal_textBox
            // 
            this.Principal_textBox.Location = new System.Drawing.Point(106, 100);
            this.Principal_textBox.Name = "Principal_textBox";
            this.Principal_textBox.Size = new System.Drawing.Size(100, 20);
            this.Principal_textBox.TabIndex = 0;
            this.Principal_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Invest_label
            // 
            this.Invest_label.AutoSize = true;
            this.Invest_label.Location = new System.Drawing.Point(65, 40);
            this.Invest_label.Name = "Invest_label";
            this.Invest_label.Size = new System.Drawing.Size(36, 13);
            this.Invest_label.TabIndex = 1;
            this.Invest_label.Text = "Invest";
            this.Invest_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Borrow";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoanAmount_textBox
            // 
            this.LoanAmount_textBox.Location = new System.Drawing.Point(605, 99);
            this.LoanAmount_textBox.Name = "LoanAmount_textBox";
            this.LoanAmount_textBox.Size = new System.Drawing.Size(100, 20);
            this.LoanAmount_textBox.TabIndex = 3;
            this.LoanAmount_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Principal_label
            // 
            this.Principal_label.AutoSize = true;
            this.Principal_label.Location = new System.Drawing.Point(3, 107);
            this.Principal_label.Name = "Principal_label";
            this.Principal_label.Size = new System.Drawing.Size(86, 13);
            this.Principal_label.TabIndex = 4;
            this.Principal_label.Text = "Principal Amount";
            this.Principal_label.Click += new System.EventHandler(this.Principal_label_Click);
            // 
            // Rate_label
            // 
            this.Rate_label.AutoSize = true;
            this.Rate_label.Location = new System.Drawing.Point(3, 136);
            this.Rate_label.Name = "Rate_label";
            this.Rate_label.Size = new System.Drawing.Size(68, 13);
            this.Rate_label.TabIndex = 5;
            this.Rate_label.Text = "Interest Rate";
            this.Rate_label.Click += new System.EventHandler(this.Rate_label_Click);
            // 
            // Rate_textBox
            // 
            this.Rate_textBox.Location = new System.Drawing.Point(106, 133);
            this.Rate_textBox.Name = "Rate_textBox";
            this.Rate_textBox.Size = new System.Drawing.Size(100, 20);
            this.Rate_textBox.TabIndex = 6;
            this.Rate_textBox.TextChanged += new System.EventHandler(this.Rate_textBox_TextChanged);
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Location = new System.Drawing.Point(3, 162);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(37, 13);
            this.Time_label.TabIndex = 7;
            this.Time_label.Text = "Period";
            this.Time_label.Click += new System.EventHandler(this.Time_label_Click);
            // 
            // Time_textBox
            // 
            this.Time_textBox.Location = new System.Drawing.Point(106, 162);
            this.Time_textBox.Name = "Time_textBox";
            this.Time_textBox.Size = new System.Drawing.Size(100, 20);
            this.Time_textBox.TabIndex = 8;
            this.Time_textBox.TextChanged += new System.EventHandler(this.Time_textBox_TextChanged);
            // 
            // Intrest_Calculate_Button
            // 
            this.Intrest_Calculate_Button.Location = new System.Drawing.Point(68, 204);
            this.Intrest_Calculate_Button.Name = "Intrest_Calculate_Button";
            this.Intrest_Calculate_Button.Size = new System.Drawing.Size(75, 23);
            this.Intrest_Calculate_Button.TabIndex = 9;
            this.Intrest_Calculate_Button.Text = "Calculate";
            this.Intrest_Calculate_Button.UseVisualStyleBackColor = true;
            this.Intrest_Calculate_Button.Click += new System.EventHandler(this.Intrest_Calculate_Button_Click);
            // 
            // Calculation_label
            // 
            this.Calculation_label.AutoSize = true;
            this.Calculation_label.Location = new System.Drawing.Point(65, 262);
            this.Calculation_label.Name = "Calculation_label";
            this.Calculation_label.Size = new System.Drawing.Size(59, 13);
            this.Calculation_label.TabIndex = 10;
            this.Calculation_label.Text = "Calculation";
            this.Calculation_label.Click += new System.EventHandler(this.Calculation_label_Click);
            // 
            // LoanAmount_label
            // 
            this.LoanAmount_label.AutoSize = true;
            this.LoanAmount_label.Location = new System.Drawing.Point(501, 102);
            this.LoanAmount_label.Name = "LoanAmount_label";
            this.LoanAmount_label.Size = new System.Drawing.Size(70, 13);
            this.LoanAmount_label.TabIndex = 11;
            this.LoanAmount_label.Text = "Loan Amount";
            this.LoanAmount_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AnnualRate_textBox
            // 
            this.AnnualRate_textBox.Location = new System.Drawing.Point(605, 131);
            this.AnnualRate_textBox.Name = "AnnualRate_textBox";
            this.AnnualRate_textBox.Size = new System.Drawing.Size(100, 20);
            this.AnnualRate_textBox.TabIndex = 12;
            this.AnnualRate_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // n_textBox
            // 
            this.n_textBox.Location = new System.Drawing.Point(605, 161);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(100, 20);
            this.n_textBox.TabIndex = 13;
            this.n_textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Interest Rate";
            // 
            // Borrow_Time_label
            // 
            this.Borrow_Time_label.AutoSize = true;
            this.Borrow_Time_label.Location = new System.Drawing.Point(501, 164);
            this.Borrow_Time_label.Name = "Borrow_Time_label";
            this.Borrow_Time_label.Size = new System.Drawing.Size(37, 13);
            this.Borrow_Time_label.TabIndex = 15;
            this.Borrow_Time_label.Text = "Period";
            this.Borrow_Time_label.Click += new System.EventHandler(this.Borrow_Time_label_Click);
            // 
            // Borrow_Calculate_button
            // 
            this.Borrow_Calculate_button.Location = new System.Drawing.Point(582, 204);
            this.Borrow_Calculate_button.Name = "Borrow_Calculate_button";
            this.Borrow_Calculate_button.Size = new System.Drawing.Size(75, 23);
            this.Borrow_Calculate_button.TabIndex = 16;
            this.Borrow_Calculate_button.Text = "Calculate";
            this.Borrow_Calculate_button.UseVisualStyleBackColor = true;
            this.Borrow_Calculate_button.Click += new System.EventHandler(this.Borrow_Calculate_button_Click);
            // 
            // Borrow_Calculation_label
            // 
            this.Borrow_Calculation_label.AutoSize = true;
            this.Borrow_Calculation_label.Location = new System.Drawing.Point(579, 262);
            this.Borrow_Calculation_label.Name = "Borrow_Calculation_label";
            this.Borrow_Calculation_label.Size = new System.Drawing.Size(59, 13);
            this.Borrow_Calculation_label.TabIndex = 17;
            this.Borrow_Calculation_label.Text = "Calculation";
            // 
            // InvestFormulaSelect
            // 
            this.InvestFormulaSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InvestFormulaSelect.FormattingEnabled = true;
            this.InvestFormulaSelect.Items.AddRange(new object[] {
            "Compound Interest",
            "Compound Interest Future Value",
            "Future Value Of Annuity",
            "Simple Interest",
            "Simple Interest Future Value"});
            this.InvestFormulaSelect.Location = new System.Drawing.Point(106, 70);
            this.InvestFormulaSelect.Name = "InvestFormulaSelect";
            this.InvestFormulaSelect.Size = new System.Drawing.Size(155, 21);
            this.InvestFormulaSelect.Sorted = true;
            this.InvestFormulaSelect.TabIndex = 22;
            this.InvestFormulaSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BorrowFormulaSelect
            // 
            this.BorrowFormulaSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorrowFormulaSelect.FormattingEnabled = true;
            this.BorrowFormulaSelect.Items.AddRange(new object[] {
            "Amortized Loan Payment"});
            this.BorrowFormulaSelect.Location = new System.Drawing.Point(605, 65);
            this.BorrowFormulaSelect.Name = "BorrowFormulaSelect";
            this.BorrowFormulaSelect.Size = new System.Drawing.Size(155, 21);
            this.BorrowFormulaSelect.TabIndex = 23;
            // 
            // BorrowSelectFormulaLabel
            // 
            this.BorrowSelectFormulaLabel.AutoSize = true;
            this.BorrowSelectFormulaLabel.Location = new System.Drawing.Point(499, 73);
            this.BorrowSelectFormulaLabel.Name = "BorrowSelectFormulaLabel";
            this.BorrowSelectFormulaLabel.Size = new System.Drawing.Size(77, 13);
            this.BorrowSelectFormulaLabel.TabIndex = 24;
            this.BorrowSelectFormulaLabel.Text = "Select Formula";
            // 
            // InvestSelectFormula
            // 
            this.InvestSelectFormula.AutoSize = true;
            this.InvestSelectFormula.Location = new System.Drawing.Point(3, 73);
            this.InvestSelectFormula.Name = "InvestSelectFormula";
            this.InvestSelectFormula.Size = new System.Drawing.Size(77, 13);
            this.InvestSelectFormula.TabIndex = 25;
            this.InvestSelectFormula.Text = "Select Formula";
            // 
            // InvestConvertToMonthsTime
            // 
            this.InvestConvertToMonthsTime.AutoSize = true;
            this.InvestConvertToMonthsTime.Location = new System.Drawing.Point(212, 165);
            this.InvestConvertToMonthsTime.Name = "InvestConvertToMonthsTime";
            this.InvestConvertToMonthsTime.Size = new System.Drawing.Size(114, 17);
            this.InvestConvertToMonthsTime.TabIndex = 26;
            this.InvestConvertToMonthsTime.Text = "Convert to monthly";
            this.InvestConvertToMonthsTime.UseVisualStyleBackColor = true;
            this.InvestConvertToMonthsTime.CheckedChanged += new System.EventHandler(this.InvestConvertToMonthsTime_CheckedChanged);
            // 
            // InvestConvertToMonthsRate
            // 
            this.InvestConvertToMonthsRate.AutoSize = true;
            this.InvestConvertToMonthsRate.Location = new System.Drawing.Point(212, 136);
            this.InvestConvertToMonthsRate.Name = "InvestConvertToMonthsRate";
            this.InvestConvertToMonthsRate.Size = new System.Drawing.Size(114, 17);
            this.InvestConvertToMonthsRate.TabIndex = 27;
            this.InvestConvertToMonthsRate.Text = "Convert to monthly";
            this.InvestConvertToMonthsRate.UseVisualStyleBackColor = true;
            this.InvestConvertToMonthsRate.CheckedChanged += new System.EventHandler(this.InvestConvertToMonthsRate_CheckedChanged);
            // 
            // BorrowConvertToMonthsTime
            // 
            this.BorrowConvertToMonthsTime.AutoSize = true;
            this.BorrowConvertToMonthsTime.Location = new System.Drawing.Point(711, 164);
            this.BorrowConvertToMonthsTime.Name = "BorrowConvertToMonthsTime";
            this.BorrowConvertToMonthsTime.Size = new System.Drawing.Size(114, 17);
            this.BorrowConvertToMonthsTime.TabIndex = 28;
            this.BorrowConvertToMonthsTime.Text = "Convert to monthly";
            this.BorrowConvertToMonthsTime.UseVisualStyleBackColor = true;
            // 
            // BorrowConvertToMonthsRate
            // 
            this.BorrowConvertToMonthsRate.AutoSize = true;
            this.BorrowConvertToMonthsRate.Location = new System.Drawing.Point(712, 135);
            this.BorrowConvertToMonthsRate.Name = "BorrowConvertToMonthsRate";
            this.BorrowConvertToMonthsRate.Size = new System.Drawing.Size(114, 17);
            this.BorrowConvertToMonthsRate.TabIndex = 29;
            this.BorrowConvertToMonthsRate.Text = "Convert to monthly";
            this.BorrowConvertToMonthsRate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 446);
            this.Controls.Add(this.BorrowConvertToMonthsRate);
            this.Controls.Add(this.BorrowConvertToMonthsTime);
            this.Controls.Add(this.InvestConvertToMonthsRate);
            this.Controls.Add(this.InvestConvertToMonthsTime);
            this.Controls.Add(this.InvestSelectFormula);
            this.Controls.Add(this.BorrowSelectFormulaLabel);
            this.Controls.Add(this.BorrowFormulaSelect);
            this.Controls.Add(this.InvestFormulaSelect);
            this.Controls.Add(this.Borrow_Calculation_label);
            this.Controls.Add(this.Borrow_Calculate_button);
            this.Controls.Add(this.Borrow_Time_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n_textBox);
            this.Controls.Add(this.AnnualRate_textBox);
            this.Controls.Add(this.LoanAmount_label);
            this.Controls.Add(this.Calculation_label);
            this.Controls.Add(this.Intrest_Calculate_Button);
            this.Controls.Add(this.Time_textBox);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.Rate_textBox);
            this.Controls.Add(this.Rate_label);
            this.Controls.Add(this.Principal_label);
            this.Controls.Add(this.LoanAmount_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Invest_label);
            this.Controls.Add(this.Principal_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Principal_textBox;
        private System.Windows.Forms.Label Invest_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoanAmount_textBox;
        private System.Windows.Forms.Label Principal_label;
        private System.Windows.Forms.Label Rate_label;
        private System.Windows.Forms.TextBox Rate_textBox;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.TextBox Time_textBox;
        private System.Windows.Forms.Button Intrest_Calculate_Button;
        private System.Windows.Forms.Label Calculation_label;
        private System.Windows.Forms.Label LoanAmount_label;
        private System.Windows.Forms.TextBox AnnualRate_textBox;
        private System.Windows.Forms.TextBox n_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Borrow_Time_label;
        private System.Windows.Forms.Button Borrow_Calculate_button;
        private System.Windows.Forms.Label Borrow_Calculation_label;
        private System.Windows.Forms.ComboBox InvestFormulaSelect;
        private System.Windows.Forms.ComboBox BorrowFormulaSelect;
        private System.Windows.Forms.Label BorrowSelectFormulaLabel;
        private System.Windows.Forms.Label InvestSelectFormula;
        private System.Windows.Forms.CheckBox InvestConvertToMonthsTime;
        private System.Windows.Forms.CheckBox InvestConvertToMonthsRate;
        private System.Windows.Forms.CheckBox BorrowConvertToMonthsTime;
        private System.Windows.Forms.CheckBox BorrowConvertToMonthsRate;
    }
}

