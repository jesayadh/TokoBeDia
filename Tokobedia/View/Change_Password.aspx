<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Change_Password.aspx.cs" Inherits="Tokobedia.View.Change_Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../change_password.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Change Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="homeButton" runat="server" Height="46px" OnClick="homeButton_Click" Text="Home" Width="109px" class ="homeButton"/>
        </h1>
        <br />
        <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label>
        <br />
        Old Password<br />
        <asp:TextBox ID="oldBox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        New Password<br />
        <asp:TextBox ID="newBox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        Confirm Password<br />
        <asp:TextBox ID="confirmBox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="changeButton" runat="server" OnClick="changeButton_Click" Text="Change Password" />
        <br />
    
    </div>
    </form>
</body>
</html>
