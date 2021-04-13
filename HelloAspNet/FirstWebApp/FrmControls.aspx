<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmControls.aspx.cs" Inherits="FirstWebApp.FrmControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="ctrlHidden" runat="server"/>
            <asp:Button Text="히든필드값 출력" runat="server" ID="btnOk" OnClick="btnOk_Click"/><br />


            <asp:HyperLink NavigateUrl="https://www.microsoft.com" runat="server" 
                id="lnkMicrosoft" Text="Microsoft"/>
            <asp:Image ImageUrl="~/Images/ASP-NET-Banners-01.PNG" runat="server" ID="imgChange"/>
            <asp:Button Text="이미지 변경" runat="server"
                ID="btnChange" OnClick="btnChange_Click"/>
            <br />
            <table style="border:1px solid black;">
                <thead>
                    <tr>
                        <th>제목1</th>
                        <th>제목2</th>
                        <th>제목3</th>
                    </tr>
                </thead>
                <tr>
                    <td>글1</td>
                    <td>글2</td>
                    <td>글3</td>
                </tr>
                <tr>
                    <td>글4</td>
                    <td>글5</td>
                    <td>글6</td>
                </tr>
            </table>
            <br />
            <asp:DropDownList runat="server" ID="cboPhoneNum">
                <asp:ListItem Text="010" />
                <asp:ListItem>019</asp:ListItem>
                <asp:ListItem Value="018">018</asp:ListItem>
                <asp:ListItem Text="011" Value="011" />
            </asp:DropDownList>
            <asp:ListBox runat="server" ID="lsbHobby">
                <asp:ListItem Text="축구" />
                
            </asp:ListBox>
        </div>
    </form>
</body>
</html>
