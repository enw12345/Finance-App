﻿namespace Finance_App
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
            this.InvestInterestYearsMonths = new System.Windows.Forms.ComboBox();
            this.InvestPeriodYearsMonths = new System.Windows.Forms.ComboBox();
            this.BorrowInterestYearsMonths = new System.Windows.Forms.ComboBox();
            this.BorrowPeriodYearsMonths = new System.Windows.Forms.ComboBox();
            this.PresentValueLabel = new System.Windows.Forms.Label();
            this.PresentValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Principal_textBox
            // 
            this.Principal_textBox.Location = new System.Drawing.Point(115, 88);
            this.Principal_textBox.Name = "Principal_textBox";
            this.Principal_textBox.Size = new System.Drawing.Size(100, 20);
            this.Principal_textBox.TabIndex = 0;
            this.Principal_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            this.Principal_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_pressed);
            this.Principal_textBox.Leave += new System.EventHandler(this.Principal_textBox_Leave);
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
            this.LoanAmount_textBox.Location = new System.Drawing.Point(602, 62);
            this.LoanAmount_textBox.Name = "LoanAmount_textBox";
            this.LoanAmount_textBox.Size = new System.Drawing.Size(100, 20);
            this.LoanAmount_textBox.TabIndex = 3;
            this.LoanAmount_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            this.LoanAmount_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_pressed);
            this.LoanAmount_textBox.Leave += new System.EventHandler(this.LoanAmount_textBox_Leave);
            // 
            // Principal_label
            // 
            this.Principal_label.AutoSize = true;
            this.Principal_label.Location = new System.Drawing.Point(12, 95);
            this.Principal_label.Name = "Principal_label";
            this.Principal_label.Size = new System.Drawing.Size(89, 13);
            this.Principal_label.TabIndex = 4;
            this.Principal_label.Text = "Periodic Payment";
            this.Principal_label.Click += new System.EventHandler(this.Principal_label_Click);
            // 
            // Rate_label
            // 
            this.Rate_label.AutoSize = true;
            this.Rate_label.Location = new System.Drawing.Point(12, 124);
            this.Rate_label.Name = "Rate_label";
            this.Rate_label.Size = new System.Drawing.Size(68, 13);
            this.Rate_label.TabIndex = 5;
            this.Rate_label.Text = "Interest Rate";
            this.Rate_label.Click += new System.EventHandler(this.Rate_label_Click);
            // 
            // Rate_textBox
            // 
            this.Rate_textBox.Location = new System.Drawing.Point(115, 121);
            this.Rate_textBox.Name = "Rate_textBox";
            this.Rate_textBox.Size = new System.Drawing.Size(100, 20);
            this.Rate_textBox.TabIndex = 6;
            this.Rate_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            this.Rate_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_pressed);
            this.Rate_textBox.Leave += new System.EventHandler(this.Rate_textBox_Leave);
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Location = new System.Drawing.Point(12, 150);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(37, 13);
            this.Time_label.TabIndex = 7;
            this.Time_label.Text = "Period";
            this.Time_label.Click += new System.EventHandler(this.Time_label_Click);
            // 
            // Time_textBox
            // 
            this.Time_textBox.Location = new System.Drawing.Point(115, 150);
            this.Time_textBox.Name = "Time_textBox";
            this.Time_textBox.Size = new System.Drawing.Size(100, 20);
            this.Time_textBox.TabIndex = 8;
            this.Time_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            this.Time_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_pressed);
            this.Time_textBox.Leave += new System.EventHandler(this.Time_textBox_Leave);
            // 
            // Intrest_Calculate_Button
            // 
            this.Intrest_Calculate_Button.Location = new System.Drawing.Point(61, 189);
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
            this.Calculation_label.Location = new System.Drawing.Point(58, 234);
            this.Calculation_label.Name = "Calculation_label";
            this.Calculation_label.Size = new System.Drawing.Size(59, 13);
            this.Calculation_label.TabIndex = 10;
            this.Calculation_label.Text = "Calculation";
            this.Calculation_label.Click += new System.EventHandler(this.Calculation_label_Click);
            // 
            // LoanAmount_label
            // 
            this.LoanAmount_label.AutoSize = true;
            this.LoanAmount_label.Location = new System.Drawing.Point(498, 65);
            this.LoanAmount_label.Name = "LoanAmount_label";
            this.LoanAmount_label.Size = new System.Drawing.Size(70, 13);
            this.LoanAmount_label.TabIndex = 11;
            this.LoanAmount_label.Text = "Loan Amount";
            this.LoanAmount_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AnnualRate_textBox
            // 
            this.AnnualRate_textBox.Location = new System.Drawing.Point(602, 94);
            this.AnnualRate_textBox.Name = "AnnualRate_textBox";
            this.AnnualRate_textBox.Size = new System.Drawing.Size(100, 20);
            this.AnnualRate_textBox.TabIndex = 12;
            this.AnnualRate_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            this.AnnualRate_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_pressed);
            this.AnnualRate_textBox.Leave += new System.EventHandler(this.AnnualRate_textBox_Leave);
            // 
            // n_textBox
            // 
            this.n_textBox.Location = new System.Drawing.Point(602, 124);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(100, 20);
            this.n_textBox.TabIndex = 13;
            this.n_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            this.n_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_pressed);
            this.n_textBox.Leave += new System.EventHandler(this.n_textBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Interest Rate";
            // 
            // Borrow_Time_label
            // 
            this.Borrow_Time_label.AutoSize = true;
            this.Borrow_Time_label.Location = new System.Drawing.Point(498, 127);
            this.Borrow_Time_label.Name = "Borrow_Time_label";
            this.Borrow_Time_label.Size = new System.Drawing.Size(37, 13);
            this.Borrow_Time_label.TabIndex = 15;
            this.Borrow_Time_label.Text = "Period";
            this.Borrow_Time_label.Click += new System.EventHandler(this.Borrow_Time_label_Click);
            // 
            // Borrow_Calculate_button
            // 
            this.Borrow_Calculate_button.Location = new System.Drawing.Point(573, 189);
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
            this.Borrow_Calculation_label.Location = new System.Drawing.Point(579, 234);
            this.Borrow_Calculation_label.Name = "Borrow_Calculation_label";
            this.Borrow_Calculation_label.Size = new System.Drawing.Size(59, 13);
            this.Borrow_Calculation_label.TabIndex = 17;
            this.Borrow_Calculation_label.Text = "Calculation";
            // 
            // InvestInterestYearsMonths
            // 
            this.InvestInterestYearsMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InvestInterestYearsMonths.FormattingEnabled = true;
            this.InvestInterestYearsMonths.Items.AddRange(new object[] {
            "Years",
            "Months"});
            this.InvestInterestYearsMonths.Location = new System.Drawing.Point(221, 121);
            this.InvestInterestYearsMonths.Name = "InvestInterestYearsMonths";
            this.InvestInterestYearsMonths.Size = new System.Drawing.Size(121, 21);
            this.InvestInterestYearsMonths.TabIndex = 26;
            this.InvestInterestYearsMonths.SelectedIndexChanged += new System.EventHandler(this.InvestInterestYearsMonths_SelectedIndexChanged);
            // 
            // InvestPeriodYearsMonths
            // 
            this.InvestPeriodYearsMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InvestPeriodYearsMonths.FormattingEnabled = true;
            this.InvestPeriodYearsMonths.Items.AddRange(new object[] {
            "Years",
            "Months"});
            this.InvestPeriodYearsMonths.Location = new System.Drawing.Point(221, 150);
            this.InvestPeriodYearsMonths.Name = "InvestPeriodYearsMonths";
            this.InvestPeriodYearsMonths.Size = new System.Drawing.Size(121, 21);
            this.InvestPeriodYearsMonths.TabIndex = 27;
            // 
            // BorrowInterestYearsMonths
            // 
            this.BorrowInterestYearsMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorrowInterestYearsMonths.FormattingEnabled = true;
            this.BorrowInterestYearsMonths.Items.AddRange(new object[] {
            "Years",
            "Months"});
            this.BorrowInterestYearsMonths.Location = new System.Drawing.Point(708, 93);
            this.BorrowInterestYearsMonths.Name = "BorrowInterestYearsMonths";
            this.BorrowInterestYearsMonths.Size = new System.Drawing.Size(121, 21);
            this.BorrowInterestYearsMonths.TabIndex = 28;
            // 
            // BorrowPeriodYearsMonths
            // 
            this.BorrowPeriodYearsMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorrowPeriodYearsMonths.FormattingEnabled = true;
            this.BorrowPeriodYearsMonths.Items.AddRange(new object[] {
            "Years",
            "Months"});
            this.BorrowPeriodYearsMonths.Location = new System.Drawing.Point(708, 124);
            this.BorrowPeriodYearsMonths.Name = "BorrowPeriodYearsMonths";
            this.BorrowPeriodYearsMonths.Size = new System.Drawing.Size(121, 21);
            this.BorrowPeriodYearsMonths.TabIndex = 29;
            // 
            // PresentValueLabel
            // 
            this.PresentValueLabel.AutoSize = true;
            this.PresentValueLabel.Location = new System.Drawing.Point(12, 65);
            this.PresentValueLabel.Name = "PresentValueLabel";
            this.PresentValueLabel.Size = new System.Drawing.Size(73, 13);
            this.PresentValueLabel.TabIndex = 30;
            this.PresentValueLabel.Text = "Present Value";
            // 
            // PresentValueTextBox
            // 
            this.PresentValueTextBox.Location = new System.Drawing.Point(115, 58);
            this.PresentValueTextBox.Name = "PresentValueTextBox";
            this.PresentValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.PresentValueTextBox.TabIndex = 31;
            this.PresentValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            this.PresentValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_pressed);
            this.PresentValueTextBox.Leave += new System.EventHandler(this.PresentValueTextBox_Leave);
            this.PresentValueTextBox.MouseHover += new System.EventHandler(this.PresentValueTextBox_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 446);
            this.Controls.Add(this.PresentValueTextBox);
            this.Controls.Add(this.PresentValueLabel);
            this.Controls.Add(this.BorrowPeriodYearsMonths);
            this.Controls.Add(this.BorrowInterestYearsMonths);
            this.Controls.Add(this.InvestPeriodYearsMonths);
            this.Controls.Add(this.InvestInterestYearsMonths);
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
        private System.Windows.Forms.ComboBox InvestInterestYearsMonths;
        private System.Windows.Forms.ComboBox InvestPeriodYearsMonths;
        private System.Windows.Forms.ComboBox BorrowInterestYearsMonths;
        private System.Windows.Forms.ComboBox BorrowPeriodYearsMonths;
        private System.Windows.Forms.Label PresentValueLabel;
        private System.Windows.Forms.TextBox PresentValueTextBox;
    }
}

