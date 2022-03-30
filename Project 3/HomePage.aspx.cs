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
    public partial class WebForm1 : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                
            }
        }


        protected void btnLogin2_Click(object sender, EventArgs e) //reviewer
        {
            String Role = "Reviewer";
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAccountsForReviewer";
            objCommand.Parameters.AddWithValue("@Phone", txtPhonenum.Text);
            objCommand.Parameters.AddWithValue("@Role", Role);

            SqlParameter returnparameter = new SqlParameter("Return", 0);
            returnparameter.Direction = ParameterDirection.ReturnValue;
            objCommand.Parameters.Add(returnparameter);
            

            SqlParameter outputparameter = new SqlParameter("@ID", 0);
            outputparameter.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputparameter);

            objDB.GetDataSetUsingCmdObj(objCommand);

            string YourID = outputparameter.Value.ToString();
            int result = int.Parse(returnparameter.Value.ToString());

            
            if (result >= 0 )
            {
                Session["ID1"] = YourID;
                GridView1.Visible = false;
                Response.Redirect("Reviewers.aspx");
            }
            else
            {
                lblError.Text = "We Dont Have Your Info";
            }
        }

        protected void btnRepresentitiveLogin_Click1(object sender, EventArgs e) // representitive
        {
            String Role = "Representitive";
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAccountsForReviewer";
            objCommand.Parameters.AddWithValue("@Phone", txtPhonenum.Text);
            objCommand.Parameters.AddWithValue("@Role", Role);

            SqlParameter returnparameter = new SqlParameter("Return", 0);
            returnparameter.Direction = ParameterDirection.ReturnValue;
            objCommand.Parameters.Add(returnparameter);
            

            SqlParameter outputparameter = new SqlParameter("@ID", 0);
            outputparameter.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputparameter);
            objDB.GetDataSetUsingCmdObj(objCommand);
            string YourID = outputparameter.Value.ToString();
            int result = int.Parse(returnparameter.Value.ToString());

            if (result >= 0)
            {
                Session["ID2"] = YourID;
                GridView1.Visible = false;
                Response.Redirect("Representative.aspx");
            }
            else
            {
                lblError.Text = "We Dont Have Your Info";
            }
        }

    }
}