<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginWebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>회원 관리 - 로그인</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>회원 관리</h1>
            <h2>로그인</h2>
            아이디 : <asp:TextBox runat="server" ID="txtUserID"/><br />
            암호 : <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"/><br />
            <asp:Button Text="로그인" runat="server" ID="btnLogin" OnClick="btnLogin_Click"/>


        </div>
    </form>
</body>
</html>
