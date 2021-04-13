<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmInputValid.aspx.cs" Inherits="ValidationWebApp.FrmInputValid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:RangeValidator ErrorMessage="나이는 1~150사이의 정수입니다" ControlToValidate="txtAge"
                ID="valAge" MinimumValue="1" MaximumValue="150" 
                Type="Integer" runat="server" Display="Dynamic"/><br />
            <asp:TextBox ID="txtScore" runat="server" />
            <asp:RangeValidator ErrorMessage="학점은 A~F입니다" ControlToValidate="txtScore" runat="server" 
                ID="valScore" MinimumValue="A" MaximumValue="F" Type="String" 
                Display="Dynamic" SetFocusOnError="true"/> <br />
            <asp:TextBox runat="server" ID="txtUserID"/>
            <asp:RequiredFieldValidator ID="ValidUserID" ErrorMessage="아이디를 입력하세요." 
                ControlToValidate="txtUserID" ForeColor="Red" runat="server" Display="Dynamic"/> (필수) <br />
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"/>
            <asp:RequiredFieldValidator ID="ValidPassword" ErrorMessage="암호를 입력하세요." 
                ControlToValidate="txtPassword" ForeColor="Red" runat="server" Display="Dynamic" /> (필수) <br />
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="ValidConfirmPassword" ErrorMessage="암호확인을 입력하세요." 
                ControlToValidate="txtPassword" ForeColor="Red" runat="server" Display="Dynamic" /> (필수)
            
            <asp:CompareValidator ErrorMessage="암호가 일치하지 않습니다" runat="server" 
                ControlToCompare="txtConfirmPassword" ControlToValidate="txtPassword" Display="Dynamic"
                ForeColor="Red" /> <br />

            <asp:TextBox ID="txtEmail" runat="server" />
            <asp:RegularExpressionValidator ID="valEmail" runat="server" ControlToValidate="txtEmail"
                ErrorMessage="이메일을 정확히 입력하세요" Display="Dynamic" ForeColor="Red"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" /> <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="회원가입" />
            <asp:ValidationSummary runat="server" ID="valSummary" ShowMessageBox="true"
                ShowSummary="false" DisplayMode="BulletList"/>
        </div>

    </form>
</body>
</html>
