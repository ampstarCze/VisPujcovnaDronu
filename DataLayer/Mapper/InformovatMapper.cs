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
    public class InformovatMapper
    {
        public static string SQLSelect = "SELECT idInformovat, idDron, idZakaznika FROM Informovat";
        public static string SQLInsert = "INSERT INTO Informovat(idDron, idZakaznika) VALUES (@idDron, @idZakaznika)";
        public static string SqlDelete = "DELETE FROM Informovat WHERE idInformovat = @idInformovat ";


        public int Insert(InformovatDTO informovat)
        {
            Database db = Database.Instance;
            db.Connect();

            SqlCommand command = db.CreateCommand(SQLInsert);
            command.Parameters.AddWithValue("@idDron", informovat.idDron);
            command.Parameters.AddWithValue("@idZakaznika", informovat.idZakaznika);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        private Collection<InformovatDTO> Read(SqlDataReader reader)
        {
            Collection<InformovatDTO> informovats = new Collection<InformovatDTO>();
            while (reader.Read())
            {
                int i = 0;
                InformovatDTO informovat = new InformovatDTO(reader.GetInt32(i),
                    reader.GetInt32(++i),
                    reader.GetInt32(++i));                        
                informovats.Add(informovat);
            }
            return informovats;
        }

        public int Delete(int idInformovat)
        {
            var db = Database.Instance;
            db.Connect();
            SqlCommand command = db.CreateCommand(SqlDelete);
            command.Parameters.AddWithValue("@idInformovat", idInformovat);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
    }
}
