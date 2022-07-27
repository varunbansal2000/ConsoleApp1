<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CurrencyConverterContainer.aspx.cs" Inherits="WebApplication21July.Assignments_User_Controls.CurrencyConverterContainer" %>

<%@ Register Src="~/Assignments_User_Controls/CurrencyConverter.ascx" TagPrefix="uc1" TagName="CurrencyConverter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:CurrencyConverter runat="server" ID="CurrencyConverter" />


</asp:Content>
