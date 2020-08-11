<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_Product.aspx.cs" Inherits="Tokobedia.View.Insert_Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Insert Product&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="homeButton" runat="server" Height="54px" OnClick="homeButton_Click" Text="Home" Width="103px" />
        </h1>
        <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Stock"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="stockBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="priceBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Product Type ID"></asp:Label>
&nbsp;&nbsp; :
        <asp:TextBox ID="productTypeIDBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="insertButton" runat="server" OnClick="insertButton_Click" Text="Insert" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
