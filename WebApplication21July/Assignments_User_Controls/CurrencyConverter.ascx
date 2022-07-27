<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.ascx.cs" Inherits="WebApplication21July.Assignments_User_Controls.CurrencyConverter" %>


<h1>Currency Converter</h1>
<br />

<asp:Label ID="lblstatus" runat="server" Text=""></asp:Label>


<table class="table table-bordered table-striped table-dark">

    <tr>

        <td>
            <asp:TextBox TextMode="Number" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged" ID="TextBox1" runat="server"></asp:TextBox>
        </td>

        <td>
            <asp:DropDownList OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" ID="DropDownList1" runat="server">
                <asp:ListItem Value="21.73" Text="AED"></asp:ListItem>
                <asp:ListItem Value="80.96" Text="EUR"></asp:ListItem>
                <asp:ListItem Value="1.00" Text="INR"></asp:ListItem>
                <asp:ListItem Value="79.80" Text="USD"></asp:ListItem>


            </asp:DropDownList>
        </td>

    </tr>

    <tr>

        <td>
            <asp:TextBox TextMode="Number" AutoPostBack="true"  OnTextChanged="TextBox2_TextChanged" ID="TextBox2" runat="server"></asp:TextBox>
        </td>

        <td>
            <asp:DropDownList OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="true" ID="DropDownList2" runat="server">
                <asp:ListItem Value="21.73" Text="AED"></asp:ListItem>
                <asp:ListItem Value="80.96" Text="EUR"></asp:ListItem>
                <asp:ListItem Value="1.00" Text="INR"></asp:ListItem>
                <asp:ListItem Value="79.80" Text="USD"></asp:ListItem>


            </asp:DropDownList>
        </td>

    </tr>

</table>
