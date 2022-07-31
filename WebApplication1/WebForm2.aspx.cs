using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=.\\SHAIKUMAR80; database = database1; Integrated Security = true");
            SqlCommand com = new SqlCommand("select * from login", sql);
            sql.Open();
            SqlDataReader sdr = com.ExecuteReader();
            GridView1.DataSource = sdr;
            GridView1.DataBind();
            sql.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}