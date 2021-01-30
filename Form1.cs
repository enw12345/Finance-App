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

        private void Intrest_Calculate_Button_Click(object sender, EventArgs e)
        {
            bool convertRateToMonths = false;
            bool convertTimeToMonths = false;

            if (InvestInterestYearsMonths.Text.Equals("Months"))
            {
                convertRateToMonths = true;
            }

            invest = new Invest(presentValue, payment, r, t, convertRateToMonths, convertTimeToMonths);

            Calculation_label.Text = "Your balance will be " + invest.FutureValue(presentValue, payment, r, t).ToString("c2");
        }

        private void Time_textBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(Time_textBox.Text, out t);
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

            borrow = new Borrow(loanAmount, rate, n, convertRateToMonths, convertTimeToMonths);

            Borrow_Calculation_label.Text = "You will pay: \n" + borrow.AmortizedLoanPayment(loanAmount, rate, n).ToString("C2");
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

        private void HowMuchButton_Click(object sender, EventArgs e)
        {
            bool convertRateToMonths = false;
            bool convertTimeToMonths = false;

            if (InvestInterestYearsMonths.Text.Equals("Per Month"))
            {
                convertRateToMonths = true;
            }

            invest = new Invest(desiredAmount, presentValue, payment, r, t, convertRateToMonths, convertTimeToMonths);

            HowMuchLabel.Text = "You need to save " + invest.HowMuchToSave(desiredAmount, presentValue, r, t).ToString("c2") + (convertTimeToMonths ? " a month.": " a year.");
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
