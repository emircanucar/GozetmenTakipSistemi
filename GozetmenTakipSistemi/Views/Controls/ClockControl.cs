namespace GozetmenTakipSistemi.Views.Controls
{
    public partial class ClockControl : UserControl
    {
        public ClockControl()
        {
            InitializeComponent();
        }

        private void ClockControl_Load(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
