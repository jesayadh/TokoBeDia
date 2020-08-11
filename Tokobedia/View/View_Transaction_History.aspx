<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Transaction_History.aspx.cs" Inherits="Tokobedia.View.View_Transaction_History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h1>View Transaction History&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="homeButton" runat="server" Height="49px" OnClick="homeButton_Click" Text="Home" Width="94px" />
         </h1>

        <asp:GridView ID="transactionHistoryGrid" runat="server">
         </asp:GridView>
         <br />
         SubTotal =
         <asp:Label ID="subTotalLbl" runat="server" Text="Rp xxx"></asp:Label>
         <br />
         <br />
         <asp:Button ID="transactionReportButton" runat="server" OnClick="transactionReportButton_Click" Text="Transaction Report" Visible="False" />
    </div>
    </form>
</body>
</html>
