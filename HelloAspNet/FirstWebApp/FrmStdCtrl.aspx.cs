using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmStdCtrl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
            btnHtml.Value = "HTML 서버 컨트롤 - 버튼";
            btnServer.Text = "표준 컨트롤 - 버튼";
        }

        protected void btnServer_Click(object sender, EventArgs e)
        {
            var result = $@"유저 아이디 : {txtUserID.Text} 
                            패스워드 : {txtPassword.Text} 
                            설명 : {txtDescription.Text}";

            Response.Write(result);
        }
    }
}