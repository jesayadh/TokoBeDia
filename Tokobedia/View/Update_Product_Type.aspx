<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_Product_Type.aspx.cs" Inherits="Tokobedia.View.Update_Product_Type" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Update Product Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="homeButton" runat="server" Height="41px" OnClick="homeButton_Click" Text="Home" Width="92px" />
        </h1>
        Current Product Type<asp:GridView ID="currentGrid" runat="server">
        </asp:GridView>
        <br />
        Product Type : <asp:TextBox ID="typeBox" runat="server"></asp:TextBox>
        <br />
        Description :
        <asp:TextBox ID="descriptionBox" runat="server"></asp:TextBox>
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
