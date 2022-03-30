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
    public partial class WebForm2 : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objcommand = new SqlCommand();
        ArrayList QualityList = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack) 
            {
                Button2.Visible = false;
                lblSearchResult.Visible = false;
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String SearchName = TextBox1.Text;
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "SearchFoodByName";

            SqlParameter inputparameter = new SqlParameter("SearchName", SearchName);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objcommand.Parameters.Add(inputparameter);

            SqlParameter output = new SqlParameter("return", 0);
            output.Direction = ParameterDirection.ReturnValue;
            objcommand.Parameters.Add(output);

            GridView1.DataSource = objDB.GetDataSetUsingCmdObj(objcommand);
            GridView1.DataBind();
            int result = int.Parse(output.Value.ToString());
            if (result < 0)
            {
                lblSearchResult.Visible = true;
                result = 0;
            }
            else
            {
                lblSearchResult.Visible = false;
            }
        }

        protected void btnAddRestaruant_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewRestaurantforReviewer.aspx");
        }

        public void UpdateIDBetweenTwoTable() 
        {

        }
        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "ShowAllRestaruant";
            GridView1.DataSource = objDB.GetDataSetUsingCmdObj(objcommand);
            GridView1.DataBind();
            GridView1.Visible = true;

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReviewElement objReview;
            objReview = new ReviewElement();
            objReview.ID = GridView1.SelectedRow.Cells[2].Text;
            AddingInfoIntoGVReview(objReview);
            Button2.Visible = true;
        }


        public int AddingInfoIntoGVReview(ReviewElement objReview)
        {
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "NameAndIDForReviewTable";

            SqlParameter inputparameter = new SqlParameter("@InputID", objReview.ID);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objcommand.Parameters.Add(inputparameter);

            gvReview.DataSource = objDB.GetDataSetUsingCmdObj(objcommand);
            gvReview.DataBind();
            return 0;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            RetrevingDetails();
        }

        public void RetrevingDetails() 
        {
            
            ReviewElement objReview;
            objReview = new ReviewElement();

            objReview.ID = gvReview.Rows[0].Cells[0].Text;

            objReview.NAME = gvReview.Rows[0].Cells[1].Text;

            TextBox tbReview;
            tbReview = (TextBox)gvReview.Rows[0].Cells[2].FindControl("TextBox2");
            objReview.REVIEW = tbReview.Text;

            CheckBoxList cblQuanlity;
            cblQuanlity = (CheckBoxList)gvReview.Rows[0].Cells[3].FindControl("CheckBoxList1");
            objReview.QUALITY = cblQuanlity.Text;

            CheckBoxList cblService;
            cblService = (CheckBoxList)gvReview.Rows[0].Cells[4].FindControl("CheckBoxList2");
            objReview.SERVICE = cblService.Text;

            CheckBoxList cblAtmosphere;
            cblAtmosphere = (CheckBoxList)gvReview.Rows[0].Cells[5].FindControl("CheckBoxList3");
            objReview.ATMOSPHERE = cblAtmosphere.Text;

            CheckBoxList cblPrice;
            cblPrice = (CheckBoxList)gvReview.Rows[0].Cells[6].FindControl("CheckBoxList4");
            objReview.PRICE = cblPrice.Text;

            int returnValue = AddingDetailsToReviewTable(objReview);

            if (returnValue > 0)
            {
                lblError.Text = "Wuhoo, new restaruant join!!!";
            }
            else 
            {
                lblError.Text = "We couldnt add this restaruant due to we arelady have it in system!";
            }
            Response.Redirect("Reviewers.aspx");

        }

        public int AddingDetailsToReviewTable(ReviewElement objReview)
        {
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "AddingDetailToReview";

            SqlParameter inputparameter = new SqlParameter("@InputID", int.Parse(objReview.ID));
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objcommand.Parameters.Add(inputparameter);

            SqlParameter inputParameter = new SqlParameter("@AddName", objReview.NAME);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objcommand.Parameters.Add(inputParameter);

            String YourID = Session["ID1"].ToString();
            inputParameter = new SqlParameter("@IDReviewer", int.Parse(YourID));
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 10;
            objcommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@AddReview", objReview.REVIEW);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objcommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@AddQuality", int.Parse(objReview.QUALITY));
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 10;
            objcommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@AddService", int.Parse(objReview.SERVICE));
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 10;
            objcommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@AddAtmosphere", int.Parse(objReview.ATMOSPHERE));
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 10;
            objcommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@AddPrice", int.Parse(objReview.PRICE));
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 10;
            objcommand.Parameters.Add(inputParameter);

            int myDS = objDB.DoUpdateUsingCmdObj(objcommand);
            return myDS;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            if (e.CommandName == "ViewAll") 
            {
                String ID = GridView1.Rows[rowIndex].Cells[2].Text;

                objcommand.CommandType = CommandType.StoredProcedure;
                objcommand.CommandText = "ShowAllReview";

                SqlParameter inputParameter = new SqlParameter("@ID", int.Parse(ID));
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Int;
                inputParameter.Size = 10;
                objcommand.Parameters.Add(inputParameter);
                gvDisplayAllReview.DataSource = objDB.GetDataSetUsingCmdObj(objcommand);
                gvDisplayAllReview.DataBind();
                double QualityAVG = CalQualityAVG();
                double ServiceAVG = CalServiceAVG();
                double AtmosphereAVG = CalAtmosphereAVG();
                double PriceAVG = CalPriceAVG();

                lblAVGResults.Text = "The Quality Average for This REstaruant is:  " + QualityAVG.ToString("N");
                lblAVGResults0.Text = "Service Average is: " + ServiceAVG.ToString("N");
                lblAVGResults1.Text = "Atmosphere Average is: " + AtmosphereAVG.ToString("N");
                lblAVGResults2.Text = "Price Average is:  " + PriceAVG.ToString("N");
            }
            
        }

        public double CalQualityAVG ()
        {
            for (int i = 0; i < gvDisplayAllReview.Rows.Count; i++)
            {
                QualityList.Add(int.Parse(gvDisplayAllReview.Rows[i].Cells[2].Text));

            }
            double total = 0;
            foreach (int i in QualityList) 
            {
                total = i + total;
            }
            int QualityCount = gvDisplayAllReview.Rows.Count;
            double QualityAVG = total / double.Parse(QualityCount.ToString());
            QualityList.Clear();
            return QualityAVG;
        }

        public double CalServiceAVG()
        {
            for (int i = 0; i < gvDisplayAllReview.Rows.Count; i++)
            {
                QualityList.Add(int.Parse(gvDisplayAllReview.Rows[i].Cells[3].Text));

            }
            double total = 0;
            foreach (int i in QualityList)
            {
                total = i + total;
            }
            int QualityCount = gvDisplayAllReview.Rows.Count;
            double ServiceAVG = total / double.Parse(QualityCount.ToString());
            QualityList.Clear();
            return ServiceAVG;
        }

        public double CalAtmosphereAVG()
        {
            for (int i = 0; i < gvDisplayAllReview.Rows.Count; i++)
            {
                QualityList.Add(int.Parse(gvDisplayAllReview.Rows[i].Cells[4].Text));

            }
            double total = 0;
            foreach (int i in QualityList)
            {
                total = i + total;
            }
            int QualityCount = gvDisplayAllReview.Rows.Count;
            double AtmosphereAVG = total / double.Parse(QualityCount.ToString());
            QualityList.Clear();
            return AtmosphereAVG;
        }

        public double CalPriceAVG()
        {
            for (int i = 0; i < gvDisplayAllReview.Rows.Count; i++)
            {
                QualityList.Add(int.Parse(gvDisplayAllReview.Rows[i].Cells[5].Text));

            }
            double total = 0;
            foreach (int i in QualityList)
            {
                total = i + total;
            }
            int QualityCount = gvDisplayAllReview.Rows.Count;
            double PriceAVG = total / double.Parse(QualityCount.ToString());
            QualityList.Clear();
            return PriceAVG;
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reviewers.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            RebindMyreviewTable();
        }

        public void RebindMyreviewTable() 
        {
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "SearchByReviewerID";

            String myID = Session["ID1"].ToString();
            SqlParameter inputparameter = new SqlParameter("@ReviewerID", int.Parse(myID));
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;
            objcommand.Parameters.Add(inputparameter);
            gvMyReview.DataSource = objDB.GetDataSetUsingCmdObj(objcommand);
            DataBind();
        }
        protected void gvMyReview_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMyReview.EditIndex = e.NewEditIndex;
            RebindMyreviewTable();

        }

        protected void gvMyReview_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String ID = gvMyReview.Rows[rowIndex].Cells[1].Text;
            TextBox tbchanging;
            tbchanging = (TextBox)gvMyReview.Rows[rowIndex].Cells[2].Controls[0];
            String Review = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvMyReview.Rows[rowIndex].Cells[3].Controls[0];
            String Quality = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvMyReview.Rows[rowIndex].Cells[4].Controls[0];
            String Service = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvMyReview.Rows[rowIndex].Cells[5].Controls[0];
            String Atmosphere = tbchanging.Text.ToString();

            tbchanging = (TextBox)gvMyReview.Rows[rowIndex].Cells[6].Controls[0];
            String Price = tbchanging.Text.ToString();

            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "UpdateReview";

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

            int result = objDB.DoUpdateUsingCmdObj(objcommand);
            gvMyReview.EditIndex = -1;
            DataBind();


        }

        protected void gvMyReview_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMyReview.EditIndex = -1;
            RebindMyreviewTable();
        }
    }
}