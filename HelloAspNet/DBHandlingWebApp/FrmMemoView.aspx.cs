﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBHandlingWebApp
{
    public partial class FrmMemoView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request["Num"]))
            {
                Response.Write("잘못된 요청입니다");
                Response.End();
            }
            else
            {
                var strConn = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
                using (var conn = new SqlConnection(strConn))
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand("ViewMemo", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Num", Convert.ToInt32(Request["Num"]));

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblNum.Text = Request["Num"];
                        lblName.Text = reader["Name"].ToString();
                        lblEmail.Text = reader["Email"].ToString();
                        lblTitle.Text = reader["Title"].ToString();
                        lblPostDate.Text = reader["PostDate"].ToString();
                        lblPostIP.Text = reader["PostIP"].ToString();
                    }
                    reader.Close();
                }
            }
        }
    }
}