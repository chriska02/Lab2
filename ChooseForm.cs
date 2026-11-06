namespace Lab2
{
    public partial class ChooseForm : Form
    {
        private readonly LoginForm loginForm;

        private bool isNavigating = false;

        public ChooseForm(LoginForm login)
        {
            InitializeComponent();
            loginForm = login;
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            BicycleForm bicycleForm = new BicycleForm(loginForm, this);
            bicycleForm.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroomForm = new MushroomForm(loginForm, this);
            mushroomForm.Show();
            this.Hide();
        }

        public void CloseForLogout()
        {
            isNavigating = true;
            this.Close();
        }

        private void ChooseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isNavigating)
            {
                Application.Exit();
            }
        }
    }
}
