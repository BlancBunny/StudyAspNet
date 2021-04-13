<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmButton.aspx.cs" Inherits="FirstWebApp.FrmButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txtNum"/>
            <asp:Button Text="증가" runat="server" ID="btnInc" OnClick="btnInc_Click"/>
            <asp:Button Text="감소" runat="server" ID="btnDec" OnClick="btnDec_Click"/>

            <asp:LinkButton Text="네이버" runat="server" ID="btnLink" OnClick="btnLink_Click"/>
            <asp:ImageButton ImageUrl="~/Images/btn_post.gif" runat="server" 
                ID ="btnImage" AlternateText="글쓰기" OnClick="btnImage_Click"/>
        </div>
    </form>
</body>
</html>
