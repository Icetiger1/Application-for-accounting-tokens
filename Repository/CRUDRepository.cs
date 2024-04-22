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
        private T t;
        private readonly string connString = string.Empty;

        public CRUDRepository()
        {
            sqlConnection = new SqlConnection(connString);
        }

        public SqlDataReader GetAll()
        {
            SqlCommand sqlCommand = new SqlCommand(
                $"SELECT * FROM {t.GetType().Name};", 
                sqlConnection);
            SqlDataReader dataReader;

            using (sqlConnection)
            {
                sqlConnection.Open();
                dataReader = sqlCommand.ExecuteReader();

                dataReader.Close();
                CloseConnection();
                return dataReader;
            }
        }

        public SqlDataReader GetOne(T t)
        { 
            SqlCommand sqlCommand = new SqlCommand(
                $"SELECT * " +
                $"FROM  {t.GetType().Name} " +
                $"WHERE ID = '{GetId(t)}'", 
                sqlConnection);

            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                dataReader.Close();
                CloseConnection();
                return dataReader;
            }
        }

        public void Update(T t)
        {
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    $"UPDATE {t.GetType().Name} " +
                    $"WHERE ID = '{GetId(t)}';", 
                    sqlConnection);

                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void Write(T t)
        {
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    $"INSERT ...", 
                    sqlConnection);
                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void Delete(T t)
        {
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    $"DELETE {t.GetType().Name} " +
                    $"WHERE ID = '{GetId(t)}'", 
                    sqlConnection);

                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public int GetId(T t)
        {
            return Convert.ToInt32(t.GetType().GetProperty("Id").GetValue(t, null).ToString());
        }
    }
}
