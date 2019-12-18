using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class EditMovie1 : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebAppConnectionString"].ConnectionString);
        int movieId;
        string movieName, category, rating;

        String id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
            if (!Page.IsPostBack)
            {
                myConnection.Open();
                SqlCommand cmd = new SqlCommand("Select * from Movie WHERE MovieId=" + id, myConnection);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    movieId = Convert.ToInt32(rdr["MovieId"]);
                    movieName = rdr["MovieName"].ToString();
                    category = rdr["Category"].ToString();
                    rating = rdr["Rating"].ToString();
                }
                rdr.Close();
                cmd.Dispose();
                TextBox MovieName = (TextBox)FindControl("MovieName");
                // Debug.WriteLine(" !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + MovieName);
                MovieName.Text = movieName;
                TextBox Category = (TextBox)FindControl("Category");
                Category.Text = category;
                TextBox Rating = (TextBox)FindControl("Rating");
                Rating.Text = rating;
            }
        }

       /* [WebMethod]
        protected void EditMovie()
        {
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Movie WHERE MovieId=" + id, myConnection);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                movieId = Convert.ToInt32(rdr["MovieId"]);
                movieName = rdr["MovieName"].ToString();
                category = rdr["Category"].ToString();
                rating = rdr["Rating"].ToString();
            }
            rdr.Close();
            cmd.Dispose();
            TextBox MovieName = (TextBox)FindControl("MovieName");
            // Debug.WriteLine(" !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + MovieName);
            MovieName.Text = movieName;
            TextBox Category = (TextBox)FindControl("Category");
            Category.Text = category;
            TextBox Rating = (TextBox)FindControl("Rating");
            Rating.Text = rating;
            
        }*/
        protected void UpdateMovie(object sender, EventArgs e)
        {
            myConnection.Open();
            movieName =(FindControl("MovieName") as TextBox).Text;
            category= (FindControl("Category") as TextBox).Text;
            rating =(FindControl("Rating") as TextBox).Text;
            SqlCommand cmd = new SqlCommand("UPDATE Movie SET MovieName=@MovieName, Category=@Category,Rating=@Rating WHERE MovieId=" + id, myConnection);
            cmd.Parameters.AddWithValue("@MovieName", movieName);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@Rating", rating);
            cmd.ExecuteNonQuery();
            myConnection.Close();
            Response.Redirect("ViewAllMovies.aspx");
        }
        
    }
}