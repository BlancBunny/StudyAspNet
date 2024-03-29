﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmPageLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 동적으로 페이지 제목 변경 (셋 다 가능)
            Title = "제목 변경";
            Page.Title = "제목이 출력됨";
            Page.Header.Title = "Page 클래스";

            // 외부 스타일시트 정의 
            HtmlLink objHtmlLink = new HtmlLink();
            objHtmlLink.Href = "DevASPNET.css";
            objHtmlLink.Attributes.Add("rel", "stylesheet");
            objHtmlLink.Attributes.Add("type", "text/css");

            // Head 태그 정의, 외부스타일과 메타태그 등록 
            HtmlHead objHtmlHead = Page.Header;
            objHtmlHead.Controls.Add(objHtmlLink);
            // 동적으로 페이지에 스타일시트 적용
            Style objButtonStyle = new Style();
            objButtonStyle.ForeColor = System.Drawing.Color.Navy;
            objButtonStyle.Font.Size = 9;
            objButtonStyle.Font.Name = "Verdana";
            Page.Header.StyleSheet.RegisterStyle(objButtonStyle, null);
            this.btnNewLoad.CssClass = objButtonStyle.RegisteredCssClass;
            this.btnPostBack.CssClass = objButtonStyle.RegisteredCssClass;

            Style objDivStyle = new Style();
            objDivStyle.ForeColor = System.Drawing.Color.Blue;
            objDivStyle.Font.Size = 9;
            objDivStyle.Font.Name = "Verdana";
            objDivStyle.Font.Italic = true;
            Page.Header.StyleSheet.CreateStyleRule(objDivStyle, null, "body, div");

            if (!Page.IsPostBack)
            {
                Response.Write("[1] 폼이 처음 로드될때 실행<br />");
            }
            else Response.Write("[2] 포스트백 됐을때 실행<br /> ");

            Response.Write("[3] 폼이 로드될때마다 실행 <br />");
        }

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            string strJs = @"
            <script>
            window.alert('PostBack!');
            </script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "MyScript", strJs);
        }

        protected void btnNewLoad_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmPageLoad.aspx");
        }
    }
}