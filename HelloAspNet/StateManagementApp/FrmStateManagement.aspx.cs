using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementApp
{
    public partial class FrmStateManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtApplication.Text = Application["Now"].ToString();
                txtSession.Text = Session["Now"].ToString();

                if (Cache["Now"] != null) txtCache.Text = Cache["Now"].ToString();
                if (Request.Cookies["Now"] != null) txtCookies.Text = Server.UrlDecode(Request.Cookies["Now"].Value);
                if (ViewState["Now"] != null) txtViewState.Text = ViewState["Now"].ToString();

            }
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            Application["Now"] = this.txtApplication.Text;
            Session["Now"] = this.txtSession.Text;
            Cache["Now"] = this.txtCache.Text;
            Response.Cookies["Now"].Value = Server.UrlEncode(txtCookies.Text);
            ViewState["Now"] = this.txtViewState.Text;
            Response.Redirect("FrmstateShow.aspx");
        }
    }
}