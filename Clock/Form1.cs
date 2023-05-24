namespace Clock
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            orangeButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Firebrick;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.PeachPuff;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Khaki;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.PaleGreen;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.PaleTurquoise;
        }

        private void clockLabel_Click(object sender, EventArgs e)
        {

        }

        private void styleButton1_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Tempus Sans ITC", 48, FontStyle.Regular);
        }

        private void styleButton2_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Times New Roman", 48, FontStyle.Regular);
        }

        private void styleButton3_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Vivaldi", 48, FontStyle.Regular);
        }
    }
}