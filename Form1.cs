using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_App
{
    public partial class Form1 : Form
    {
        double p;
        float r;
        int t;

        double a;
        float rate;
        int n;

        public Invest invest;
        public Borrow borrow;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Principal_textBox.Text, out p);
        }

        private void Intrest_Calculate_Button_Click(object sender, EventArgs e)
        {

            invest = new Invest(p, r, t, InvestConvertToMonthsRate.Checked, InvestConvertToMonthsTime.Checked);

            if(InvestFormulaSelect.Text.Equals("Simple Interest"))
            {
                Calculation_label.Text = "Your interest will be: \n" + invest.SimpleInterest(p, r, t).ToString("C2");
            }
            else if(InvestFormulaSelect.Text.Equals("Compound Interest"))
            {
                Calculation_label.Text = "Your interest will be: \n" + invest.CompoundInterest(p, r, t).ToString("C2");
            }
            else if(InvestFormulaSelect.Text.Equals("Simple Interest Future Value"))
            {
                Calculation_label.Text = "Your ending balance will be: \n" + invest.FutureValueWithSimpleInterest(p, r, t).ToString("C2");
            }
            else if(InvestFormulaSelect.Text.Equals("Compound Interest Future Value"))
            {
                Calculation_label.Text = "Your ending balance will be: \n" + invest.FutureValueWithCompoundInterest(p, r, t).ToString("C2");
            }
            else if(InvestFormulaSelect.Text.Equals("Future Value Of Annuity"))
            {
                Calculation_label.Text = "Your ending balance wiill be: \n" + invest.FutureValueOfAnnuity(p, r, t).ToString("C2");
            }
            else
            {
                Calculation_label.Text = "Please select a formula.";
            }
        }

        private void Rate_textBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(Rate_textBox.Text, out r);
        }

        private void Time_textBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(Time_textBox.Text, out t);
        }

        private void Calculation_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(LoanAmount_textBox.Text, out a);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            float.TryParse(AnnualRate_textBox.Text, out rate);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(n_textBox.Text, out n);
        }

        private void Borrow_Calculate_button_Click(object sender, EventArgs e)
        {
            borrow = new Borrow(a, rate, n, BorrowConvertToMonthsRate.Checked, BorrowConvertToMonthsTime.Checked);
            if(BorrowFormulaSelect.Text.Equals("Amortized Loan Payment"))
            {
                Borrow_Calculation_label.Text = "You will pay: \n" + borrow.AmortizedLoanPayment(a, rate, n).ToString("C2");
            }
            
        }

        private void InvestYearsOrMonths_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void BorrowYearsOrMonths_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Time_label_Click(object sender, EventArgs e)
        {

        }

        private void Borrow_Time_label_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InvestFormulaSelect.Text.Equals("Future Value Of Annuity"))
            {
                Principal_label.Text = "Periodic Payment";
            }
            else
            {
                Principal_label.Text = "Principal Amount";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Principal_label_Click(object sender, EventArgs e)
        {

        }

        private void InvestConvertToMonthsTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InvestConvertToMonthsRate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rate_label_Click(object sender, EventArgs e)
        {

        }
    }
}
