<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
        <p>
            <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Phone Number"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtPhonenum" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="First time here? You can fill out the info and click here to register, then login"></asp:Label>
        </p>
        <p>
&nbsp;
            <asp:Button ID="btnReviewerLogin" runat="server" Text="Login As Reviewer" Width="148px" OnClick="btnLogin2_Click" />
&nbsp;<asp:Button ID="btnRepresentitiveLogin" runat="server" Text="Login As Representitve" Width="148px" OnClick="btnRepresentitiveLogin_Click1" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
