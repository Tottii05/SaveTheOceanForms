using SaveTheOceanForm.Business.Utils;

namespace SaveTheOceanForm.Business.Entities
{
    public class Cetacean : Rescue, ITreatable
    {
        public string? Name { get; set; }
        public string? Specie { get; set; }
        public double Weight { get; set; }
        public Cetacean(string? resCode, DateTime resDate, string? resFamily, int resAfectation, string? resLocation, string? name, string? specie, double weight) : base(resCode, resDate, resFamily, resAfectation, resLocation)
        {
            Name = name;
            Specie = specie;
            Weight = weight;
        }
        /// <summary>
        /// Metodo que trata al animal recuperado de la inteface
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public double Treat(bool move)
        {
            int newRestAfectation, x;
            x = move ? 0 : 50;
            newRestAfectation = ResAfectation - (ResAfectation / 5) - x;
            return newRestAfectation;
        }
    }
}
