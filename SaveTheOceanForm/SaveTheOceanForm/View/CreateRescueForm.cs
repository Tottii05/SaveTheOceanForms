using SaveTheOceanForm.Business.Entities;
using SaveTheOceanForm.Business.Utils;
using System.Text.RegularExpressions;

namespace SaveTheOceanForm.View
{
    public partial class CreateRescueForm : Form
    {
        public CreateRescueForm()
        {
            InitializeComponent();
        }

        public event EventHandler<ObjectsCreatedEventArgs> ObjectsCreated;

        protected virtual void OnObjectsCreated(ObjectsCreatedEventArgs e)
        {
            ObjectsCreated?.Invoke(this, e);
        }

        private void CreateRescueBtn_Click(object sender, EventArgs e)
        {
            const string EmptyErrorMsg = "Este campo no puede estar vacío";
            const string NotANumberErrorMsg = "Este campo debe ser un número";

            Regex isNumber = new Regex(@"^\d+$");
            string resCode = RandomHelper.GenerateRescueCode();
            int resAfectation = RandomHelper.GenerateRescueAfectation();
            try
            {
                try
                {
                    if (superFamily_ComboBox.Text == string.Empty)
                    {
                        throw new Exception(EmptyErrorMsg);
                    }
                    else
                    {
                        EmptyError.Clear();
                    }
                }
                catch (Exception ex)
                {
                    EmptyError.SetError(superFamily_ComboBox, ex.Message);
                }
                try
                {
                    if (location_TextBox.Text == string.Empty)
                    {
                        throw new Exception(EmptyErrorMsg);
                    }
                    else
                    {
                        EmptyError.Clear();
                    }
                }
                catch (Exception ex)
                {
                    EmptyError.SetError(location_TextBox, ex.Message);
                }
                try
                {
                    if (name_TextBox.Text == string.Empty)
                    {
                        throw new Exception(EmptyErrorMsg);
                    }
                    else
                    {
                        EmptyError.Clear();
                    }
                }
                catch (Exception ex)
                {
                    EmptyError.SetError(name_TextBox, ex.Message);
                }
                try
                {
                    if (specie_TextBox.Text == string.Empty)
                    {
                        throw new Exception(EmptyErrorMsg);
                    }
                    else
                    {
                        EmptyError.Clear();
                    }
                }
                catch (Exception ex)
                {
                    EmptyError.SetError(specie_TextBox, ex.Message);
                }
                try
                {
                    if (weight_TextBox.Text == string.Empty)
                    {
                        throw new Exception(EmptyErrorMsg);
                    }
                    else
                    {
                        EmptyError.Clear();
                    }
                    if (!isNumber.IsMatch(weight_TextBox.Text))
                    {
                        throw new Exception(NotANumberErrorMsg);
                    }
                    else
                    {
                        EmptyError.Clear();
                    }
                }
                catch (Exception ex)
                {
                    EmptyError.SetError(weight_TextBox, ex.Message);
                }
                Rescue rescue = new Rescue(resCode, DateTime.Now, superFamily_ComboBox.Text, resAfectation, location_TextBox.Text);
                object animal = null;
                switch (superFamily_ComboBox.Text)
                {
                    case "Tortuga Marina":
                        animal = new Turtle(resCode, DateTime.Now, superFamily_ComboBox.Text, resAfectation, location_TextBox.Text, name_TextBox.Text, specie_TextBox.Text, double.Parse(weight_TextBox.Text));
                        break;
                    case "Ave Marina":
                        animal = new SeaBird(resCode, DateTime.Now, superFamily_ComboBox.Text, resAfectation, location_TextBox.Text, name_TextBox.Text, specie_TextBox.Text, double.Parse(weight_TextBox.Text));
                        break;
                    case "Cetaceo":
                        animal = new Cetacean(resCode, DateTime.Now, superFamily_ComboBox.Text, resAfectation, location_TextBox.Text, name_TextBox.Text, specie_TextBox.Text, double.Parse(weight_TextBox.Text));
                        break;
                }
                OnObjectsCreated(new ObjectsCreatedEventArgs(rescue, animal));
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateRescueForm_Load(object sender, EventArgs e)
        {
            List<string> superFamilies = new List<string>()
            {
                "Tortuga Marina",
                "Ave Marina",
                "Cetaceo"
            };
            superFamily_ComboBox.DataSource = superFamilies;
        }
    }
}
