using SaveTheOceanForm.Business.Entities;
using System.Xml.Serialization;

namespace SaveTheOceanForm.Business.Utils
{
    public static class XMLHelper
    {
        public static void SavePlayerInfo(Player player)
        {
            const string path = "../../../Files/PlayersInfo.xml";

            List<Player> players = new List<Player>();
            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));

                using (StreamReader reader = new StreamReader(path))
                {
                    players = (List<Player>)serializer.Deserialize(reader);
                }
            }
            players.Add(player);

            XmlSerializer serializer2 = new XmlSerializer(typeof(List<Player>));

            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer2.Serialize(writer, players);
            }
        }
    }
}
