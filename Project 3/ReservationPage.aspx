<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservationPage.aspx.cs" Inherits="Project_3.ReservationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        You Can Make Reservation Here<br />
        <br />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Please enter your name"></asp:Label>
        </p>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblnumber" runat="server" Text="Please enter your phone number"></asp:Label>
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
        <br />
        <br />
    </form>
</body>
</html>
