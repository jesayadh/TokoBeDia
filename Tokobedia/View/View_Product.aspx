<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Product.aspx.cs" Inherits="Tokobedia.View.View_Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Tokobedia Product&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="homeButton" runat="server" Height="39px" OnClick="homeButton_Click" Text="Home" Width="78px" />
        </h1>
        <asp:Button ID="viewCart" runat="server" OnClick="Cart_Click" Text="Cart" />
        <asp:GridView ID="viewProductGrid" runat="server" OnRowDeleting="viewProductGrid_RowDeleting" OnRowUpdating="viewProductGrid_RowUpdating" OnSelectedIndexChanging="viewProductGrid_SelectedIndexChanging" OnRowEditing="viewProductGrid_RowEditing">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Buy" ShowHeader="True" Text="Add to Cart" />
                <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Update" ShowHeader="True" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Delete" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label>
        <br />
        <br />
        <asp:Button ID="insertProductButton" runat="server" OnClick="insertProductButton_Click" Text="Insert Product" />
        <br />
        <br />
        

    </div>
    </form>
</body>
</html>
