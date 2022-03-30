<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reviewers.aspx.cs" Inherits="Project_3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Search : Using keyword you enter to search restaruant&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Add Restaruant: will Lead you to new page to add restaruant&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Back To Main Page:&nbsp; will refresh this page<br />
        <br />
        Show All Restaruant : will show all the Restaruant&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Show All My Review: will enable edit mode for you to change your comment&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnShowAll" runat="server" OnClick="btnShowAll_Click" style="z-index: 1; left: 834px; top: 96px; position: absolute; height: 44px; width: 136px" Text="Show All Restaruant" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 427px; top: 109px; position: absolute; height: 14px; width: 273px">You Can Search Restaruant Here</asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 741px; top: 95px; position: absolute; height: 47px; width: 78px" Text="Search" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 1149px; top: 107px; position: absolute; height: 32px; width: 127px" Text="Show All My Review" />
        <br />
        <br />
        <br />
        <br />
            <asp:Label ID="lblSearchResult" runat="server">We Can Find Any Record, Please Use Add Restaruant Button To Add Restaruant</asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server"  Width="871px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand"  >
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="Review Adding" ShowSelectButton="True"  ></asp:CommandField >

                <asp:ButtonField ButtonType="Button" Text="View All Reviews" CommandName="ViewAll" />

            </Columns>
        </asp:GridView>
        <br />
        <p>
            <asp:GridView ID="gvMyReview" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gvMyReview_RowCancelingEdit" OnRowEditing="gvMyReview_RowEditing" OnRowUpdating="gvMyReview_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="StoreName" HeaderText="Store Name" ReadOnly="true"/>
                    <asp:BoundField DataField="ReviewID" HeaderText=" Review ID" ReadOnly="true" />
                    <asp:BoundField DataField="Review" HeaderText="Review" />
                    <asp:BoundField DataField="Quality" HeaderText="Quality" />
                    <asp:BoundField DataField="Service" HeaderText="Service" />
                    <asp:BoundField DataField="Atmosphere" HeaderText="Atmosphere" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:CommandField ButtonType="Button" HeaderText="Edit Product" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblAVG" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblAVGResults" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblAVGResults0" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblAVGResults1" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblAVGResults2" runat="server"></asp:Label>
        </p>
        <p>
            <asp:GridView ID="gvDisplayAllReview" runat="server"  >

            </asp:GridView>
        &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="gvReview" runat="server" AutoGenerateColumns="False"  Width="1291px">
                <Columns>
                    <asp:BoundField DataField="StoreID" HeaderText="Store ID" />
                    <asp:BoundField HeaderText="Restaruant Name" DataField="StoreName" />
                    <asp:TemplateField HeaderText="Review">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Food Quality">
                        <ItemTemplate>
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                                <asp:ListItem Value="1">1 Start</asp:ListItem>
                            <asp:ListItem Value="2">2 Start</asp:ListItem>
                            <asp:ListItem Value="3">3 Start</asp:ListItem>
                            <asp:ListItem Value="4">4 Start</asp:ListItem>
                            <asp:ListItem Value="5">5 Start</asp:ListItem>
                            </asp:CheckBoxList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Service">
                        <ItemTemplate>
                            <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                            <asp:ListItem Value="1">1 Start</asp:ListItem>
                            <asp:ListItem Value="2">2 Start</asp:ListItem>
                            <asp:ListItem Value="3">3 Start</asp:ListItem>
                            <asp:ListItem Value="4">4 Start</asp:ListItem>
                            <asp:ListItem Value="5">5 Start</asp:ListItem>
                            </asp:CheckBoxList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Atmosphere">
                        <ItemTemplate>
                            <asp:CheckBoxList ID="CheckBoxList3" runat="server">
                               <asp:ListItem Value="1">1 Start</asp:ListItem>
                            <asp:ListItem Value="2">2 Start</asp:ListItem>
                            <asp:ListItem Value="3">3 Start</asp:ListItem>
                            <asp:ListItem Value="4">4 Start</asp:ListItem>
                            <asp:ListItem Value="5">5 Start</asp:ListItem>
                            </asp:CheckBoxList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                            <asp:CheckBoxList ID="CheckBoxList4" runat="server">
                                <asp:ListItem Value="1">1 Start</asp:ListItem>
                            <asp:ListItem Value="2">2 Start</asp:ListItem>
                            <asp:ListItem Value="3">3 Start</asp:ListItem>
                            <asp:ListItem Value="4">4 Start</asp:ListItem>
                            <asp:ListItem Value="5">5 Start</asp:ListItem>
                            </asp:CheckBoxList>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" Height="54px" OnClick="Button2_Click" Text="Adding My Review To DataBase" Width="227px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAddRestaruant" runat="server" OnClick="btnAddRestaruant_Click" style="z-index: 1; left: 988px; top: 99px; position: absolute; height: 39px; width: 136px" Text="Add Restaruant" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


        <p>
            <asp:Button ID="btnRefresh" runat="server" OnClick="btnRefresh_Click" Text="Back To Main Page" />
        </p>


    </form>
    </body>
</html>
