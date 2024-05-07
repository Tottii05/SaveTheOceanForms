
namespace SaveTheOceanForm.Business.Entities
{
    [Serializable]
    public class Player
    {
        public string? Name { get; set; }
        public string? Role { get; set; }
        public int Score { get; set; }

        public Player(string? name, string? role, int score)
        {
            Name = name;
            Role = role;
            Score = score;
        }
        public Player()
        {
        }
    }
}
