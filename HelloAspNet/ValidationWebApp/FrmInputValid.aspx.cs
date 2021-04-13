using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationWebApp
{
    public partial class FrmInputValid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Page.SetFocus(txtUserID);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var strJs = "<script> alert('통과!')</script>";
                // Response.Write("<script>alert('통과!')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MyScript", strJs);
            }
        }
    }
}