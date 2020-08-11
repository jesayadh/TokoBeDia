<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Tokobedia.View.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Tokobedia&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CartButton" runat="server" Height="49px" OnClick="cartButtonClick" Text="Cart" Visible="False" Width="94px" />
            <asp:Button ID="ViewTransactionHistoryButton" runat="server" Height="49px" OnClick="ViewButtonClick" Text="View Transaction History" Visible="False" Width="159px" />
        </h1> 

        <p>Welcome,
            <asp:Label ID="LblName" runat="server" Text="Guest"></asp:Label>
        &nbsp;&nbsp; 
            <asp:Button ID="logButton" runat="server" Height="26px" OnClick="logButton_Click" Text="Login" Width="73px" />
        </p>
        <div>
            <asp:Button ID="viewProductButton" runat="server" Text="View Product" OnClick="viewProductButton_Click" />  <br /> <br />
            <asp:Button ID="viewProfileButton" runat="server" Text="View Profile" Visible="False" OnClick="viewProfileButton_Click" /> 
            

            <br />
            <asp:GridView ID="viewProductGrid" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="viewUserButton" runat="server" Text="View User" Visible="False" OnClick="viewUserButton_Click" />
            <br />
            <br />
            <asp:Button ID="insertProductButton" runat="server" Text="Insert Product" Visible="False" OnClick="insertProductButton_Click" />
            <br />
            <br />
            <asp:Button ID="updateProductButton" runat="server" Text="Update Product" Visible="False" OnClick="updateProductButton_Click" />
            <br />
            <br />
            <asp:Button ID="viewProductTypeButton" runat="server" Text="View Product Type" Visible="False" OnClick="viewProductTypeButton_Click" />
            <br />
            <br />
            <asp:Button ID="insertProductTypeButton" runat="server" Text="Insert Product Type" Visible="False" OnClick="insertProductTypeButton_Click" />
            <br />
            <br />
            <asp:Button ID="updateProductTypeButton" runat="server" Text="Update Product Type" Visible="False" OnClick="updateProductTypeButton_Click" />
            

            <br />
            <br />
            <asp:Button ID="viewPaymentTypeButton" runat="server" Text="View Payment Type" OnClick="viewPaymentTypeButton_Click" Visible="False" />
            

            <br />
            <br />
            <asp:Button ID="InsertPaymentTypeButton" runat="server" Text="Insert Payment Type" OnClick="InsertPaymentTypeButton_Click" Visible="False" />
            

            <br />
            <br />
            <asp:Button ID="UpdatePaymentTypeButton" runat="server" Text="Update Payment Type" OnClick="UpdatePaymentTypeButton_Click" Visible="False" />
            

        </div>

    </div>
    </form>
</body>
</html>
