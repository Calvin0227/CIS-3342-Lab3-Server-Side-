<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="Project_3.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 342px">
    
    <form id="form1" runat="server">
    
  
        <br />
        <br />
        You Can Either Select Restaruant Type or Search Restaruant Name<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:DropDownList ID="ddlStoreType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="z-index: 1; left: 208px; top: 194px; position: absolute; height: 69px; width: 227px">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 207px; top: 160px; position: absolute" Text="Select Restaruant by Type"></asp:Label>
        <br />
        <asp:TextBox ID="txtRestaruantName" runat="server" style="z-index: 1; left: 534px; top: 170px; position: absolute; height: 54px; width: 298px"></asp:TextBox>
        <asp:Button ID="btnLoginPage" runat="server" OnClick="btnLoginPage_Click" style="z-index: 1; left: 1245px; top: 177px; position: absolute; height: 42px; width: 154px" Text="Login Page" />
        <br />
        <asp:Button ID="btnSearchRestaruant" runat="server" OnClick="btnSearchRestaruant_Click" style="z-index: 1; left: 904px; top: 170px; position: absolute; height: 50px; width: 213px" Text="Search Restaruant" />
        <br />
        <br />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnMakeReservation" runat="server" OnClick="btnMakeReservation_Click" Text="Make a reservation on below restaruant" />
        </p>
        <asp:GridView ID="gvRestaruantSearch" runat="server">
        </asp:GridView>
    
  
        <br />
        <br />
    
  
        <br />
        <br />
        <br />
    
  
    </form>
    </body>
</html>
