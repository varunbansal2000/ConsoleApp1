<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employee25July.aspx.cs" Inherits="WebApplication21July.Assignments.Employee25July" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">

        <h1>Assignment 25th July Employee</h1>

        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Emp No"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="TextBoxEmpNo" runat="server" TextMode="Number" OnTextChanged="TextBoxEmpNo_TextChanged" AutoPostBack="true"></asp:TextBox>
            <asp:RequiredFieldValidator ValidationGroup="g1" ID="ValiddeptNo" ErrorMessage="Field Required!!" ControlToValidate="TextBoxEmpNo" runat="server"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeVaildatorDeptNo" runat="server" ErrorMessage="value should be greater than 0!!" ControlToValidate="TextBoxEmpNo" MinimumValue="1" MaximumValue="1000000" Type="Integer"></asp:RangeValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Emp Name"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="TextEmpName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValiddeptNo2" ErrorMessage="Field Required!!" ControlToValidate="TextEmpName" runat="server"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>
            <asp:DropDownList CssClass="form-control" ID="DropDownDepartment" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" InitialValue="Select" ErrorMessage="Field Required!!" ControlToValidate="DropDownDepartment" runat="server"></asp:RequiredFieldValidator>
        
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Designation"></asp:Label>
            <asp:TextBox  CssClass="form-control" ID="TextDesignation" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ErrorMessage="Field Required!!" ControlToValidate="TextDesignation" runat="server"></asp:RequiredFieldValidator>
        
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Salary"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="TextSalary" runat="server" TextMode="Number" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ErrorMessage="Field Required!!" ControlToValidate="TextSalary" runat="server"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="value should be greater than 0!!" ControlToValidate="TextSalary" MinimumValue="1" MaximumValue="100000000" Type="Integer"></asp:RangeValidator>
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
