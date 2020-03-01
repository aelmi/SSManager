using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SSManager
{
    public static class DBHelper
    {
        public static string ServerName { get; set; }
        public static string DatabaseName { get; set; }

        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int Authentication { get; set; }

        public static string ConnectionString;
        public static SqlConnection con = new SqlConnection();

        //public DBHelper()
        //{
        //    ChangeConnectionString();
        //}


        public static void ChangeConnectionString()
        {
            if (con.State == ConnectionState.Open)
                con.Close();

            if (Authentication == 0)
                ConnectionString = "Server = " + ServerName + "; Database = " + DatabaseName + "; Trusted_Connection = True;";
            else if (Authentication == 1)
                ConnectionString = "Server=" + ServerName + ";Database=" + DatabaseName + ";User Id=" + Username + ";Password=" + Password + ";";
            con.ConnectionString = ConnectionString;
        }

        public static string Connect()
        {
            try
            {
                ChangeConnectionString();
                con.Open();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.Connection.State != System.Data.ConnectionState.Open)
                    cmd.Connection.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static DataTable ExecuteDT(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (da.SelectCommand.Connection.State != System.Data.ConnectionState.Open)
                    da.SelectCommand.Connection.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataSet ExecuteDS(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (da.SelectCommand.Connection.State != System.Data.ConnectionState.Open)
                    da.SelectCommand.Connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public static int ExecuteParameter(string query, SqlParameter[] param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.Connection.State != System.Data.ConnectionState.Open)
                    cmd.Connection.Open();
                for (int i = 0; i < param.Length; i++)
                    cmd.Parameters.AddWithValue(param[i].ParameterName, param[i].Value);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static int ExecuteStoredProcedure(string SP, SqlParameter[] param)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                if (cmd.Connection.State != System.Data.ConnectionState.Open)
                    cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SP;

                for (int i = 0; i < param.Length; i++)
                    cmd.Parameters.AddWithValue(param[i].ParameterName, param[i].Value);

                if (da.SelectCommand.Connection.State != System.Data.ConnectionState.Open)
                    da.SelectCommand.Connection.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

    }
}
