using SaveTheOceanForm.Business.DTOs;
using SaveTheOceanForm.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanForm.Persistence.DAO
{
    public interface IRescueDAO
    {
        public void Insert(Rescue rescue);
        public RescueDTO GetRescue(string resCode);
        public ExtraInfoDTO GetExtraInfo(string resCode);
        public List<string> GetAllResCodes();
        public List<RescueDTO> GetAllRescues();
        public List<ExtraInfoDTO> GetAllExtraInfo();
    }
}
