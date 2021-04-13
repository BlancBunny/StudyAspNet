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
    public partial class FrmDBConn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConn_Click(object sender, EventArgs e)
        {
            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                    // lblResult.Text = conn.State.ToString();
                    var query = @"Insert Memos 
                                    Values
                                    (	
	                                    N'김현수2', N'nhsk0767@gmail.com', N'김현수입니다.'
	                                    , GetDate(), '127.0.0.1'
                                    )";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    lblResult.Text = "데이터 저장완료";
                }
                catch (Exception ex)
                {
                    lblResult.Text = $"오류 발생 : {ex.Message}";
                }
            }
        }
    }
}