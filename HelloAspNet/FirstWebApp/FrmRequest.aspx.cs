using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserId = "";
            string strPassword = string.Empty;
            string strName = "";
            string strAge = string.Empty;

            // [1] Request 객체의 QueryString 컬렉션 -> get 형식
            // strUserId = Request.QueryString["txtUserID"];
            strUserId = Request["txtUserID"];
            // [2] Request 객체의 Params 컬렉션 -> get/post
            strPassword = Request.Params["txtPassword"];
            // [3] Request 객체 의 Form 컬렉션 -> post 형식
            strName = Request.Form["txtName"];
            // [4] Request 객체 자체 -> get/post
            strAge = Request["txtAge"];

            string strMsg = string.Format($@"입력하신 아이디는 {strUserId}이고 <br />
                                             암호는 {strPassword}이고, <br />
                                             이름은 {strName}이고, <br /> 
                                             나이는 {strAge} 입니다.<br />");
            lblResult.Text = strMsg;
            lblIpAddress.Text = Request.UserHostAddress;
            Response.Write(strMsg);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt16(txtAge.Text);
        }
    }
}