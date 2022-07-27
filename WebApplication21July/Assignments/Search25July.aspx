<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search25July.aspx.cs" Inherits="WebApplication21July.Assignments.Search25July" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Assignment 25th July Search</h1>

    <div class="container">
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>
            <asp:DropDownList OnSelectedIndexChanged="DropDownDepartment_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control" ID="DropDownDepartment" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" InitialValue="Select" ErrorMessage="Field Required!!" ControlToValidate="DropDownDepartment" runat="server"></asp:RequiredFieldValidator>

        </div>


        <br />
        <asp:Label ID="lblstatus" runat="server" Text=""></asp:Label>
        <hr />
        <hr />
        <asp:GridView ID="gvDept" runat="server" BackColor="White"
            BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3"
            GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </div>
</asp:Content>
