<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDBConn.aspx.cs" Inherits="DBHandlingWebApp.FrmDBConn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>DB 연결 확인</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="연결 확인" runat="server" ID="lblResult"/>
            <asp:Button Text="DB 연결" runat="server" ID="btnConn" OnClick="btnConn_Click"/>
        </div>
    </form>
</body>
</html>
