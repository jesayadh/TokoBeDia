<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_Payment_Type.aspx.cs" Inherits="Tokobedia.View.Insert_Payment_Type" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Insert Payment Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="H_Button" runat="server" OnClick="H_Button_Click" Text="Home" />
        </h1>
        <p>
            <asp:Label ID="LabelError" runat="server" ForeColor="Red" Text="[LabelError]"></asp:Label>
        </p>
        <p>Payment Type ID : <asp:TextBox ID="IDBox" runat="server"></asp:TextBox>
        </p>
        <p>Payment Type :
            <asp:TextBox ID="TypeBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="S_Button" runat="server" OnClick="S_Button_Click" Text="Submit" />
        </p>
    </div>
    </form>
</body>
</html>
