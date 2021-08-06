using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BussinessObject;
using BussinessLogic;

namespace _3TierAsp
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var Id = Request.QueryString["Id"];
                if (Convert.ToInt16(Id) > 0)
                {

                    GetDataById(Convert.ToInt16(Id));

                }
            }
         
        
        }

        public void GetDataById(int Id)
        {
            UserBL userbl = new UserBL();

            DataSet dataset = userbl.GetDataById(Id);
            txtname.Text = dataset.Tables[0].Rows[0]["Name"].ToString();
            DropDownList1.Text = dataset.Tables[0].Rows[0]["Address"].ToString();
            RadioButton1.Text = dataset.Tables[0].Rows[0]["Sex"].ToString();
            if (dataset.Tables[0].Rows[0]["Sex"].ToString() == "Male")
            {
                RadioButton1.Checked = true;
            }
            else
            {
                RadioButton2.Checked = true;
            }
            if(dataset.Tables[0].Rows[0]["cource"].ToString()==".Net")
            {
                CheckBox1.Checked = true;
            }
            if (dataset.Tables[0].Rows[0]["cource"].ToString() == "Java")
            {
                 CheckBox2.Checked = true;
            }
            if (dataset.Tables[0].Rows[0]["cource"].ToString() == "C++")
            {
                CheckBox3.Checked = true;
            }
            TextBox1.Text = dataset.Tables[0].Rows[0]["MobileNumber"].ToString();
            Label1.Text =Id.ToString();
            BtnSave.Text = "Update";
            
        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txtname.Text;
                        
            user.Address = DropDownList1.SelectedItem.ToString();
            user.Sex = "";
            if (RadioButton1.Checked == true)
            {
                user.Sex = RadioButton1.Text;
            }
            else
            {
                user.Sex = RadioButton2.Text;
            }
            user.Cource = "";
            if (CheckBox1.Checked == true)
            {
                user.Cource = CheckBox1.Text;
            }
            if (CheckBox2.Checked == true)
            {
                user.Cource = user.Cource + CheckBox2.Text;
            }
            if (CheckBox3.Checked == true)
            {
                user.Cource = user.Cource + CheckBox3.Text;
            }
            user.MobileNumber = TextBox1.Text;
            if(BtnSave.Text=="Update")
            {
                user.businessId =Convert.ToInt16(Label1.Text);
                UserBL userbL1 = new UserBL();
                userbL1.AddUserregisterBL(user);
        }

           
            UserBL userbL = new UserBL();
            userbL.AddUserregisterBL(user);
        }
        
        }
      
    }
