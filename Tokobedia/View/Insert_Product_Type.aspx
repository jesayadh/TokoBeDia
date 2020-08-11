<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_Product_Type.aspx.cs" Inherits="Tokobedia.View.Insert_Product_Type" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Insert Product Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="homeButton" runat="server" Height="39px" OnClick="homeButton_Click" Text="Home" Width="94px" />
        </h1>
        <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Product Type"></asp:Label>
&nbsp;:
        <asp:TextBox ID="inputTypeNameBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
&nbsp;&nbsp;&nbsp; :&nbsp;
        <asp:TextBox ID="inputDescriptionBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="insertButton" runat="server" OnClick="insertButton_Click" Text="Insert" />
        <br />
    
    </div>
    </form>
</body>
</html>
