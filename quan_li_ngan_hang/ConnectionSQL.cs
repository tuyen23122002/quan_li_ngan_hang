using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace quan_li_ngan_hang
{
    internal class ConnectionSQL
    {
        #region Availible
        private SqlConnection conn;
        private SqlCommand _cmd;
        private string Strcon = null;
        private string _error;
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }
        #endregion
        #region Contrustor
        public ConnectionSQL()
        {
            Strcon = @"Data Source=LAPTOP-J7IC1MF0\SQLEXPRESS;Initial Catalog=Quan_li_ngan_hang_new;Integrated Security=True";
            conn = new SqlConnection(Strcon);

        }
        public bool OpenConn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

            }
            catch(Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public bool closeconn()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch(Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        
        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = conn;
            try
            {
                this.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(dt);

            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                this.closeconn();
            }
            return dt;
        }
        public bool SetData (string sql)
        {

            _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = conn;
            try
            {
                this.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            } catch(Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                this.closeconn();
            }
            return false;
        }
        #endregion
    }
}
