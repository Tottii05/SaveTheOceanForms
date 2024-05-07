using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanForm.Business.Utils
{
    public static class RandomHelper
    {
        public static string GenerateRescueCode()
        {
            Random random = new Random();
            string code = "RES" + random.Next(0, 1000);
            return code;
        }
        public static int GenerateRescueAfectation()
        {
            Random random = new Random();
            int afectation = random.Next(0, 100);
            return afectation;
        }
        public static string RandomResCode(List<string> resCodes)
        {
            Random random = new Random();
            string resCode = resCodes[random.Next(0, resCodes.Count)];
            return resCode;
        }
    }
}
