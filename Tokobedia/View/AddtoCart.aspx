<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddtoCart.aspx.cs" Inherits="Tokobedia.View.AddtoCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Add to Cart&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="homeButton" runat="server" Height="45px" OnClick="homeButton_Click" Text="Home" Width="109px" />
        </h1>
        <asp:GridView ID="currentGrid" runat="server">
        </asp:GridView>
        <br />
        Quantity&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="quantityBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtnInsertCart" runat="server" Text="Add to Cart" OnClick="BtnInsertCart_Click" />
        <br />
        <asp:Label ID="QuantityError" runat="server" ForeColor="Red" Text="" Visible="true"></asp:Label>
    </div>
    </form>
</body>
</html>
