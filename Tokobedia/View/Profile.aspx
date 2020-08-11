<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Tokobedia.View.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Profile&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="homeButton" runat="server" Height="49px" OnClick="homeButton_Click" Text="Home" Width="94px" />
        </h1>
        Name&nbsp;&nbsp;&nbsp; :
        <asp:Label ID="nameLabel" runat="server" Text="[Your Name]"></asp:Label>
        <br />
        Email&nbsp;&nbsp;&nbsp; : <asp:Label ID="emailLabel" runat="server" Text="[Your Email]"></asp:Label>
        <br />
        Gender&nbsp; :
        <asp:Label ID="genderLabel" runat="server" Text="[Your Gender]"></asp:Label>
        <br />
        <br />
        <asp:Button ID="updateProfileButton" runat="server" OnClick="updateProfileButton_Click" Text="Update Profile" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="changePasswordButton" runat="server" OnClick="changePasswordButton_Click" Text="Change Password" />
        <br />
    
    </div>
    </form>
</body>
</html>
