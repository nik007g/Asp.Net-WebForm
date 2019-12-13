using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class AddMovie : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebAppConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
          //  SqlConnection con = new SqlConnection("server=FSIND-LT-43;database=MovieWebForm; ");

        }


       

        protected void MovieName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void AddButton(object sender, EventArgs e)
        {
            myConnection.Open();
            string query = "Insert into [dbo].[Movie] (MovieName,Category,Rating) Values (@MovieName,@Category,@Rating)";
            SqlCommand insertCommand = new SqlCommand(query, myConnection);
            insertCommand.Parameters.AddWithValue("@MovieName", MovieName.Text);
            insertCommand.Parameters.AddWithValue("@Category", Category.Text);
            insertCommand.Parameters.AddWithValue("@Rating", Rating.Text);
            insertCommand.ExecuteNonQuery();
            labelSuccessMessage.Text = "Record Added Successfully!";

            Response.Redirect("ViewAllMovies.aspx"); 
            myConnection.Close();
            myConnection.Dispose();

        }
    }
}