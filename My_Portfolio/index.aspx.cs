using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

namespace My_Portfolio
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                About_name.InnerText = "Raihan Hossain Rakib";
                About_detail.InnerText = "An Undergrad Student in Computer Science and Engineering at Khulna University Engineering & Technology.";

                HttpCookie cookie = Request.Cookies["UserInfo"];

                if (cookie != null)
                {
                    Admin_login.HRef = "edit1.aspx";
                }
                else
                {
                    Admin_login.HRef = "login.aspx";
                }

                

                string connectionString = "Server=localhost;Database=practice;Uid=root;Pwd=;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();
                    string query = "SELECT id, name, description, image_url , github_link FROM projects order by order_number";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Project1_name.InnerText = reader.GetString("name");
                            Project1_description.InnerText = reader.GetString("description");
                            Project1.Src = reader.GetString("image_url");                       
                            Project1_github.HRef = reader.GetString("github_link");
                        }
                        if (reader.Read())
                        {
                            Project2_name.InnerText = reader.GetString("name");
                            Project2_description.InnerText = reader.GetString("description");
                            Project2.Src = reader.GetString("image_url");
                            Project2_github.HRef = reader.GetString("github_link");
                        }
                        if (reader.Read())
                        {
                            Project3_name.InnerText = reader.GetString("name");
                            Project3_description.InnerText = reader.GetString("description");
                            Project3.Src = reader.GetString("image_url");
                            Project3_github.HRef = reader.GetString("github_link");
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
                if (Session["name"] != null)
                {
                    Name.Text = Session["name"].ToString();
                }
                if (Session["email"]!= null)
                {
                    Email.Text = Session["email"].ToString();
                }
            }

        }

        protected void Contact_Submit_Button(object sender, EventArgs e)
        {
            Session["name"] = Name.Text;
            Session["email"] = Email.Text;
            string connectionString = "Server=localhost;Database=practice;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                

                string query = "INSERT INTO comments (name, email , message) VALUES (@name, @email ,@message)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", Name.Text);
                command.Parameters.AddWithValue("@email", Email.Text);
                command.Parameters.AddWithValue("@message", Message_text.Value );

                int rowsAffected = command.ExecuteNonQuery();

                if(rowsAffected > 0)
                {
                    Name.Text = "";
                    Email.Text = ""; 
                    Message_text.Value = "";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Message sent successfully');", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Message does not sent');", true);

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