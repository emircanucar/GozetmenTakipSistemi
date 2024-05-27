namespace GozetmenTakipSistemi.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            buttonLogin.TabIndex = 0;
            buttonExit.TabIndex = 1;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
