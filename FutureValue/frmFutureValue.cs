namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);


            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }
            return futureValue;
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }



        private void frmFutureValue_DoubleClick_1(object sender, EventArgs e)
        {
            // Exercise 6-2 code
            txtMonthlyInvestment.Text = "";
            txtYears.Text = "";
            txtInterestRate.Text = "";
            txtFutureValue.Text = "";
        }

        private void frmFutureValue_Load(object sender, EventArgs e)
        {

        }

        private void txtInterestRate_DoubleClick(object sender, EventArgs e)
        {
            // Exercise 6-2 code
            txtInterestRate.Text = "12";
        }
    }
}