using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanForm.Business.Entities
{
    public class Rescue
    {
        public string? ResCode { get; set; }
        public DateTime ResDate { get; set; }
        public string? ResFamily { get; set; }
        public int ResAfectation { get; set; }
        public string? ResLocation { get; set; }

        public Rescue(string? resCode, DateTime resDate, string? resFamily, int resAfectation, string? resLocation)
        {
            ResCode = resCode;
            ResDate = resDate;
            ResFamily = resFamily;
            ResAfectation = resAfectation;
            ResLocation = resLocation;
        }
    }
}
