using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Finance_App
{
    public partial class Form1 : Form
    {
        double presentValue;
        double payment;
        double desiredAmount;
        float r;
        int t;

        double loanAmount;
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

        private void Intrest_Calculate_Button_Click(object sender, EventArgs e)
        {
            bool convertRateToMonths = false;
            bool convertTimeToMonths = false;

            if (InvestInterestYearsMonths.Text.Equals("Months"))
            {
                convertRateToMonths = true;
            }
            if (InvestPeriodYearsMonths.Text.Equals("Months"))
            {
                convertTimeToMonths = true;
            }

            invest = new Invest(presentValue, payment, r, t, convertRateToMonths, convertTimeToMonths);

            Calculation_label.Text = "Your balance will be " + invest.FutureValue(presentValue, payment, r, t).ToString("c2");
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(n_textBox.Text, out n);
        }

        private void Borrow_Calculate_button_Click(object sender, EventArgs e)
        {
            bool convertRateToMonths = false;
            bool convertTimeToMonths = false;

            if (BorrowInterestYearsMonths.Text.Equals("Months"))
            {
                convertRateToMonths = true;
            }
            if (BorrowPeriodYearsMonths.Text.Equals("Months"))
            {
                convertTimeToMonths = true;
            }

            borrow = new Borrow(loanAmount, rate, n, convertRateToMonths, convertTimeToMonths);

            Borrow_Calculation_label.Text = "You will pay: \n" + borrow.AmortizedLoanPayment(loanAmount, rate, n).ToString("C2");
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

        private void InvestInterestYearsMonths_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Enter(object sender, KeyEventArgs e)
        {

        }

        private void enter_pressed(object sender, KeyPressEventArgs e)
        {

        }

        private void PresentValueTextBox_Leave(object sender, EventArgs e)
        {
            double temp;
            if (double.TryParse(PresentValueTextBox.Text, out temp))
            {
                presentValue = temp;
            }
            PresentValueTextBox.Text = presentValue.ToString("c2");
        }

        private void Principal_textBox_Leave(object sender, EventArgs e)
        {
            double temp;
            if (double.TryParse(Principal_textBox.Text, out temp))
            {
                payment = temp;
            }

            Principal_textBox.Text = payment.ToString("c2");
        }

        private void Rate_textBox_Leave(object sender, EventArgs e)
        {
            float temp;
            if (float.TryParse(Rate_textBox.Text, out temp))
            {
                r = temp;
            }
            Rate_textBox.Text = r.ToString() + "%";
        }

        private void LoanAmount_textBox_Leave(object sender, EventArgs e)
        {
            double temp;
            if (double.TryParse(LoanAmount_textBox.Text, out temp))
            {
                loanAmount = temp;
            }
            LoanAmount_textBox.Text = loanAmount.ToString("C2");
        }

        private void AnnualRate_textBox_Leave(object sender, EventArgs e)
        {
            float temp;
            if (float.TryParse(AnnualRate_textBox.Text, out temp))
            {
                rate = temp;
            }
            AnnualRate_textBox.Text = rate.ToString() + "%";
        }

        private void Time_textBox_Leave(object sender, EventArgs e)
        {
            int.TryParse(Time_textBox.Text, out t);
        }

        private void n_textBox_Leave(object sender, EventArgs e)
        {
            int.TryParse(n_textBox.Text, out n);
        }

        private void PresentValueTextBox_MouseHover(object sender, EventArgs e)
        {

        }

        private void PresentValueTextBox_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void PresentValueTextBox_Enter(object sender, EventArgs e)
        {
            PresentValueTextBox.Text = presentValue.ToString();
        }

        private void Principal_textBox_Enter(object sender, EventArgs e)
        {
            Principal_textBox.Text = payment.ToString();
        }

        private void Rate_textBox_Enter(object sender, EventArgs e)
        {
            Rate_textBox.Text = r.ToString();
        }

        private void LoanAmount_textBox_Enter(object sender, EventArgs e)
        {
            LoanAmount_textBox.Text = loanAmount.ToString();
        }

        private void AnnualRate_textBox_Enter(object sender, EventArgs e)
        {
            AnnualRate_textBox.Text = rate.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoanAmount_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnnualRate_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void n_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BorrowInterestYearsMonths_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BorrowPeriodYearsMonths_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Borrow_Calculation_label_Click(object sender, EventArgs e)
        {

        }

        private void PresentValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void HowMuchButton_Click(object sender, EventArgs e)
        {
            bool convertRateToMonths = false;
            bool convertTimeToMonths = false;

            if (InvestInterestYearsMonths.Text.Equals("Months"))
            {
                convertRateToMonths = true;
            }
            if (InvestPeriodYearsMonths.Text.Equals("Months"))
            {
                convertTimeToMonths = true;
            }

            invest = new Invest(desiredAmount, presentValue, payment, r, t, convertRateToMonths, convertTimeToMonths);

            HowMuchLabel.Text = "You need to save " + invest.GetPeriod(desiredAmount, presentValue, r, t).ToString("c2") + (convertTimeToMonths ? " a month.": " a year.");
        }

        private void DesiredAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesiredAmountTextBox_Leave(object sender, EventArgs e)
        {
            double temp;
            if (double.TryParse(DesiredAmountTextBox.Text, out temp))
            {
                desiredAmount = temp;
            }

            DesiredAmountTextBox.Text = desiredAmount.ToString("c2");
        }
    }
}
