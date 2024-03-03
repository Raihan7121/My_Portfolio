using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace My_Portfolio
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        { 
            if (!IsPostBack)
            {
                string connectionString = "Server=localhost;Database=practice;Uid=root;Pwd=;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                //int id = 1;
                int id = int.Parse(Request.QueryString["id"]); //id fetch
                try
                {
                    connection.Open();
                    string query = "SELECT name, description, image_url ,github_link ,order_number FROM projects WHERE Id = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            Project_Name.Text = reader["name"].ToString();
                            Project_description.Value = reader["description"].ToString();
                            Project_image_url.Text = reader["image_url"].ToString();
                            Project_github_url.Text = reader["github_link"].ToString();
                            Project_Order_number.Text = reader["order_number"].ToString();
                        }
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

        protected void Project_Edit(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=practice;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);


             int id = int.Parse( Request.QueryString["id"] ); //id fetch
            //int id = 1;
            String name = Project_Name.Text;
            String description = Project_description.Value;
            String image_url = Project_image_url.Text;
            String github_link = Project_github_url.Text;
            String order_number = Project_Order_number.Text;
            try
            {
                connection.Open();
                string query = "UPDATE projects SET name = @name, description = @description , image_url = @image_url , github_link= @github_link ,order_number= @order_number WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@image_url", image_url);
                command.Parameters.AddWithValue("@github_link", github_link);
                command.Parameters.AddWithValue("@order_number", order_number);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Update successful');", true);
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