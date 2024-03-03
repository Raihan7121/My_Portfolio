using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My_Portfolio
{
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Project_Add(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=practice;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);


            
           
            String name = Project_Name.Text;
            String description = Project_description.Value;
            String image_url = Project_image_url.Text;
            String github_link = Project_github_url.Text;
            String order_number = Project_Order_number.Text;
            try
            {
                connection.Open();
                string query = "INSERT INTO projects ( name , description , image_url ,github_link ,order_number ) VALUES ( @name , @description , @image_url ,@github_link ,@order_number)";
             
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@image_url", image_url);
                command.Parameters.AddWithValue("@github_link", github_link);
                command.Parameters.AddWithValue("@order_number", order_number );

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Inserted successful');", true);
                    Response.Redirect("~/index.aspx");

                }
                else
                {
                    Console.WriteLine($"No rows updated.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}