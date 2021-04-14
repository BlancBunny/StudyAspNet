<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LoginWebApp.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>회원 관리 - 회원 가입</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>회원 관리</h1>
            <h2>회원 가입</h2>
            아이디 : <asp:TextBox runat="server" ID="txtUserID"/><br />
            암호 : <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"/><br />
            <asp:Button Text="회원가입" runat="server" ID="btnRegister" OnClick="btnRegister_Click"/>


        </div>
    </form>
</body>
</html>
