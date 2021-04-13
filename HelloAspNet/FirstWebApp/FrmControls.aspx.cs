using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lsbHobby.Items.Add("농구");
            lsbHobby.Items.Add("배구");

            cboPhoneNum.Items.Add("017");
            if (!Page.IsPostBack) ctrlHidden.Value = DateTime.Now.ToShortTimeString();
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            imgChange.ImageUrl = "~/Images/ASP-NET-Banners-02.PNG";
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            Response.Write(ctrlHidden.Value);
        }
    }
}