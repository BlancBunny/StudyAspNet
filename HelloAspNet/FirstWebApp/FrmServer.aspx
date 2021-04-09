<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmServer.aspx.cs" Inherits="FirstWebApp.FrmServer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            웹폼의 물리경로 : <asp:Label ID="lblServerPath" runat="server" /><br />
            스크립트 루트경로 : <asp:Label ID="lblRequestPath" runat="server" /><br />
        </div>
    </form>
</body>
</html>
