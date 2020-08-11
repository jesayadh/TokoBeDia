<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_Payment_Type.aspx.cs" Inherits="Tokobedia.View.Update_Payment_Type" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="PaymentGV">
    
       <h1>Update Payment Type </h1> <br />
        Current Payment Type<br />
        <asp:GridView ID="PaymentTGV" runat="server">
        </asp:GridView>
        <br />
        Payment Type:
        <asp:TextBox ID="PaymentTypeBox" runat="server"></asp:TextBox>
&nbsp;<br />
        <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red" Text="[Error message]"></asp:Label>
        <br />
        <asp:Button ID="S_Button" runat="server" OnClick="S_Button_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>