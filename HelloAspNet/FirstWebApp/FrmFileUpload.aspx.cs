using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCached.Text = DateTime.Now.ToLongTimeString();
        }

        public static string GetCurrentTime(HttpContext context)
        {
            return DateTime.Now.ToLongTimeString();
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (ctlFileUpload.HasFile)
            {
                ctlFileUpload.SaveAs(Server.MapPath(".") + "\\Files\\" + ctlFileUpload.FileName); // 저장
                lblResult.Text = string.Format("<a href='{0}{1}'>{1}</a>", "/Files/", 
                    Server.UrlEncode(ctlFileUpload.FileName));

            }
        }
    }
}

