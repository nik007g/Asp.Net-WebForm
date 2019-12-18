using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebAppConnectionString"].ConnectionString);
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];

        }


        [WebMethod]
        public void Delete(object sender, EventArgs e)
        {
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Movie WHERE MovieId=" + id , myConnection);
            cmd.ExecuteNonQuery();
            myConnection.Close();
            myConnection.Dispose();
            Response.Redirect("ViewAllMovies.aspx");
            //  labelSuccessDeleteMessage.Text = "Record Deleted Successfully!";
          
        }
        public void redirect(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllMovies.aspx");
        }
    }
}