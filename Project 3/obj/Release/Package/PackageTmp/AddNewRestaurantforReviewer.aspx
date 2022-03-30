<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewRestaurantforReviewer.aspx.cs" Inherits="Project_3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Store Name"></asp:Label>
        <br />
        <asp:TextBox ID="txtStoreName" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStoreAddress" runat="server" Text="Store Address"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtStoreAddress" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Store State"></asp:Label>
        <br />
        <asp:TextBox ID="txtStoreState" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Store City"></asp:Label>
        <br />
        <asp:TextBox ID="txtStoreCity" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Store Zip"></asp:Label>
        <br />
        <asp:TextBox ID="txtStoreZip" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblRestaruanttype" runat="server" Text="Restaruant Type"></asp:Label>
        <br />
        <asp:TextBox ID="txtRestaruanttype" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblReviewer" runat="server" Text="Reviewer"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtReview" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnAddStrore" runat="server" OnClick="btnAddStrore_Click" Text="Add Restaruant" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" ></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnBackToReviewerPage" runat="server" OnClick="btnBackToReviewerPage_Click" Text="Back To HomePage" />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
