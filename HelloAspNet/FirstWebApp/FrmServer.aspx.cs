﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblServerPath.Text = Server.MapPath("."); // 페이지 경로
            lblRequestPath.Text = Request.ServerVariables["SCRIPT_NAME"]; // URL
        }
    }
}