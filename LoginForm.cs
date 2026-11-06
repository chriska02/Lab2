namespace Lab2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "")
            {
                MessageBox.Show("Username cannot be empty.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Password cannot be empty.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            MessageBox.Show("Welcome, " + username + "!", "Login",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChooseForm chooseForm = new ChooseForm(this);
            chooseForm.Show();

            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to close the application?",
                "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}
