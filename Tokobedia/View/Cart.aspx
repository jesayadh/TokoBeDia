<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Tokobedia.View.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h1>Cart</h1>
        <h1>Tokobedia Product&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="homeButton" runat="server" Height="39px" OnClick="homeButton_Click" Text="Home" Width="78px" />
        </h1>
        <asp:GridView ID="viewCartGrid" runat="server" OnRowDeleting="viewCartGrid_RowDeleting" OnRowUpdating="viewCartGrid_RowUpdating">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Update" ShowHeader="True" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Delete" />
            </Columns>
        </asp:GridView>
        <br />
        Grand Total = <asp:Label ID="LblGTotal" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        Choose Payment Type
        <asp:RadioButtonList ID="paymentRadioButton" runat="server">
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="CheckoutButton" runat="server" Text="Checkout" OnClick="CheckoutButton_Click" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
