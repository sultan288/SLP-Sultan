using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealProjectB1.auth
{
    public partial class regirter : System.Web.UI.Page
    {
        string ConnectionStr = @"Data Source=DESKTOP-H1OGKJ6;Initial Catalog=DotNetB1;Integrated Security=True ";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                divMsg.Visible = false;
            }
        }
        private bool CheckFieldValue()
        {
            bool IsReq = false;

            if (txtUserName.Text == "")
            {
                IsReq = true;
                lblMsg.Text = "Username can't be empty";

            }
            else if (txtFirstName.Text == "")
            {
                IsReq = true;
                lblMsg.Text = "Password can't be empty";
            }
            else if (ddlGender.SelectedValue == "0")
            {
                IsReq = true;
                lblMsg.Text = "Gender Can't be empty!";
            }
            else if (ddlReligion.SelectedValue == "0")
            {
                IsReq = true;
                lblMsg.Text = "Religion Can't be empty!";
            }
            if (IsReq == true)
            {
                divMsg.Visible = true;
            }
            else
            {
                divMsg.Visible = false;
            }

            return IsReq;
        }

        private void ClearFieldValue()
        {
            txtUserName.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtDateOfBirth.Text = "";
            ddlGender.SelectedValue="0";
            txtContactNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            ddlReligion.SelectedValue = "0";
            fuUserImage.PostedFile.InputStream.Dispose();
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (CheckFieldValue()==false)
            {
                int savests = SaveReg();
                if (savests > 0)
                {
                    ClearFieldValue();
                    divMsg.Visible = true;
                    lblMsg.Text = "Save Done";
                }
                else
                {
                    divMsg.Visible = true;
                    lblMsg.Text = "Save Filed";
                }
            }
          
        }

        private int SaveReg()
        {
            int save = 0;

            SqlConnection cnn;
            cnn = new SqlConnection(ConnectionStr);
            //SqlCommand cmd;

            string query = @"INSERT INTO dbo.UserRegistration
            (UserName,FirstName,MiddleName,LastName,Gender,DateofBirth,Email
            ,ContactNo,Address,Nationality,ReligionId,EntryDate,UserImage)
            VALUES(@UserName,@FirstName,@MiddleName,@LastName,@Gender,@DateofBirth
            ,@Email,@ContactNo,@Address,@Nationality,@ReligionId,GETDATE(),@UserImage)";

            using (SqlCommand cmd=new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("@UserName",txtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim());
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
                cmd.Parameters.AddWithValue("@DateofBirth", txtDateOfBirth.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNo", txtContactNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Nationality", "");
                cmd.Parameters.AddWithValue("@ReligionId", ddlReligion.SelectedValue);
                //cmd.Parameters.AddWithValue("@EntryDate", txtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@UserImage", "1.png");
                cnn.Open();
                save= cmd.ExecuteNonQuery();
            }

            return save;
        }
    }
}