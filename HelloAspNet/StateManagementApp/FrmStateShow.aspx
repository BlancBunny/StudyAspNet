<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmStateShow.aspx.cs" Inherits="StateManagementApp.FrmStateShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>저장 상태 보기</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>서버에 저장</h3>
            Application : <asp:TextBox runat="server" ID="txtApplication"/><br />
            Session : <asp:TextBox runat="server" ID="txtSession"/><br />
            Cache : <asp:TextBox runat="server" ID="txtCache"/><br />

            <h3>클라이언트에 저장</h3>
            Cookies : <asp:TextBox runat="server" ID="txtCookies"/><br />
            Viewstate : <asp:TextBox runat="server" ID="txtViewState"/><br />

            <hr />
            <asp:Label Text="text" runat="server" ID="lblSiteName"/><br />
            <asp:Label Text="text" runat="server" ID="lblConnectionString"/><br />

        </div>
    </form>
</body>
</html>
