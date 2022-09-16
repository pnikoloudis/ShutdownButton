namespace ShutdownButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var confirmShutdown = MessageBox.Show("Are you sure you want to shutdown?", "Press 'Yes' to shutdown...", MessageBoxButtons.YesNo);
            
            if(confirmShutdown == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("Shutdown", "/s /t 0");
            }
            else
            {
                //do nothing and returns to main window
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}