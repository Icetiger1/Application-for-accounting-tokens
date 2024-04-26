using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace WinFormsApp1.Repository
{
    public class CRUDRepository<T> : ICRUDReporitory<T> where T : class
    {
        private SqlConnection sqlConnection;
        private readonly string connString = string.Empty;

        public CRUDRepository()
        {
            sqlConnection = new SqlConnection(connString);
        }

        public SqlDataReader GetAll()
        {
            SqlCommand sqlCommand = new SqlCommand(
                $"SELECT * FROM TOKENS AS t" +
                $"JOIN USERS AS u" +
                $"ON t.USER_ID = u.ID;", 
                sqlConnection);

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                dataReader.Close();
                CloseConnection();
                return dataReader;
            }
            else
            {
                throw new Exception("Failed to connect to the SQL database.");
            }
        }

        public SqlDataReader GetOne(T t)
        {
            SqlCommand sqlCommand = new SqlCommand(
                $"SELECT * " +
                $"FROM  TOKENS " +
                $"WHERE ID = '{GetId(t)}'",
                sqlConnection);

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                dataReader.Close();
                CloseConnection();
                return dataReader;
            }
            else
            {
                throw new Exception("Failed to connect to the SQL database.");
            }
        }

        public void Update(T t)
        {
            SqlCommand sqlCommand = new SqlCommand(
                $"UPDATE TOKENS " +
                $"WHERE ID = '{GetId(t)}';",
                sqlConnection);
            sqlCommand.ExecuteNonQuery();

            SqlCommand sqlCommand2 = new SqlCommand(
                $"UPDATE USERS " +
                $"WHERE ID = '{GetUserId(t)}';",
                sqlConnection);

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
            else
            {
                throw new Exception("Failed to connect to the SQL database.");
            }
        }

        public void Create(T t)
        {
            SqlCommand sqlCommand = new SqlCommand(
                    $"INSERT INTO TOKENS...",
                    sqlConnection);

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
            else
            {
                throw new Exception("Failed to connect to the SQL database.");
            }
        }

        public void Delete(T t)
        {
            SqlCommand sqlCommand = new SqlCommand(
                $"DELETE TOKENS " +
                $"WHERE ID = '{GetId(t)}'",
                sqlConnection);

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
            else
            {
                throw new Exception("Failed to connect to the SQL database.");
            }
        }

        public void CloseConnection()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        public int? GetId(T t)
        {
            return Convert.ToInt32(t.GetType().GetProperty("Id").GetValue(t, null));
        }

        public int? GetUserId(T t)
        {
            return Convert.ToInt32(t.GetType().GetProperty("UserId").GetValue(t, null));
        }
    }
}
