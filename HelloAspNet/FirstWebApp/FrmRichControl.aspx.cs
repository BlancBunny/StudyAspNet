﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmRichControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calMain_SelectionChanged(object sender, EventArgs e)
        {
            Response.Write(calMain.SelectedDate.ToShortDateString() + "<hr />");
        }
    }
}