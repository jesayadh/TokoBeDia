﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_Product.aspx.cs" Inherits="Tokobedia.View.Update_Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Update Product&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="homeButton" runat="server" Height="45px" OnClick="homeButton_Click" Text="Home" Width="109px" />
        </h1>
        Current Data
        <asp:GridView ID="currentGrid" runat="server">
        </asp:GridView>
        <br />
        Name&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        <br />
        Stock&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="stockBox" runat="server"></asp:TextBox>
        <br />
        Price&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="priceBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label>
        <br />
        <asp:Button ID="updateButton" runat="server" OnClick="updateButton_Click" Text="Update" />
        <br />
    
    </div>
    </form>
</body>
</html>
