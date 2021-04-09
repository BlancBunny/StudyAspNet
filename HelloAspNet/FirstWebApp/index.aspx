<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FirstWebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ASP.NET 웹페이지</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hello ASP.NET</h1>
        </div>
        <input type="text" name="txtOther" id="txtOther" runat="server"/><br />
        <asp:TextBox ID="txtClick" runat="server"></asp:TextBox>
        <asp:Button ID="btnClick" runat="server" Text="Button" OnClick="btnClick_Click" />
        <br />
        <asp:Label ID="lblResult" runat="server" Text="lblResult"></asp:Label>
    </form>
</body>
</html>
