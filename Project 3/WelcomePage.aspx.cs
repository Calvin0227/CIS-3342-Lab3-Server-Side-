using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Project_3
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objcommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                PopList();
            }
        }

        protected void btnSearchRestaruant_Click(object sender, EventArgs e)
        {
            SeachRestaruant();
        }

        public void SeachRestaruant() 
        {
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "SearchFoodByName";
            String ResName = txtRestaruantName.Text.ToString();
            SqlParameter inputparameter = new SqlParameter("@SearchName", ResName);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objcommand.Parameters.Add(inputparameter);
            gvRestaruantSearch.DataSource = objDB.GetDataSetUsingCmdObj(objcommand);
            gvRestaruantSearch.DataBind();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id;
            id = ddlStoreType.SelectedItem.Value.ToString();
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "UseTypeToSearchStore";

            SqlParameter inputparameter = new SqlParameter("@InputType", id);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objcommand.Parameters.Add(inputparameter);
            gvRestaruantSearch.DataSource = objDB.GetDataSetUsingCmdObj(objcommand);
            gvRestaruantSearch.DataBind();


        }
        public void PopList() 
        {
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "GetFoodType";
            ddlStoreType.DataSource = objDB.GetDataSetUsingCmdObj(objcommand);
            ddlStoreType.DataTextField = "StoreType";
            ddlStoreType.DataValueField = "StoreType";
            ddlStoreType.DataBind();

        }

        protected void btnLoginPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnMakeReservation_Click(object sender, EventArgs e)
        {
            try 
            {
                int YourID;
                YourID = int.Parse(gvRestaruantSearch.Rows[0].Cells[6].Text.ToString());
                Session["StoreID"] = YourID.ToString();
                Response.Redirect("ReservationPage.aspx");
            }
            catch 
            {
                //lbl show
            }
            
        }
    }
}