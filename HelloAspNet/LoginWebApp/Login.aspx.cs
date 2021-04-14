using LoginWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var repo = new Repository();
            if (repo.IscorrectUser(txtUserID.Text, txtPassword.Text))
            {
                // 성공 (인증 부여) 
                if (!string.IsNullOrEmpty(Request["ReturnUrl"]))
                {
                    FormsAuthentication.RedirectFromLoginPage(txtUserID.Text, false);
                }
                else
                {
                    FormsAuthentication.RedirectFromLoginPage(txtUserID.Text, false);
                    Response.Redirect("~/Welcome.aspx");
                }
            }
            else
            {
                // 실패 
                Page.ClientScript.RegisterStartupScript(this.GetType(), "showMsg",
                    "<script>alert('잘못된 사용자입니다.');</script>");
            }

        }
    }
}