<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmStateManagement.aspx.cs" Inherits="StateManagementApp.FrmStateManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
            <asp:Button Text="상태 변수에 데이터 저장" runat="server" 
                ID="btnSave" OnClick="btnSave_Click"/>&nbsp;
            <asp:Button Text="다시 게시" runat="server" ID="btnPostBack"/>
        </div>
    </form>
</body>
</html>
