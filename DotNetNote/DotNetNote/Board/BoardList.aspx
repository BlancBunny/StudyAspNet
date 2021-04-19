<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BoardList.aspx.cs" Inherits="DotNetNote.Board.BoardList" %>

<%@ Register Src="~/Controls/PagingControl.ascx" 
    TagPrefix="uc1" TagName="PagingControl" %>
<%@ Register Src="~/Controls/SearchControl.ascx" 
    TagPrefix="uc1" TagName="SearchControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 class="text-center">게시판</h3>
    <span>글 목록 - 완성형 게시판</span>
    <hr />
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <asp:Literal ID="lblTotalRecord" runat="server" />
                <asp:GridView ID="grvNotes" runat="server" AutoGenerateColumns="false"
                    DataKeyNames="Id" CssClass="table table-bordered table-hover table-striped table-responsive">
                    <Columns>
                        <asp:TemplateField HeaderText="번호"
                                           HeaderStyle-Width="50px"
                                           ItemStyle-HorizontalAlign="Right">
                            <ItemTemplate>
                                <%# Eval("Id") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="제목"
                                           HeaderStyle-Width="410px"
                                           ItemStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                <%# Helper.BoardLibrary.FuncStep(Eval("Step")) %>
                                <asp:HyperLink runat="server" ID="lnkTitle"  
                                    NavigateUrl='<%# "BoardView.aspx?Id=" + Eval("Id") %>' >
                                    <%# Helper.StringLibrary.CutStringUnicode(Eval("Title").ToString(), 30) %>
                                </asp:HyperLink>
                                <%# Helper.BoardLibrary.FuncNew(Eval("PostDate")) %>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="파일"
                            HeaderStyle-Width="70px"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%# Helper.BoardLibrary.FuncFileDownSingle(
                                    Convert.ToInt32(Eval("Id")), 
                                    Eval("FileName").ToString(), 
                                    Eval("FileSize").ToString()) %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Name" HeaderText="작성자"
                            HeaderStyle-Width="60px" ItemStyle-HorizontalAlign="Center" />
                        <asp:TemplateField HeaderText="작성일"
                            ItemStyle-Width="90px"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%# Helper.BoardLibrary.FuncShowTime(Eval("PostDate")) %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="ReadCount" HeaderText="조회수"
                            ItemStyle-HorizontalAlign="Right" HeaderStyle-Width="60px"/>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

    
    <div class="container">
        <div class="row">
            <div class="col">
                <div class="text-center">
                    <uc1:PagingControl runat="server" />
                </div>
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col">
                <div class="text-right">
                    <a href="BoardWrite.aspx" class="btn btn-primary">글쓰기</a>
                </div>
            </div>
        </div>
    </div>
    <uc1:SearchControl runat="server"
        ID="BoardSearchFormSingleControl" />
</asp:Content>
