using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=.\\SHAIKUMAR80; database = database1; Integrated Security = true");
            sql.Open();
            SqlCommand com = new SqlCommand("insert into login(username,password) values('" + txtname.Text + "', '" + txtpass.Text + "')", sql);
           
            com.ExecuteReader();
            Response.Write("successfully loged in");
            sql.Close();
            Response.Redirect("WebForm2");
            


        }
    }
}