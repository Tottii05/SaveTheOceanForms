using SaveTheOceanForm.Business.DTOs;
using SaveTheOceanForm.Business.Entities;
using SaveTheOceanForm.Business.Utils;
using SaveTheOceanForm.Persistence.Mapping;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SaveTheOceanForm.View
{
    public partial class Game : Form
    {
        private Player human;
        public Game(Player player)
        {
            InitializeComponent();
            human = player;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            RescueDGV.Columns.Add("CodigoColumn", "# Rescate");
            RescueDGV.Columns.Add("FechaColumn", "Fecha rescate");
            RescueDGV.Columns.Add("SuperFamiliaColumn", "Superfamília");
            RescueDGV.Columns.Add("AfectacionColumn", "GA");
            RescueDGV.Columns.Add("UbicacionColumn", "Ubicación");

            ExtraInfoDGV.Columns.Add("NombreColumn", "# Nombre");
            ExtraInfoDGV.Columns.Add("FamiliaColumn", "Superfamília");
            ExtraInfoDGV.Columns.Add("EspecieColumn", "Especie");
            ExtraInfoDGV.Columns.Add("PesoColumn", "Peso aproximado");
        }


        private void ExtraInfoBtn_Click(object sender, EventArgs e)
        {
            ExtraInfoDGV.Visible = true;
        }

        private void CreateAnimal_Click(object sender, EventArgs e)
        {
            CreateRescueForm createRescueForm = new CreateRescueForm();
            createRescueForm.ObjectsCreated += CreateRescueForm_ObjectsCreated;
            createRescueForm.ShowDialog();
        }

        private void CreateRescueForm_ObjectsCreated(object sender, ObjectsCreatedEventArgs e)
        {
            Rescue rescue = e.RescueObject;
            object animal = e.AnimalObject;

            string animalName = "";
            string animalFamily = "";
            double animalWeight = 0;

            if (animal is Turtle)
            {
                Turtle turtle = animal as Turtle;
                animalName = turtle.Name;
                animalFamily = turtle.Specie;
                animalWeight = turtle.Weight;
            }
            else if (animal is SeaBird)
            {
                SeaBird seaBird = animal as SeaBird;
                animalName = seaBird.Name;
                animalFamily = seaBird.Specie;
                animalWeight = seaBird.Weight;
            }
            else
            {
                Cetacean cetacean = animal as Cetacean;
                animalName = cetacean.Name;
                animalFamily = cetacean.Specie;
                animalWeight = cetacean.Weight;
            }

            int rowIndexRescue = RescueDGV.Rows.Add(), rowIndexExtraInfo = ExtraInfoDGV.Rows.Add();
            DataGridViewRow rowRescue = RescueDGV.Rows[rowIndexRescue];
            rowRescue.Cells["CodigoColumn"].Value = rescue.ResCode;
            rowRescue.Cells["FechaColumn"].Value = rescue.ResDate;
            rowRescue.Cells["SuperFamiliaColumn"].Value = rescue.ResFamily;
            rowRescue.Cells["AfectacionColumn"].Value = rescue.ResAfectation;
            rowRescue.Cells["UbicacionColumn"].Value = rescue.ResLocation;

            DataGridViewRow rowExtraInfo = ExtraInfoDGV.Rows[rowIndexExtraInfo];
            rowExtraInfo.Cells["NombreColumn"].Value = animalName;
            rowExtraInfo.Cells["FamiliaColumn"].Value = animalFamily;
            rowExtraInfo.Cells["EspecieColumn"].Value = rescue.ResFamily;
            rowExtraInfo.Cells["PesoColumn"].Value = animalWeight;
        }

        private void Move_Click(object sender, EventArgs e)
        {
            const string NoRowsSelected = "No hay filas seleccionadas.";
            const string NotSameFamily = "La especie no coincide con la super familia.";
            const string WinXP = "El grado de afectación a bajado del 30%, ganas 50 xp";
            const string LoseXP = "El grado de afectación a bajado del 30%, pierdes 20 xp";

            try
            {
                if (RescueDGV.SelectedRows.Count == 0 || ExtraInfoDGV.SelectedRows.Count == 0)
                {
                    throw new Exception(NoRowsSelected);
                }
                else if (ExtraInfoDGV.SelectedRows[0].Cells["FamiliaColumn"].Value.ToString() != RescueDGV.SelectedRows[0].Cells["SuperFamiliaColumn"].Value.ToString())
                {
                    throw new Exception(NotSameFamily);
                }
                else
                {
                    ExtraInfoDGVError.Clear();
                    ExtraInfoDGVError.UpdateBinding();
                }

                string resCode = RescueDGV.SelectedRows[0].Cells["CodigoColumn"].Value.ToString();
                string resDate = RescueDGV.SelectedRows[0].Cells["FechaColumn"].Value.ToString();
                string superFamily = RescueDGV.SelectedRows[0].Cells["SuperFamiliaColumn"].Value.ToString();
                string afectation = RescueDGV.SelectedRows[0].Cells["AfectacionColumn"].Value.ToString();
                string location = RescueDGV.SelectedRows[0].Cells["UbicacionColumn"].Value.ToString();
                string name = ExtraInfoDGV.SelectedRows[0].Cells["NombreColumn"].Value.ToString();
                string specie = ExtraInfoDGV.SelectedRows[0].Cells["EspecieColumn"].Value.ToString();
                string weight = ExtraInfoDGV.SelectedRows[0].Cells["PesoColumn"].Value.ToString();

                switch (superFamily)
                {
                    case "Tortuga Marina":
                        Turtle turtle = new Turtle(resCode, DateTime.Parse(resDate), superFamily, int.Parse(afectation), location, name, specie, double.Parse(weight));
                        double ga = turtle.Treat(true);
                        MessageBox.Show(ga >= 30 ? LoseXP : WinXP);
                        human.Score += ga >= 30 ? -20 : 50;
                        break;
                    case "Ave Marina":
                        SeaBird seaBird = new SeaBird(resCode, DateTime.Parse(resDate), superFamily, int.Parse(afectation), location, name, specie, double.Parse(weight));
                        double ga2 = seaBird.Treat(true);
                        MessageBox.Show(ga2 >= 30 ? LoseXP : WinXP);
                        human.Score += ga2 >= 30 ? -20 : 50;
                        break;
                    case "Cetaceo":
                        Cetacean cetacean = new Cetacean(resCode, DateTime.Parse(resDate), superFamily, int.Parse(afectation), location, name, specie, double.Parse(weight));
                        double ga3 = cetacean.Treat(true);
                        MessageBox.Show(ga3 >= 30 ? LoseXP : WinXP);
                        human.Score += ga3 >= 30 ? -20 : 50;
                        break;
                }
            }catch(Exception ex)
            {
                ExtraInfoDGVError.SetError(RescueDGV, ex.Message);
            }
        }
        private void Heal_Click(object sender, EventArgs e)
        {
            const string NoRowsSelected = "No hay filas seleccionadas.";
            const string NotSameFamily = "La especie no coincide con la super familia.";
            const string WinXP = "El grado de afectación a bajado del 30%, ganas 50 xp";
            const string LoseXP = "El grado de afectación a bajado del 30%, pierdes 20 xp";
            
            try
            {
                if (RescueDGV.SelectedRows.Count == 0 || ExtraInfoDGV.SelectedRows.Count == 0)
                {
                    throw new Exception(NoRowsSelected);
                }
                else if (ExtraInfoDGV.SelectedRows[0].Cells["FamiliaColumn"].Value.ToString() != RescueDGV.SelectedRows[0].Cells["SuperFamiliaColumn"].Value.ToString())
                {
                    throw new Exception(NotSameFamily);
                }
                else
                {
                    ExtraInfoDGVError.Clear();
                    ExtraInfoDGVError.UpdateBinding();
                }

                string resCode = RescueDGV.SelectedRows[0].Cells["CodigoColumn"].Value.ToString();
                string resDate = RescueDGV.SelectedRows[0].Cells["FechaColumn"].Value.ToString();
                string superFamily = RescueDGV.SelectedRows[0].Cells["SuperFamiliaColumn"].Value.ToString();
                string afectation = RescueDGV.SelectedRows[0].Cells["AfectacionColumn"].Value.ToString();
                string location = RescueDGV.SelectedRows[0].Cells["UbicacionColumn"].Value.ToString();
                string name = ExtraInfoDGV.SelectedRows[0].Cells["NombreColumn"].Value.ToString();
                string specie = ExtraInfoDGV.SelectedRows[0].Cells["EspecieColumn"].Value.ToString();
                string weight = ExtraInfoDGV.SelectedRows[0].Cells["PesoColumn"].Value.ToString();

                switch (superFamily)
                {
                    case "Tortuga Marina":
                        Turtle turtle = new Turtle(resCode, DateTime.Parse(resDate), superFamily, int.Parse(afectation), location, name, specie, double.Parse(weight));
                        double ga = turtle.Treat(false);
                        MessageBox.Show(ga >= 30 ? LoseXP : WinXP);
                        human.Score += ga >= 30 ? -20 : 50;
                        break;
                    case "Ave Marina":
                        SeaBird seaBird = new SeaBird(resCode, DateTime.Parse(resDate), superFamily, int.Parse(afectation), location, name, specie, double.Parse(weight));
                        double ga2 = seaBird.Treat(false);
                        MessageBox.Show(ga2 >= 30 ? LoseXP : WinXP);
                        human.Score += ga2 >= 30 ? -20 : 50;
                        break;
                    case "Cetaceo":
                        Cetacean cetacean = new Cetacean(resCode, DateTime.Parse(resDate), superFamily, int.Parse(afectation), location, name, specie, double.Parse(weight));
                        double ga3 = cetacean.Treat(false);
                        MessageBox.Show(ga3 >= 30 ? LoseXP : WinXP);
                        human.Score += ga3 >= 30 ? -20 : 50;
                        break;
                }
            }catch(Exception ex)
            {
                ExtraInfoDGVError.SetError(RescueDGV, ex.Message);
            }
        }

        private void DBAccess_Click(object sender, EventArgs e)
        {
            RescueDAO rescueDAO = new RescueDAO();
            List<string> rescodes = rescueDAO.GetAllResCodes();
            string randomResCode = RandomHelper.RandomResCode(rescodes);
            RescueDTO rescue = rescueDAO.GetRescue(randomResCode);
            ExtraInfoDTO extraInfo = rescueDAO.GetExtraInfo(randomResCode);
            if (extraInfo != null)
            {
                int rowIndexRescue = RescueDGV.Rows.Add(), rowIndexExtraInfo = ExtraInfoDGV.Rows.Add();
                DataGridViewRow rowRescue = RescueDGV.Rows[rowIndexRescue];
                rowRescue.Cells["CodigoColumn"].Value = rescue.ResCode;
                rowRescue.Cells["FechaColumn"].Value = rescue.ResDate;
                rowRescue.Cells["SuperFamiliaColumn"].Value = rescue.ResFamily;
                rowRescue.Cells["AfectacionColumn"].Value = rescue.ResAfectation;
                rowRescue.Cells["UbicacionColumn"].Value = rescue.ResLocation;

                DataGridViewRow rowExtraInfo = ExtraInfoDGV.Rows[rowIndexExtraInfo];
                rowExtraInfo.Cells["NombreColumn"].Value = extraInfo.Name;
                rowExtraInfo.Cells["FamiliaColumn"].Value = extraInfo.Family;
                rowExtraInfo.Cells["EspecieColumn"].Value = extraInfo.Specie;
                rowExtraInfo.Cells["PesoColumn"].Value = extraInfo.Weight;
            }
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tu XP al final ha sido: {human.Score}");
            XMLHelper.SavePlayerInfo(human);
            Application.Exit();
        }

        private void DBAccessExtra_Click(object sender, EventArgs e)
        {
            ExtraBBDDAccess extraBBDDAccess = new ExtraBBDDAccess();
            extraBBDDAccess.ShowDialog();
        }
    }
}
