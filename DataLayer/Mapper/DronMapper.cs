using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using DTO.dto;

namespace DataLayer.Mapper
{
  public class DronMapper
    {
        public static string SQLSelect = "SELECT idDron, nazev, kategorie, rychlost, dobaLetu, pocetVrtuli, cenaDen, zaloha, stav FROM Dron";

        public static string SQLSelectID = "SELECT idDron, nazev, kategorie, rychlost, dobaLetu, pocetVrtuli, cenaDen, zaloha, stav FROM Dron WHERE idDron = @idDron";

        public static string SQLInsert = "INSERT INTO Dron(nazev, kategorie, rychlost, dobaLetu, pocetVrtuli, cenaDen, zaloha, stav) VALUES (@nazev, @kategorie, @rychlost, @dobaLetu, @pocetVrtuli, @cenaDen, @zaloha, @stav)";

        public static string SQLUpdateStav = "UPDATE Dron SET stav = @stav WHERE idDron = @idDron";

        public static string SQLUpdate = "UPDATE Dron SET idDron=@idDron, nazev=@nazev, kategorie=@kategorie, rychlost=@rychlost, dobaLetu=@dobaLetu, pocetVrtuli=@pocetVrtuli, cenaDen=@cenaDen, zaloha=@zaloha, stav=@stav WHERE idDron=@idDron";

        public static string SqlDelete = "DELETE FROM Dron WHERE idDron = @idDron ";


        public int Insert(DronDTO dron)
        {
            Database db = Database.Instance;
            db.Connect();

            SqlCommand command = db.CreateCommand(SQLInsert);
            PrepareCommand(command, dron);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        private void PrepareCommand(SqlCommand command, DronDTO dron)
        {
            command.Parameters.AddWithValue("@nazev", dron.nazev);
            command.Parameters.AddWithValue("@kategorie", dron.kategorie);
            command.Parameters.AddWithValue("@rychlost", dron.rychlost);
            command.Parameters.AddWithValue("@dobaLetu", dron.dobaLetu);
            command.Parameters.AddWithValue("@pocetVrtuli", dron.pocetVrtuli);
            command.Parameters.AddWithValue("@cenaDen", dron.cenaDen);
            command.Parameters.AddWithValue("@zaloha", dron.zaloha);
            command.Parameters.AddWithValue("@stav", dron.stav);
        }

        public Collection<DronDTO> SelectAll()
        {
            var db = Database.Instance;
            db.Connect();

            SqlCommand command = db.CreateCommand(SQLSelect);
            SqlDataReader reader = db.Select(command);

            Collection<DronDTO> drons = Read(reader);
            reader.Close();
            db.Close();
            return drons;
        }

        private Collection<DronDTO> Read(SqlDataReader reader)
        {
            Collection<DronDTO> drons = new Collection<DronDTO>();
            while (reader.Read())
            {
                int i = 0;
                DronDTO dron = new DronDTO(reader.GetInt32(i),
                    reader.GetString(++i),
                    reader.GetString(++i),
                    reader.GetInt32(++i),
                    reader.GetInt32(++i),
                    reader.GetInt32(++i),
                    reader.GetInt32(++i),
                    reader.GetInt32(++i),
                    reader.GetString(++i)
                    );                        
                drons.Add(dron);
            }

            return drons;
        }

        public DronDTO SelectID(int idDron)
        {
            var db = Database.Instance;
            db.Connect();

            SqlCommand command = db.CreateCommand(SQLSelectID);
            command.Parameters.AddWithValue("@idDron", idDron);
            SqlDataReader reader = db.Select(command);
            Collection<DronDTO> drons = Read(reader);
            DronDTO dron = null;
            if (drons.Count == 1)
            {
                dron = drons[0];
            }
            reader.Close();
            db.Close();
            return dron;
        }

        public int updateStav(int idDron, string stav)
        {
            var db = Database.Instance;
            db.Connect();
            SqlCommand command = db.CreateCommand(SQLUpdateStav);
            command.Parameters.AddWithValue("@idDron", idDron);
            command.Parameters.AddWithValue("@stav", stav);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public int update(DronDTO dron)
        {
            var db = Database.Instance;
            db.Connect();
            SqlCommand command = db.CreateCommand(SQLUpdate);
            PrepareCommand(command, dron);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public int Delete(int idDron)
        {
            var db = Database.Instance;
            db.Connect();
            SqlCommand command = db.CreateCommand(SqlDelete);
            command.Parameters.AddWithValue("@idDron", idDron);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;

        }
    }
}
