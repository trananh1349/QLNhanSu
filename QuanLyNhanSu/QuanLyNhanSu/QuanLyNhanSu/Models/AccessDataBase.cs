using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Models
{
    class AccessDataBase
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        //private static string strConnString = "Data Source=DESKTOP-PGQHHD3\\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        private static string strConnString = "Data Source=DESKTOP-8V08BMC\\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public int executeQuery(SqlCommand dbCommend)
        {
            try
            {
                if (connection.State == 0)
                    createConn();
                dbCommend.Connection = connection;
                dbCommend.CommandType = CommandType.Text;
                return dbCommend.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public object executeSelectQuery(SqlCommand dbCommend)
        {
            try
            {
                if (connection.State == 0)
                    createConn();
                dbCommend.Connection = connection;
                dbCommend.CommandType = CommandType.Text;
                return dbCommend.ExecuteScalar();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    createConn();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
