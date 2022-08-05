using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealProjectB1.auth
{
    public partial class RegistrationList : System.Web.UI.Page
    {
        string ConnectionStr = @"Data Source=DESKTOP-H1OGKJ6;Initial Catalog=DotNetB1;Integrated Security=True ";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridData();
            }
        }

        private void LoadGridData()
        {
 
            DataTable dt = new DataTable();
            SqlConnection cnn;
            cnn = new SqlConnection(ConnectionStr);
            String Gender = ddlGender.SelectedValue;
            String Religion = ddlReligion.SelectedValue;
            string query = @"select UserId , UserName, 
            FirstName+ISNULL(MiddleName,'')+LastName,
            Gender,convert(varchar(15), DateofBirth ,103) DateofBirth, ContactNo
            from [dbo].[UserRegistration]
            WHERE 
            (ReligionId=" + Religion + "or "+ Religion + @"=0)
            AND (Gender ="+ Gender + " or "+ Gender + "=0)";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();

            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                cnn.Open();
                sda.SelectCommand = cmd;
                sda.Fill(ds);
                dt = ds.Tables[0];
            }

            if (dt.Rows.Count>0)
            {
                gvUserInfo.DataSource = dt;
                gvUserInfo.DataBind();
            }

        }


    }
}