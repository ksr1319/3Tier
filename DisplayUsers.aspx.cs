using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BussinessLogic;
using BussinessObject;
namespace _3TierAsp
{
    public partial class DisplayUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                GetData();
            }
        }
        private void GetData()
        {
           
            UserBL userbl = new UserBL();
            DataSet ds = userbl.GetData();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
                Label lblID = (Label)row.FindControl("Label1");
                Response.Redirect("~/UserRegistration.aspx?Id=" + lblID.Text);
            }
        }

        //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex]; 
        //    Label lblID = (Label)row.FindControl("lblID"); 

        //    Response.Redirect("~/UserRegistration.aspx"+bus);
   
        //}

       

       
    }
}