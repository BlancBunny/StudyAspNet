using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) txtNum.Text = "0"; // 최초 1회 초기화
        }

        // 이벤트 처리를 위해 페이지를 다시 로드함 (포스트백) 
        protected void btnInc_Click(object sender, EventArgs e)
        {
            txtNum.Text = $"{(int.Parse(txtNum.Text) + 1)}";
        }
        protected void btnDec_Click(object sender, EventArgs e)
        {
            txtNum.Text = $"{(int.Parse(txtNum.Text) - 1)}";
        }

        protected void btnLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.naver.com");
        }

        protected void btnImage_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}