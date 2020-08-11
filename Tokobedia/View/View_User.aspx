<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_User.aspx.cs" Inherits="Tokobedia.View.View_User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>User List&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="homeButton" runat="server" Height="42px" OnClick="homeButton_Click" Text="Home" Width="100px" />
        </h1>
        <asp:GridView ID="userGrid" runat="server" OnRowUpdating="userGrid_RowUpdating" OnRowEditing="userGrid_RowEditing">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Update Roles" ShowHeader="True" Text="Change Role" />
                <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Update Status" ShowHeader="True" Text="Change Status" />
            </Columns>
            
        </asp:GridView>
        <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
