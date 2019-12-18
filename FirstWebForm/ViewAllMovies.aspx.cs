using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class ViewAllMovies : Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebAppConnectionString"].ConnectionString);
          protected void Page_Load(object sender, EventArgs e)
          {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
           
          }
        private void BindGrid()
        {
            myConnection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Movie", myConnection);
            DataTable dataTable = new DataTable();
            sqlDa.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
          protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
          {
            myConnection.Open();
              int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
              SqlCommand cmd = new SqlCommand("DELETE FROM Movie WHERE MovieId=" + id + "", myConnection);
              cmd.ExecuteNonQuery();
              Response.Redirect("ViewAllMovies.aspx");
              labelSuccessDeleteMessage.Text = "Record Deleted Successfully!";
              myConnection.Close();
              myConnection.Dispose();

        }
        

     /*   [WebMethod]
        public void Delete(int id)
        {
            myConnection.Open();
            Debug.WriteLine("-----------------------------------------"+id);
           // int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            SqlCommand cmd = new SqlCommand("DELETE FROM Movie WHERE MovieId=" + id + "", myConnection);
            cmd.ExecuteNonQuery();
            Response.Redirect("ViewAllMovies.aspx");
          //  labelSuccessDeleteMessage.Text = "Record Deleted Successfully!";
            myConnection.Close();
            myConnection.Dispose();

        }*/

        /*protected void AddButton(object sender, EventArgs e)
        {
            myConnection.Open();
            string query = "Insert into [dbo].[Movie] (MovieName,Category,Rating) Values (@MovieName,@Category,@Rating)";
            SqlCommand insertCommand = new SqlCommand(query, myConnection);
            insertCommand.Parameters.AddWithValue("@MovieName", MovieName.Text);
            insertCommand.Parameters.AddWithValue("@Category", Category.Text);
            insertCommand.Parameters.AddWithValue("@Rating", Rating.Text);
            insertCommand.ExecuteNonQuery();

            Response.Redirect("ViewAllMovies.aspx");
            myConnection.Close();
            myConnection.Dispose();

        }*/
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }
        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            myConnection.Open();
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            string MovieName = (row.FindControl("txtMovieName") as TextBox).Text;
            string Category = (row.FindControl("txtCategory") as TextBox).Text;
            string Rating = (row.FindControl("txtRating") as TextBox).Text;
            SqlCommand cmd = new SqlCommand("UPDATE Movie SET MovieName=@MovieName, Category=@Category,Rating=@Rating WHERE MovieId=@id",myConnection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@MovieName", MovieName);
           cmd.Parameters.AddWithValue("@Category", Category);
           cmd.Parameters.AddWithValue("@Rating", Rating);
            cmd.ExecuteNonQuery();
            UpdateSuccess.Text = "Record Updated Successfully!!";
            myConnection.Close();        
            GridView1.EditIndex = -1;
            this.BindGrid();
        }
        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            this.BindGrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      /*  protected void AddMovie1(object sender, EventArgs e)
        {
            Response.Redirect("AddMovie.aspx");
        }*/
    }
}
