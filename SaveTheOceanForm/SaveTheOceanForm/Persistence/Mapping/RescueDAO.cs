using Npgsql;
using SaveTheOceanForm.Business.DTOs;
using SaveTheOceanForm.Business.Entities;
using SaveTheOceanForm.Persistence.DAO;
using SaveTheOceanForm.Persistence.Utils;

namespace SaveTheOceanForm.Persistence.Mapping
{
    public class RescueDAO : IRescueDAO
    {
        public void Insert(Rescue rescue)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO rescue (rescode, resdate, resfamily, resafectation, reslocation) VALUES (@rescode, @resdate, @resfamily, @resafectation, @reslocation)";
                    command.Parameters.AddWithValue("@rescode", rescue.ResCode);
                    command.Parameters.AddWithValue("@resdate", rescue.ResDate);
                    command.Parameters.AddWithValue("@resfamily", rescue.ResFamily);
                    command.Parameters.AddWithValue("@resafectation", rescue.ResAfectation);
                    command.Parameters.AddWithValue("@reslocation", rescue.ResLocation);
                    command.ExecuteNonQuery();
                }
            }
        }
        public RescueDTO GetRescue(string resCode)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM rescue WHERE rescode = @rescode";
                    command.Parameters.AddWithValue("@rescode", resCode);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RescueDTO
                            {
                                ResCode = reader["rescode"].ToString(),
                                ResDate = (DateTime)reader["resdate"],
                                ResFamily = reader["resfamily"].ToString(),
                                ResAfectation = (int)reader["resafection"],
                                ResLocation = reader["reslocation"].ToString()
                            };
                        }
                        return null;
                    }
                }
            }
        }
        public ExtraInfoDTO GetExtraInfo(string resCode)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM ExtraInfo WHERE ResCode = @rescode";
                    command.Parameters.AddWithValue("@rescode", resCode);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ExtraInfoDTO
                            {
                                Name = reader["Name"].ToString(),
                                Family = reader["ResFamily"].ToString(),
                                Specie = reader["Specie"].ToString(),
                                Weight = (double)reader["Weight"]
                            };
                        }
                        return null;
                    }
                }
            }
        }
        public List<string> GetAllResCodes()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT rescode FROM rescue";
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> resCodes = new List<string>();
                        while (reader.Read())
                        {
                            resCodes.Add(reader["rescode"].ToString());
                        }
                        return resCodes;
                    }
                }
            }
        }
        public List<RescueDTO> GetAllRescues()
        {
               using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM rescue";
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        List<RescueDTO> rescues = new List<RescueDTO>();
                        while (reader.Read())
                        {
                            rescues.Add(new RescueDTO
                            {
                                ResCode = reader["rescode"].ToString(),
                                ResDate = (DateTime)reader["resdate"],
                                ResFamily = reader["resfamily"].ToString(),
                                ResAfectation = (int)reader["resafection"],
                                ResLocation = reader["reslocation"].ToString()
                            });
                        }
                        return rescues;
                    }
                }
            }
        }
        public List<ExtraInfoDTO> GetAllExtraInfo()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM ExtraInfo";
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        List<ExtraInfoDTO> extraInfo = new List<ExtraInfoDTO>();
                        while (reader.Read())
                        {
                            extraInfo.Add(new ExtraInfoDTO
                            {
                                Name = reader["Name"].ToString(),
                                Family = reader["ResFamily"].ToString(),
                                Specie = reader["Specie"].ToString(),
                                Weight = (double)reader["Weight"]
                            });
                        }
                        return extraInfo;
                    }
                }
            }
        }
    }
}
