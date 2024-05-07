using SaveTheOceanForm.View;

namespace SaveTheOceanForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        public void Play_Click(object sender, EventArgs e)
        {
           Hide();
            PlayerForm playerForm = new PlayerForm();
            playerForm.Show();
        }
        public void Leave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
