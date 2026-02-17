namespace ConfigBuilder
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
            new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/itsflameee/ConfigBuilder/",
                UseShellExecute = true
            }
            );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
            new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/itsflameee/jailed/blob/main/guides/configbuilder.md",
                UseShellExecute = true
            }
            );
        }
    }
}
