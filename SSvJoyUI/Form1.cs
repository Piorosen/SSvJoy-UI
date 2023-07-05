namespace SSvJoyUI
{
    public partial class Form1 : Form
    {
        Requester requester = new Requester();
        public Form1()
        {
            InitializeComponent();
        }

        private void LudderScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                requester.Ludder = e.NewValue;
            }
        }

        private void EngineLeftScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                requester.EngineL = e.NewValue;
            }
        }

        private void EngineRightScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                requester.EngineR = e.NewValue;
            }
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            string ip = this.ServerIPTextBox.Text == "" ? ServerIPTextBox.Text : ServerIPTextBox.PlaceholderText;
            string port = this.ServerPortTextBox.Text == "" ? ServerPortTextBox.Text : ServerPortTextBox.PlaceholderText;

            if (int.TryParse(port, out int portint) == false)
            {
                MessageBox.Show("Port is not a number");
                return;
            }

            requester.Connect(ip, portint);
        }
    }
}