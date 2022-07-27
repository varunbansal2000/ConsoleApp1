<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Department25July.aspx.cs" Inherits="WebApplication21July.Assignments.Department25July" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Assignment 25th July</h1>

    <div class="container">

        <div class="form-group form-group2">
            <asp:Label runat="server">Dept No.</asp:Label>
            <asp:TextBox runat="server" ID="deptNo" CssClass="form-control" OnTextChanged="deptNo_TextChanged" TextMode="Number" AutoPostBack="true" ></asp:TextBox> 
            <asp:RequiredFieldValidator ValidationGroup="g1" ID="ValiddeptNo" ErrorMessage="Field Required!!" ControlToValidate="deptNo" runat="server"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeVaildatorDeptNo" runat="server" ErrorMessage="value should be greater than 0!!" ControlToValidate="deptNo" MinimumValue="1" MaximumValue="1000000" Type="Integer"></asp:RangeValidator>
        </div>

        <div class="form-group">
            <asp:Label runat="server">Dept Name</asp:Label>
            <asp:TextBox runat="server" ID="deptName" CssClass="form-control"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ErrorMessage="Field Required!!" ControlToValidate="deptName" runat="server"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <asp:Label runat="server">Location</asp:Label>
            <asp:TextBox runat="server" ID="location" CssClass="form-control"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ErrorMessage="Field Required!!" ControlToValidate="location" runat="server"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <asp:Label runat="server">Capacity</asp:Label>
            <asp:TextBox runat="server" ID="capacity" CssClass="form-control" TextMode="Number"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ErrorMessage="Field Required!!" ControlToValidate="capacity" runat="server"></asp:RequiredFieldValidator>
             <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="value should be greater than 0!!" ControlToValidate="capacity" MinimumValue="1" MaximumValue="1000000" Type="Integer"></asp:RangeValidator>

        </div>
        <div class="form-group">
            <asp:Button ID="btnNew" runat="server" CausesValidation="false" Text="New" CssClass="btn btn-warning" 
                OnClick="btnNew_Click"/>
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" 
                OnClick="btnSave_Click"/>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" ValidationGroup="g1" CssClass="btn btn-danger" 
                OnClick="btnDelete_Click"/>
        </div>

    </div>

    <br/>
    <asp:Label ID="lblstatus" runat="server" Text=""></asp:Label>

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

</asp:Content>
