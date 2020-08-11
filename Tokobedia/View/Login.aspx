<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tokobedia.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>LOGIN</h1>
        <asp:Label ID="LblError" runat="server" Text="[Error Message]" ForeColor="Red" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="loginEmailBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="loginPasswordBox" runat="server" TextMode="Password"></asp:TextBox>
        
        <br />
        New Here?
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/View/Register.aspx">Register</asp:HyperLink>
        <br />
        <br />
        <asp:CheckBox ID="rememberMeCheck" runat="server" Text="Remember Me" />
        <br />
       
        <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
&nbsp;&nbsp;&nbsp;
    
        <br />
    
    </div>
    </form>
</body>
</html>
