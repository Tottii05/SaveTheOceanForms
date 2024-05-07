using SaveTheOceanForm.Business.DTOs;
using SaveTheOceanForm.Persistence.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheOceanForm.View
{
    public partial class ExtraBBDDAccess : Form
    {
        public ExtraBBDDAccess()
        {
            InitializeComponent();
        }
        private void ExtraBBDDAccess_Load(object sender, EventArgs e)
        {
            RescueDAO rescueDAO = new RescueDAO();
            List<string> allResCodes = rescueDAO.GetAllResCodes();
            ResCodes_ComboBox.DataSource = allResCodes;
        }
        private void GetAllBtn_Click(object sender, EventArgs e)
        {
            RescueDAO rescueDAO = new RescueDAO();
            List<RescueDTO> rescues = rescueDAO.GetAllRescues();
            List<ExtraInfoDTO> extraInfo = rescueDAO.GetAllExtraInfo();
            RescuesDGV.DataSource = rescues;
            ExtrasDGV.DataSource = extraInfo;
        }
        private void GetById_Click(object sender, EventArgs e)
        {
            RescueDAO rescueDAO = new RescueDAO();
            string resCode = ResCodes_ComboBox.SelectedItem.ToString();
            RescueDTO rescue = rescueDAO.GetRescue(resCode);
            ExtraInfoDTO extraInfo = rescueDAO.GetExtraInfo(resCode);
            RescuesDGV.DataSource = new List<RescueDTO> { rescue };
            ExtrasDGV.DataSource = new List<ExtraInfoDTO> { extraInfo };
        }
    }
}
