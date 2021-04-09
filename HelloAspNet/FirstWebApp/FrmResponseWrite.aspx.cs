using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmResponseWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("안녕하세요<br />");
        }

        protected void btnMsg_Click(object sender, EventArgs e)
        {
            Response.Write("<span style='color:blue;'>반갑습니다</span>");

        }

        protected void btnJS_Click(object sender, EventArgs e)
        {
            string str = @"<script language='javascript'>
                          window.alert('안녕하세요!');
                          </script>";
            Response.Write(str);
            
        }

        protected void btnLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.naver.com");
        }
    }
}