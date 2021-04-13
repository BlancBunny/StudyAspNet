using DBHandlingWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBHandlingWebApp
{
    public partial class FrmMemoWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            Memo memo = new Memo();
            memo.Name = txtName.Text;
            memo.Email = txtEmail.Text;
            memo.Title = txtTitle.Text;
            memo.PostDate = DateTime.Now;
            memo.PostIP = Request.UserHostAddress;

            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            using (var conn = new SqlConnection(connString))
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("WriteMemo", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@Name", memo.Name);
                    cmd.Parameters.AddWithValue("@Email", memo.Email);
                    cmd.Parameters.AddWithValue("@Title", memo.Title);
                    cmd.Parameters.AddWithValue("@PostDate", memo.PostDate);
                    cmd.Parameters.AddWithValue("@PostIP", memo.PostIP);

                    cmd.ExecuteNonQuery();

                    lblResult.Text = "저장되었습니다";
                }
                catch (Exception ex)
                {
                    lblResult.Text = $"예외 발생 : {ex.Message}";
                }
                
            }
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMemoList.aspx");
        }
    }
}