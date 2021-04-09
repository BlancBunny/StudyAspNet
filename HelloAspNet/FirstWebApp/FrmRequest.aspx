<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRequest.aspx.cs" Inherits="FirstWebApp.FrmRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Request 개체</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            아이디 : <asp:TextBox ID="txtUserID" runat="server" /><br />
            암호 : <asp:TextBox ID="txtPassword" runat="server" /><br />
            이름 : <asp:TextBox ID="txtName" runat="server" /><br />
            나이 : <asp:TextBox ID="txtAge" runat="server" /><br /><br />
            <asp:Button ID="btnSubmit" Text="전송" runat="server" OnClick="btnSubmit_Click"/><br />
            <asp:Label ID="lblResult" runat="server" /><br />
            <asp:Label ID="lblIpAddress" runat="server" /><br />
        </div>
    </form>
</body>
</html>
