<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAppSession.aspx.cs" Inherits="FirstWebApp.FrmAppSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Application - Session 객체</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            현재 페이지가 모든 사용자에 의해 <asp:Label ID="lblApp" runat="server" /> 번 호출 되었습니다 <br />
            현재 페이지가 나에 의해 <asp:Label ID="lblSession" runat="server" /> 번 호출 되었습니다 <br />
            나의 고유 아이디 : <asp:Label ID="lblSessionID" runat="server" /><br />
            현재 세션 유지시간 : <asp:Label ID="lblTimeout" runat="server" /><br />
        </div>
    </form>
</body>
</html>
