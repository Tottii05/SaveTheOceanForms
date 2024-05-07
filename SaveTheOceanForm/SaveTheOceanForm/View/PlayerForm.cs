using SaveTheOceanForm.Business.Entities;

namespace SaveTheOceanForm.View
{
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
            List<string> roles = new List<string>()
            {
                "Técnico",
                "Veterinario"
            };
            foreach (string role in roles)
            {
                role_ComboBox.Items.Add(role);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            const string EmptyNameException = "empty name";
            const string EmptyRoleException = "empty role";
            const string EmptyName = "El nombre no puede estar vacío";
            const string EmptyRole = "El rol no puede estar vacío";
            const string PlayerCreated = "¡Jugador creado!";
            const int TechnicianXP = 45;
            const int VeterinarianXP = 80;

            try
            {
                if (name_TextBox.Text == string.Empty)
                {
                    throw new Exception(EmptyNameException);
                }
                else if (role_ComboBox.Text == string.Empty)
                {
                    throw new Exception(EmptyRoleException);
                }
                else
                {
                    int xp = 0;
                    xp = role_ComboBox.Text == "Técnico" ? TechnicianXP : VeterinarianXP;
                    Player player = new Player(name_TextBox.Text, role_ComboBox.Text, xp);
                    NameError.Clear();
                    RoleError.Clear();
                    MessageBox.Show(PlayerCreated);
                    Hide();
                    Game game = new Game(player);
                    game.Show();
                }
            }catch(Exception ex)
            {
                if (ex.Message == EmptyNameException)
                {
                    NameError.SetError(name_TextBox, EmptyName);
                }
                else if (ex.Message == EmptyRoleException)
                {
                    RoleError.SetError(role_ComboBox, EmptyRole);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
