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
    public partial class WebForm3 : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objcommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            String YourID = Session["ID2"].ToString();
            //String myID = Session["ID1"].ToString();
        }

        protected void btnViewAllReview_Click(object sender, EventArgs e)
        {
            BindViewAllReviewTable();
            gvDisplayAllRestaruant.Visible = false;
            gvDisplayAllReview.Visible = true;
        }

        public void BindViewAllReviewTable() 
        {
            string strSQl = "SELECT * FROM StoreReview";
            gvDisplayAllReview.DataSource = objDB.GetDataSet(strSQl);
            gvDisplayAllReview.DataBind(); 
        }
        protected void gvDisplayAllReview_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvDisplayAllReview.EditIndex = e.NewEditIndex;
            BindViewAllReviewTable();
        }

        protected void gvDisplayAllReview_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String ID = gvDisplayAllReview.Rows[rowIndex].Cells[1].Text;
            TextBox tbchanging;

            tbchanging = (TextBox)gvDisplayAllReview.Rows[rowIndex].Cells[4].Controls[0];
            String Review = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvDisplayAllReview.Rows[rowIndex].Cells[5].Controls[0];
            String Quality = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvDisplayAllReview.Rows[rowIndex].Cells[6].Controls[0];
            String Service = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvDisplayAllReview.Rows[rowIndex].Cells[7].Controls[0];
            String Atmosphere = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvDisplayAllReview.Rows[rowIndex].Cells[8].Controls[0];
            String Price = tbchanging.Text.ToString();

            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "UpdateReviewForRepresentitve";

            SqlParameter inputparameter = new SqlParameter("@ReviewID", int.Parse(ID));
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updatereview", Review);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 100;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updatequality", int.Parse(Quality));
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updateservice", int.Parse(Service));
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updateatmosphere", int.Parse(Atmosphere));
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updateprice", int.Parse(Price));
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;
            objcommand.Parameters.Add(inputparameter);


            objDB.DoUpdateUsingCmdObj(objcommand);
            gvDisplayAllReview.EditIndex = -1;
            BindViewAllReviewTable();
            lblMessage.Text = "Succefully update!";
        }

        protected void gvDisplayAllReview_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvDisplayAllReview.EditIndex = -1;
            BindViewAllReviewTable();
        }

        protected void btnViewAllRestaruant_Click(object sender, EventArgs e)
        {
            //gvDisplayAllRestaruant
            RebindStoreInfoTable();
            gvDisplayAllRestaruant.Visible = true;
            gvDisplayAllReview.Visible = false;
        }

        public void RebindStoreInfoTable() 
        {
            string strSQl = "SELECT * FROM StoreInfo";
            gvDisplayAllRestaruant.DataSource = objDB.GetDataSet(strSQl);
            gvDisplayAllRestaruant.DataBind();
        }

        protected void gvDisplayAllRestaruant_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvDisplayAllRestaruant.EditIndex = e.NewEditIndex;
            RebindStoreInfoTable();
        }

        protected void gvDisplayAllRestaruant_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String ID = gvDisplayAllRestaruant.Rows[rowIndex].Cells[0].Text;
            TextBox tbchanging;

            tbchanging = (TextBox)gvDisplayAllRestaruant.Rows[rowIndex].Cells[1].Controls[0];
            String Store = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvDisplayAllRestaruant.Rows[rowIndex].Cells[2].Controls[0];
            String State = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvDisplayAllRestaruant.Rows[rowIndex].Cells[3].Controls[0];
            String City = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvDisplayAllRestaruant.Rows[rowIndex].Cells[4].Controls[0];
            String Address = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvDisplayAllRestaruant.Rows[rowIndex].Cells[5].Controls[0];
            String ZipCode = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvDisplayAllRestaruant.Rows[rowIndex].Cells[6].Controls[0];
            String StoreType = tbchanging.Text.ToString();

            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "UpdateStoreinfoForRepresentitive";

            SqlParameter inputparameter = new SqlParameter("@ReviewID", int.Parse(ID));
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updateStore", Store);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updateState", State);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updateCity", City);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updateAddress", Address);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updateZipcode", int.Parse(ZipCode));
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;
            objcommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@updateStoretype",StoreType);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objcommand.Parameters.Add(inputparameter);


            objDB.DoUpdateUsingCmdObj(objcommand);
            gvDisplayAllRestaruant.EditIndex = -1;
            RebindStoreInfoTable();
            lblMessage.Text = "Succefully update!";
        }

        protected void gvDisplayAllRestaruant_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvDisplayAllRestaruant.EditIndex = -1;
            RebindStoreInfoTable();
        }
    }
}