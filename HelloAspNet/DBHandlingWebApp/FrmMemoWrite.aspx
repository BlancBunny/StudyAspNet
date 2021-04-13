<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMemoWrite.aspx.cs" Inherits="DBHandlingWebApp.FrmMemoWrite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Memo Write</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>메모 입력</h3>
            이름 : <asp:TextBox runat="server" ID="txtName"/><br />
            이메일 : <asp:TextBox runat="server" ID="txtEmail"/><br />
            메모 : <asp:TextBox runat="server" ID="txtTitle"/><br />

            
            <asp:Button Text="저장" runat="server" ID="btnWrite" OnClick="btnWrite_Click"/>&nbsp; <!--스페이스-->
            <asp:Button Text="리스트" runat="server" ID="btnList" OnClick="btnList_Click"/>
            <hr />
            <asp:Label Text="Result" runat="server" ID="lblResult"/>
        </div>
    </form>
</body>
</html>
