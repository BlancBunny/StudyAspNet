<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMemoList.aspx.cs" Inherits="DBHandlingWebApp.FrmMemoList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>메모리스트</h3>
            <asp:DropDownList runat="server" ID="cboSearch">
                <asp:ListItem Text="이름" Value="Name" Selected="True"/>
                <asp:ListItem Text="메모" Value="Title"/>
            </asp:DropDownList>
            <asp:TextBox runat="server" ID="txtSearch"/>
            <asp:Button Text="검색" runat="server" ID="btnSearch" OnClick="btnSearch_Click"/>

            <asp:GridView runat="server" ID="grvMemoList"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="번호" DataField="Num"/>
                    <asp:BoundField HeaderText="작성자" DataField="Name"/>
                    <asp:HyperLinkField HeaderText="메모" DataTextField="Title" 
                        DataNavigateUrlFormatString="FrmMemoView.aspx?Num={0}" 
                        DataNavigateUrlFields="Num"/>
                    <asp:BoundField HeaderText="이메일" DataField="Email" />
                    <asp:TemplateField HeaderText="작성일">
                        <ItemTemplate>
                            <%# Eval("PostDate") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="접속 IP" DataField="PostIP" />
                </Columns>
            </asp:GridView>
            <hr />
            <asp:HyperLink NavigateUrl="~/FrmMemoWrite.aspx" runat="server" 
                ID="lnkMemoList" Text="글쓰기"/>
        </div>
    </form>
</body>
</html>
