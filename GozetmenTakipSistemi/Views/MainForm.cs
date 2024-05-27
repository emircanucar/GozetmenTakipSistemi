using GozetmenTakipSistemi.Views.Childs;

namespace GozetmenTakipSistemi.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonGozetmen_Click(object sender, EventArgs e)
        {
            SupervisorForm supervisorForm = new SupervisorForm();
            supervisorForm.TopLevel = false;
            panelConent.Controls.Clear();
            panelConent.Controls.Add(supervisorForm);
            supervisorForm.Dock = DockStyle.Fill;
            supervisorForm.Show();

        }

        private void buttonExamHall_Click(object sender, EventArgs e)
        {
            ExamHallForm examHallForm = new ExamHallForm();
            examHallForm.TopLevel = false;
            panelConent.Controls.Clear();
            panelConent.Controls.Add(examHallForm);
            examHallForm.Dock = DockStyle.Fill;
            examHallForm.Show();
        }

        private void buttonSınav_Click(object sender, EventArgs e)
        {
            ExamListForm examListForm = new ExamListForm();
            examListForm.TopLevel = false;
            panelConent.Controls.Clear();
            panelConent.Controls.Add(examListForm);
            examListForm.Dock = DockStyle.Fill;
            examListForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssignmentForm assignmentForm = new AssignmentForm();
            assignmentForm.TopLevel = false;
            panelConent.Controls.Clear();
            panelConent.Controls.Add(assignmentForm);
            assignmentForm.Dock = DockStyle.Fill;
            assignmentForm.Show();
        }
    }
}
