namespace QuizMe_
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            this.Hide();

            signin.Show();


        }
    }
}
