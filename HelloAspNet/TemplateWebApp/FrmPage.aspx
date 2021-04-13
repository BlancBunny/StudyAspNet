<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmPage.aspx.cs" Inherits="TemplateWebApp.FrmPage" %>

<%@ Register Src="~/Catalog.ascx" TagPrefix="uc1" TagName="Catalog" %>
<%@ Register Src="~/Category.ascx" TagPrefix="uc1" TagName="Category" %>
<%@ Register Src="~/Copyright.ascx" TagPrefix="uc1" TagName="Copyright" %>
<%@ Register Src="~/Navigator.ascx" TagPrefix="uc1" TagName="Navigator" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>웹사이트 뼈대</title>
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css"/>
    <style>
        div {
            border: 1px solid red;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12" style="background-color: green">
                    <uc1:Navigator runat="server" ID="navMain" />
                </div>
            </div>
            <div class="row" style="height: 200px; ">
                <div class="col-md-4" style="background-color: antiquewhite">
                    <uc1:Category runat="server" ID="Category" />
                </div>
                <div class="col-md-8" style="background-color: aqua">
                    <uc1:Catalog runat="server" ID="Catalog" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12" style="background-color: burlywood">
                    <uc1:Copyright runat="server" ID="Copyright" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
