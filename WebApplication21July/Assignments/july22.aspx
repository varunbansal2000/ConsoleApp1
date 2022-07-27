<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="july22.aspx.cs" Inherits="WebApplication21July.july22" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>    Assignment july 22</h1>
    <div class="container">

        <div class="form-group">
            <asp:Label runat="server">Emp Name</asp:Label>
            <asp:TextBox runat="server" ID="txtname" CssClass="form-control"></asp:TextBox> 
        </div>

        <div class="form-group">
            <asp:Label runat="server">States</asp:Label>
            <asp:DropDownList ID="StateList" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="StateList_SelectedIndexChanged"></asp:DropDownList>
        </div>

         <div class="form-group">
            <asp:Label runat="server">Cities</asp:Label>
            <asp:DropDownList ID="CityList" runat="server" AutoPostBack="True"  CssClass="form-control" OnSelectedIndexChanged="CityList_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <asp:Label ID="lbldata" runat="server" Text="The Data is: "></asp:Label>
    </div>

</asp:Content>
