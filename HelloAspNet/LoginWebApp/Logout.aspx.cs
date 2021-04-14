﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginWebApp
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 로그아웃
            System.Web.Security.FormsAuthentication.SignOut();
            Response.Redirect("~/Default.aspx");
        }
    }
}