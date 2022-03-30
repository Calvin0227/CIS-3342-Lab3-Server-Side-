using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

using System.Data;

using System.Data.SqlClient;

namespace Project_3
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        //Products objProducts = new Products();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
            }
        }

        protected void btnAddStrore_Click(object sender, EventArgs e)
        {
            Products objProducts;
            objProducts = new Products();
            objProducts.ADDNAME = txtStoreName.Text;
            objProducts.ADDSTATE = txtStoreState.Text;
            objProducts.ADDCITY = txtStoreCity.Text;
            objProducts.ADDADDRESS = txtStoreAddress.Text;
            objProducts.ADDZIP = int.Parse(txtStoreZip.Text);
            objProducts.ADDREVIEW = txtReview.Text;
            objProducts.ADDTYPE = txtRestaruanttype.Text;

            int myDS = AddingInfoToRestaruantTable(objProducts);


            if (myDS > 0) 
            { 
                lblError.Text = "Successfully Add Restaruant";
            }
            else 
            { 
                lblError.Text = "We Arealdy have this restaruant in recordes, if you are adding same restaruant different location, please add 1,2,3 behind Store name etc( store2)";
            }


        }

        public int AddingInfoToRestaruantTable(Products objProducts)
        {


            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "[AddRestaruantForReviewer]";

            SqlParameter inputParameter = new SqlParameter("@Addname", objProducts.ADDNAME);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Addstate", objProducts.ADDSTATE);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Addcity", objProducts.ADDCITY);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Addaddress", objProducts.ADDADDRESS);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Addzip", objProducts.ADDZIP);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 10;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Addtype", objProducts.ADDTYPE);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);
            int myDS = objDB.DoUpdateUsingCmdObj(objCommand);
            return myDS;
        }

        protected void btnBackToReviewerPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reviewers.aspx");
        }

        
      
    }
}