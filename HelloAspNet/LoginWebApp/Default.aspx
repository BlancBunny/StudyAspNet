<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoginWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Main Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>회원관리</h1>
            <h2>메인페이지</h2>
            <asp:LoginView runat="server" ID="lgvDefault">
                <AnonymousTemplate>
                    <asp:LoginStatus ID="lgsLogin" runat="server" LoginText="로그인"/> &nbsp
                    <asp:HyperLink ID="lnkRegUser" runat="server" NavigateUrl="~/Register.aspx" Text="회원가입" />
                </AnonymousTemplate>
                <LoggedInTemplate>
                    <asp:LoginStatus ID="lgsLogout" runat="server" LogoutText="로그아웃" Visible="false" />
                    <a href="Logout.aspx">로그아웃</a> |
                    <asp:HyperLink NavigateUrl="~/UserInfo.aspx" runat="server" ID="lnkUserInfo">
                        <asp:loginname runat="server" ID="lgnUser"/>
                    </asp:HyperLink>
                </LoggedInTemplate>
            </asp:LoginView>
        </div>
    </form>
</body>
</html>
