<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmStdCtrl.aspx.cs" Inherits="FirstWebApp.FrmStdCtrl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- ID, name 속성은 둘다 개체 식별자의 역할을 수행하지만 차이점이 있다.
                1. ID는 해당 페이지에서 유일해야 하지만 name은 중복 지정이 가능하다 
                2. name은 checkbox나 radiobutton 에서 중복으로 주는 경우가 많다.
                3. 한 컨트롤이 ID와 name 속성을 모두 가지면 name 값이 우선권을 가진다. 
                -->
            <h1>표준 컨트롤 (Standard Control)</h1>

            
            <asp:TextBox runat="server" ID="txtUserID" TextMode ="SingleLine"/><br />
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"/><br />
            <asp:TextBox runat="server" ID="txtDescription" TextMode="MultiLine"/><br />
            <asp:Label Text="Sample" runat="server" ID="lblDateTime"/><br />

            <h2>[1] 순수 HTML로 버튼 만들기</h2>
            <input type="button" id="btnInput" value="버튼-HTML" />      

            <h2>[2] runat 속성을 추가해서 서버 컨트롤 버튼 만들기</h2>
            <input type="button" id="btnHtml" value="버튼-runat" runat="server" />

            <h2>[3] ASP.NET 표준 컨트롤을 사용해서 버튼 만들기</h2>
            <asp:Button Text="버튼-ASP.NET" runat="server" ID="btnServer" OnClick="btnServer_Click"/>
        </div>
    </form>
</body>
</html>
