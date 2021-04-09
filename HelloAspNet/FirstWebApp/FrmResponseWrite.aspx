<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmResponseWrite.aspx.cs" Inherits="FirstWebApp.FrmResponseWrite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnMsg" Text="Click" runat="server" OnClick="btnMsg_Click"/>
            <br />
            <%="또만나요<br />"%>
            <asp:Button ID="btnJS" Text="JS Greeting" runat="server" OnClick="btnJS_Click"/>
            <asp:LinkButton ID="btnLink" Text="네이버" runat="server" OnClick="btnLink_Click"/>
        </div>
    </form>
</body>
</html>
