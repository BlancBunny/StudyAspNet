using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LoginWebApp.Models
{
    public class Repository
    {
        private SqlConnection conn;

        public Repository()
        {
            conn = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString
            };
        }

        internal bool IscorrectUser(string userID, string password)
        {
            bool result = false;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserID AND Password = @Password", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                result = true;
            }
            dr.Close();
            conn.Close();
            
            return result;
        }

        public int AddUser(String userID, string password)
        {
            SqlCommand cmd = new SqlCommand("WriteUsers", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.Parameters.AddWithValue("@Password", password);

            if (conn.State == ConnectionState.Closed) conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public User GetUserByUserId(string userID)
        {
            User user = new User();

            SqlCommand cmd = new SqlCommand("Select * From Users Where UserID = @UserID", conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@UserID", userID);

            if (conn.State == ConnectionState.Closed) conn.Open();
            IDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                user.UID = dr.GetInt32(0);
                user.UserID = dr.GetString(1);
                user.Password = dr.GetString(2);
            }
            conn.Close();

            return user;
        }
    }
}