using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public class Database
    {
        private static Database instance ;
        private static readonly object padlock = new object();
        private SqlConnection Connection { get; set; }
        private SqlTransaction SqlTransaction { get; set; }
        private static readonly String CONNECTION_STRING = "server=dbsys.cs.vsb.cz\\STUDENT;database=mar0720;user=mar0720;password=rpMT4QM7HU;";

        public Database()
        {
            Connection = new SqlConnection();
        }

        public static Database Instance
        {
            get
            {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Database();
                        }
                        return instance;
                    }           
            }
        }

        public bool Connect()
        {
            bool ret = true;
            if (Connection.State != ConnectionState.Open)
            {
                ret = Connect(CONNECTION_STRING);
            }
            return ret;
        }

        public bool Connect(string conString)
        {
            if (Connection.State != ConnectionState.Open)
            {
                Connection.ConnectionString = conString;
                Connection.Open();
            }
            return true;
        }

        public void Close()
        {
            Connection.Close();
        }

        public void BeginTransaction()
        {
            SqlTransaction = Connection.BeginTransaction(IsolationLevel.Serializable);
        }

        public void EndTransaction()
        {
            SqlTransaction.Commit();
            Close();
        }

        public void Rollback()
        {
            SqlTransaction.Rollback();
        }

        public SqlDataReader Select(SqlCommand command)
        {
            SqlDataReader sqlReader = command.ExecuteReader();
            return sqlReader;
        }

        public int ExecuteNonQuery(SqlCommand command)
        {
            var rownumber = command.ExecuteNonQuery();
            return rownumber;
        }

        public SqlCommand CreateCommand(string strCommand)
        {
            SqlCommand command = new SqlCommand(strCommand, Connection);
            if (SqlTransaction != null)
            {
                command.Transaction = SqlTransaction;
            }
            return command;
        }


    }
}
