using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using DTO.dto;

namespace DataLayer.Mapper
{
  public class ObsluhaMapper
    {
        public static string SQLSelect = "SELECT idObsluha, jmeno, prijmeni, datumNarozeni, adresa, email, telefon FROM Obsluha";

        public static string SQLSelectID = "SELECT idObsluha, jmeno, prijmeni, datumNarozeni, adresa, email, telefon FROM Obsluha WHERE idObsluha = @idObsluha";

        public static string SQLUpdate = "UPDATE Obsluha SET idObsluha=@idObsluha, jmeno=@jmeno, prijmeni=@prijmeni, datumNarozeni=@datumNarozeni, adresa=@adresa, email=@email, telefon=@telefon WHERE idObsluha=@idObsluha";

        private static void PrepareCommand(SqlCommand command, ObsluhaDTO obsluha)
        {
            command.Parameters.AddWithValue("@jmeno", obsluha.jmeno);
            command.Parameters.AddWithValue("@prijmeni", obsluha.prijmeni);
            command.Parameters.AddWithValue("@datumNarozeni", obsluha.datumNarozeni);
            command.Parameters.AddWithValue("@adresa", obsluha.adresa);
            command.Parameters.AddWithValue("@email", obsluha.email);
            command.Parameters.AddWithValue("@telefon", obsluha.telefon);
        }

        public static Collection<ObsluhaDTO> SelectAll()
        {
            var db = Database.Instance;
            db.Connect();

            SqlCommand command = db.CreateCommand(SQLSelect);
            SqlDataReader reader = db.Select(command);

            Collection<ObsluhaDTO> obsluhas = Read(reader);
            reader.Close();
            db.Close();
            return obsluhas;
        }

        private static Collection<ObsluhaDTO> Read(SqlDataReader reader)
        {
            Collection<ObsluhaDTO> obsluhas = new Collection<ObsluhaDTO>();
            while (reader.Read())
            {
                int i = 0;
                ObsluhaDTO obsluha = new ObsluhaDTO(reader.GetInt32(i),
                    reader.GetString(++i),
                    reader.GetString(++i),
                    reader.GetDateTime(++i),
                    reader.GetString(++i),
                    reader.GetString(++i),
                    reader.GetString(++i));
                obsluhas.Add(obsluha);
            }
            return obsluhas;
        }

        public static ObsluhaDTO SelectID(int idObsluha)
        {
            var db = Database.Instance;
            db.Connect();

            SqlCommand command = db.CreateCommand(SQLSelectID);
            command.Parameters.AddWithValue("@idObsluha", idObsluha);
            SqlDataReader reader = db.Select(command);
            Collection<ObsluhaDTO> obsluhas = Read(reader);
            ObsluhaDTO obsluha = null;
            if (obsluhas.Count == 1)
            {
                obsluha = obsluhas[0];
            }
            reader.Close();
            db.Close();
            return obsluha;
        }

        public static int update(ObsluhaDTO obsluha)
        {
            var db = Database.Instance;
            db.Connect();
            SqlCommand command = db.CreateCommand(SQLUpdate);
            PrepareCommand(command, obsluha);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
    }
}
