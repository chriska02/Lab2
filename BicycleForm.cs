namespace Lab2
{
    public partial class BicycleForm : Form
    {
        private readonly LoginForm loginForm;
        private readonly ChooseForm chooseForm;

        private bool isNavigating = false;

        public BicycleForm(LoginForm login, ChooseForm choose)
        {
            InitializeComponent();
            loginForm = login;
            chooseForm = choose;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();

            if (txtStart.Text.Trim() == "" || txtEnd.Text.Trim() == "")
            {
                MessageBox.Show("Please enter both the start hour and the end hour.",
                    "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int startHour;
            int endHour;

            if (!int.TryParse(txtStart.Text.Trim(), out startHour))
            {
                MessageBox.Show("Start hour must be a whole number (no letters, no decimals).",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStart.Focus();
                return;
            }

            if (!int.TryParse(txtEnd.Text.Trim(), out endHour))
            {
                MessageBox.Show("End hour must be a whole number (no letters, no decimals).",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnd.Focus();
                return;
            }

            if (startHour < 0 || startHour > 23)
            {
                MessageBox.Show("Start hour must be between 0 and 23.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStart.Focus();
                return;
            }

            if (endHour < 1 || endHour > 24)
            {
                MessageBox.Show("End hour must be between 1 and 24.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnd.Focus();
                return;
            }

            if (startHour >= endHour)
            {
                MessageBox.Show("Start hour must be less than end hour.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStart.Focus();
                return;
            }

            int total = 0;
            int hoursAt500 = 0;
            int hoursAt1000 = 0;
            int hoursAt1500 = 0;

            for (int hour = startHour; hour < endHour; hour++)
            {
                int rate = GetRateForHour(hour);
                total = total + rate;

                if (rate == 500)
                {
                    hoursAt500++;
                }
                else if (rate == 1000)
                {
                    hoursAt1000++;
                }
                else
                {
                    hoursAt1500++;
                }
            }

            txtTotal.Text = total + " RWF";

            string summary =
                "Rental from " + startHour + "h to " + endHour + "h (" + (endHour - startHour) + " hours)\n\n" +
                hoursAt500 + " hour(s) x 500 RWF = " + (hoursAt500 * 500) + " RWF\n" +
                hoursAt1000 + " hour(s) x 1000 RWF = " + (hoursAt1000 * 1000) + " RWF\n" +
                hoursAt1500 + " hour(s) x 1500 RWF = " + (hoursAt1500 * 1500) + " RWF\n\n" +
                "TOTAL TO PAY: " + total + " RWF";

            MessageBox.Show(summary, "Rental price",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int GetRateForHour(int hour)
        {
            if (hour < 7 || hour >= 21)
            {
                return 500;
            }
            else if (hour < 14 || hour >= 19)
            {
                return 1000;
            }
            else
            {
                return 1500;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            isNavigating = true;
            chooseForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to log out?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                isNavigating = true;
                loginForm.ClearFields();
                loginForm.Show();
                chooseForm.CloseForLogout();
                this.Close();
            }
        }

        private void BicycleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isNavigating)
            {
                Application.Exit();
            }
        }
    }
}
