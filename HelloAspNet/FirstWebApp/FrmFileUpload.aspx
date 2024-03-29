﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmFileUpload.aspx.cs" Inherits="FirstWebApp.FrmFileUpload" %>
<%@ OutputCache Duration="60" VaryByParam="None" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="ctlFileUpload" runat="server" /><br />
            <asp:LinkButton ID="btnUpload" runat="server"
                OnClick="btnUpload_Click" Text="파일업로드" /><br />
            <asp:Label ID="lblResult" runat="server"/>
            <div>
                <asp:Label Text="text" runat="server" ID="lblCached"/><br />
                <asp:Substitution ID="sstMain" runat="server" MethodName="GetCurrentTime"/>
            </div>
            <div>
                <asp:Localize ID="lblLocal1" runat="server" Text="안녕하세요"></asp:Localize><br />
                <asp:Localize ID="lblLocal2" runat="server" 
                    Text="<hr /><b>안녕하세요</b>" Mode="Encode"></asp:Localize><br />
                <asp:Localize ID="lblLocal3" runat="server" 
                    Text="<hr /><b>안녕하세요</b>" Mode="Transform"></asp:Localize><br />
            </div>
        </div>
    </form>
</body>
</html>
