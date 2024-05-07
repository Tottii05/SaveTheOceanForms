using SaveTheOceanForm.Business.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanForm.Business.Entities
{
    public class Turtle : Rescue, ITreatable
    {
        public string? Name { get; set; }
        public string? Specie { get; set; }
        public double Weight { get; set; }

        public Turtle(string? resCode, DateTime resDate, string? resFamily, int resAfectation, string? resLocation, string? name, string? specie, double weight) : base(resCode, resDate, resFamily, resAfectation, resLocation)
        {
            Name = name;
            Specie = specie;
            Weight = weight;
        }

        public double Treat(bool move)
        {
            int newRestAfectation, x;
            x = 15;
            newRestAfectation = (2 * ResAfectation + 3) - ((ResAfectation - 20) * 2) - x;
            return newRestAfectation;
        }
    }
}
