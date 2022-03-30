<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Representative.aspx.cs" Inherits="Project_3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnViewAllReview" runat="server" OnClick="btnViewAllReview_Click" Text="View All Review Records" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnViewAllRestaruant" runat="server" OnClick="btnViewAllRestaruant_Click" Text="View All Restaruant" />
        </p>
        <asp:GridView ID="gvDisplayAllReview" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gvDisplayAllReview_RowCancelingEdit" OnRowEditing="gvDisplayAllReview_RowEditing" OnRowUpdating="gvDisplayAllReview_RowUpdating">
            <Columns>
                <asp:BoundField DataField="StoreID" HeaderText="Store ID" ReadOnly="true" />
                <asp:BoundField DataField="ReviewID" HeaderText="Review ID" ReadOnly="true"/>
                <asp:BoundField DataField="ReviewerID" HeaderText="Reviewer ID" ReadOnly="true"/>
                <asp:BoundField DataField="StoreName" HeaderText="Store Name" />
                <asp:BoundField DataField="Review" HeaderText="Review" />
                <asp:BoundField DataField="Quality" HeaderText="Quality" />
                <asp:BoundField DataField="Service" HeaderText="Service" />
                <asp:BoundField DataField="Atmosphere" HeaderText="Atmosphere" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="gvDisplayAllRestaruant" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gvDisplayAllRestaruant_RowCancelingEdit" OnRowEditing="gvDisplayAllRestaruant_RowEditing" OnRowUpdating="gvDisplayAllRestaruant_RowUpdating" >
            <Columns>
                <asp:BoundField DataField="StoreID" HeaderText="Store ID" ReadOnly="true"/>
                <asp:BoundField DataField="StoreName" HeaderText="Store Name" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="ZipCode" HeaderText="Zip Code" />
                <asp:BoundField DataField="StoreType" HeaderText="Store Type" />
                <asp:CommandField ButtonType="Button" HeaderText="Edit Restaruant" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
