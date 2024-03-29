﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmResponseBuffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Response.Expires = -1; // 현재 페이지를 매번 새로 읽어옴 
            Response.Buffer = true; // 버퍼 사용
            Response.Write("[1] 현재 글이 보여짐");
            Response.Write("[3] 현재 글은?");
            Response.Flush(); // 버퍼에 있는 내용 출력 
            Response.Write("[4] 출력");
            Response.Clear(); // 버퍼에 있는 내용을 지움
            Response.Write("[5] 출력");
            Response.Flush();
        }

    }
}