<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Tokobedia.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>REGISTER</h1>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="registerEmailBox" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="emailLblError" runat="server" ForeColor="Red" Text="" Visible="true"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="registerNameBox" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="nameLblError" runat="server" ForeColor="Red" Text="" Visible="true"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="registerPasswordBox" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="passwordLblError" runat="server" ForeColor="Red" Text="" Visible="true"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="registerConfirmPasswordBox" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="confirmLblError" runat="server" ForeColor="Red" Text="" Visible="true"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="genderLblError" runat="server" ForeColor="Red" Text="" Visible="true"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButtonList ID="genderListRadioButton" runat="server" style="margin-bottom: 0px">
            <asp:ListItem Value="Male">Male</asp:ListItem>
            <asp:ListItem Value="Female">Female</asp:ListItem>
        </asp:RadioButtonList>
        Already have Account?
        <asp:HyperLink ID="loginHyperlinkButton" runat="server" NavigateUrl="~/View/Login.aspx">Login</asp:HyperLink>
        <br />
        <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" />
        <br />
        
        <br />
&nbsp;<br />
    
    </div>
    </form>
</body>
</html>
