<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="StateManagementApp.FrmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>로그인</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            아이디 : <asp:TextBox runat="server" ID="txtUserID"/><br />
            패스워드 : <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"/><br />
            <asp:CheckBox ID="chkSaveUserID" Checked="false" Text="아이디 저장" runat="server" /><br />
            <asp:Button Text="로그인" runat="server" ID="btnLogin" OnClick="btnLogin_Click"/>
        </div>
    </form>
</body>
</html>
