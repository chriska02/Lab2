namespace Lab2
{
    public partial class MushroomForm : Form
    {
        private readonly LoginForm loginForm;
        private readonly ChooseForm chooseForm;

        private bool isNavigating = false;

        private int currentStep = 1;

        private int questionNumber = 1;

        public MushroomForm(LoginForm login, ChooseForm choose)
        {
            InitializeComponent();
            loginForm = login;
            chooseForm = choose;

            StartGame();
        }

        private void StartGame()
        {
            currentStep = 1;
            questionNumber = 1;
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            string question = "";

            if (currentStep == 1)
            {
                question = "Does your mushroom have a convex cup?";
            }
            else if (currentStep == 2)
            {
                question = "Does your mushroom have a ring?";
            }
            else if (currentStep == 3 || currentStep == 4)
            {
                question = "Does your mushroom grow in a forest?";
            }
            else if (currentStep == 5)
            {
                question = "Does your mushroom have gills?";
            }

            lblQuestionNumber.Text = "Question " + questionNumber + " (at most 3)";
            lblQuestion.Text = question;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            HandleAnswer(true);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            HandleAnswer(false);
        }

        private void HandleAnswer(bool yes)
        {
            string result = "";

            switch (currentStep)
            {
                case 1:
                    if (yes)
                    {
                        currentStep = 2;
                    }
                    else
                    {
                        currentStep = 3;
                    }
                    break;

                case 2:
                    if (yes)
                    {
                        currentStep = 4;
                    }
                    else
                    {
                        result = "Pied bleu";
                    }
                    break;

                case 3:
                    if (yes)
                    {
                        currentStep = 5;
                    }
                    else
                    {
                        result = "Coprin chevelu";
                    }
                    break;

                case 4:
                    if (yes)
                    {
                        result = "Amanite tue-mouche";
                    }
                    else
                    {
                        result = "Agaric jaunissant";
                    }
                    break;

                case 5:
                    if (yes)
                    {
                        result = "Girolle";
                    }
                    else
                    {
                        result = "Cepe de Bordeaux";
                    }
                    break;

                default:
                    MessageBox.Show("Something went wrong. The game will restart.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StartGame();
                    return;
            }

            if (result != "")
            {
                MessageBox.Show("Your mushroom is: " + result, "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartGame();
            }
            else
            {
                questionNumber++;
                ShowQuestion();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartGame();
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

        private void MushroomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isNavigating)
            {
                Application.Exit();
            }
        }
    }
}
