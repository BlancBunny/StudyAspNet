<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSqlDataSource.aspx.cs" Inherits="DataControlWebApp.FrmSqlDataSource" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Data Source Control</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList runat="server" ID="lstMemoName" DataSourceID="sdsMemoName" DataTextField="Name" DataValueField="Num"></asp:DropDownList>
            <asp:SqlDataSource runat="server" ID="sdsMemoName" ConnectionString="<%$ ConnectionStrings:ConnString %>" SelectCommand="SELECT [Num], [Name] FROM [Memos]"></asp:SqlDataSource>

        </div>
        <asp:Chart ID="Chart1" runat="server">
            <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
    </form>
</body>
</html>
