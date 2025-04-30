namespace faunusVB
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameLabel_Click(object sender, EventArgs e)
        {
           
           Faunus f = new Faunus();
            f.Show();
            this.Hide();
        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = System.Drawing.Color.Red;
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void settingsLabel_MouseEnter(object sender, EventArgs e)
        {
            settingsLabel.ForeColor = System.Drawing.Color.LightBlue;
        }

        private void settingsLabel_MouseLeave(object sender, EventArgs e)
        {
            settingsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void newGameLabel_MouseEnter(object sender, EventArgs e)
        {
            newGameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
        }

        private void newGameLabel_MouseLeave(object sender, EventArgs e)
        {
            newGameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
        }
    }
}
