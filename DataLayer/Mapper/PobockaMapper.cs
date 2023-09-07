using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.dto;

namespace DataLayer.Mapper
{
    public class PobockaMapper
    {

        public static string SQLSelect = "SELECT idPobocka, nazev, adresa, telefon FROM Pobocka";

        public static string SQLSelectID = "SELECT idPobocka, nazev, adresa, telefon FROM Pobocka WHERE idPobocka = @idPobocka";

        public static Collection<PobockaDTO> SelectAll()
        {
            var db = Database.Instance;
            db.Connect();

            SqlCommand command = db.CreateCommand(SQLSelect);
            SqlDataReader reader = db.Select(command);

            Collection<PobockaDTO> pobockas = Read(reader);
            reader.Close();
            db.Close();
            return pobockas;
        }

        private static Collection<PobockaDTO> Read(SqlDataReader reader)
        {
            Collection<PobockaDTO> pobockas = new Collection<PobockaDTO>();
            while (reader.Read())
            {
                int i = 0;
                PobockaDTO pobocka = new PobockaDTO(reader.GetInt32(i),
                    reader.GetString(++i),
                    reader.GetString(++i),
                    reader.GetString(++i));
                pobockas.Add(pobocka);
            }
            return pobockas;
        }

        public static PobockaDTO SelectID(int idPobocka)
        {
            var db = Database.Instance;
            db.Connect();

            SqlCommand command = db.CreateCommand(SQLSelectID);
            command.Parameters.AddWithValue("@idPobocka", idPobocka);
            SqlDataReader reader = db.Select(command);
            Collection<PobockaDTO> pobockas = Read(reader);
            PobockaDTO pobocka = null;
            if (pobockas.Count == 1)
            {
                pobocka = pobockas[0];
            }
            reader.Close();
            db.Close();
            return pobocka;
        }
    }
}
