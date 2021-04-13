using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementApp
{
    public partial class FrmStateShow : System.Web.UI.Page
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

                lblSiteName.Text = WebConfigurationManager.AppSettings["SITE_NAME"].ToString();
                lblConnectionString.Text = WebConfigurationManager.ConnectionStrings["Local_Connstring"].ConnectionString;
            }
        }
    }
}