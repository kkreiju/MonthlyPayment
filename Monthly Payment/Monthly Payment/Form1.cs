using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monthly_Payment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double MonthlyPayment(double loanamount, int interestrate)
        {
            //input
            double monthlypayment = 0;
            int months;
            double rate;
            int firstinterestrate = Convert.ToInt16(FirstInterestRateComboBox.Text);
            int lastinterestrate = Convert.ToInt16(LastInterestRateComboBox.Text);

            //process
            months = Convert.ToInt16(NumberOfYearsComboBox.Text) * 12;
            rate = (interestrate / 12.00) * (1 / 100.00);
            monthlypayment = loanamount * ((rate * Math.Pow(1 + rate, months)) / (Math.Pow(1 + rate, months) - 1));

            //output
            return monthlypayment;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //input
            bool verifier = false; //to proceed monthly payment method
            double loanamount;

            //process
            if (!LoanAmountTextbox.Text.Equals(string.Empty))
                verifier = true;
            else
                verifier = false;
                loanamount = Convert.ToDouble(LoanAmountTextbox.Text);

            if (Convert.ToInt16(FirstInterestRateComboBox.Text) <= Convert.ToInt16(LastInterestRateComboBox.Text))
                verifier = true;
            else
                verifier = false;

            if(!OutputListBox.Text.Equals(string.Empty))
                OutputListBox.Text = string.Empty;

            if (verifier)
            {
                for (int i = Convert.ToInt16(FirstInterestRateComboBox.Text); i <= Convert.ToInt16(LastInterestRateComboBox.Text); i++)
                {
                    OutputListBox.Items.Add(i + ".0%" + "                                     " + MonthlyPayment(loanamount, i).ToString("F2", CultureInfo.CurrentCulture));
                }
            }
        }
    }
}
