using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Repository
{
    internal interface ICRUDReporitory<T> where T : class 
    {
        int? GetId(T t);
        int? GetUserId(T t);
        SqlDataReader GetAll();
        SqlDataReader GetOne(T t);
        void Create(T t);
        void Update(T t);
        void Delete(T t);

    }
}
