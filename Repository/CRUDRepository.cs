﻿using System;
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
                $"FROM  TOKENS " +
                $"WHERE ID = '{GetId(t)}'", 
                sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                dataReader.Close();
                CloseConnection();
                return dataReader;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(T t)
        {
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    $"UPDATE TOKENS " +
                    $"WHERE ID = '{GetId(t)}';", 
                    sqlConnection);

                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void Create(T t)
        {
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    $"INSERT INTO TOKENS", 
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
                    $"DELETE TOKENS " +
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
