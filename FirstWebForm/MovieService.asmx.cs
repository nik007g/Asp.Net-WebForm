using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
namespace FirstWebForm
{
    /// <summary>
    /// Summary description for MovieService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class MovieService : System.Web.Services.WebService
    {
        [WebMethod]
        public void GetMovies()
        {
            String cs = ConfigurationManager.ConnectionStrings["WebAppConnectionString"].ConnectionString;
            List<Movie> movies = new List<Movie>();
            using(SqlConnection con=new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select * from Movie", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    Movie movie = new Movie();
                    movie.MovieId = Convert.ToInt32(rdr["MovieId"]);
                    movie.MovieName = rdr["MovieName"].ToString();
                    movie.Category = rdr["Category"].ToString();
                    movie.Rating = Convert.ToInt32(rdr["Rating"]);
                    movies.Add(movie);
                }
                JavaScriptSerializer js = new JavaScriptSerializer();
                Context.Response.Write(js.Serialize(movies));
            }
        }
    }
}
