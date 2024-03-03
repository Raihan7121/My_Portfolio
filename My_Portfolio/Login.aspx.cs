using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My_Portfolio
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["UserInfo"];

                if (cookie != null)
                {
                    Username.Text = cookie["username"].ToString();
                    Password.Text = cookie["password"].ToString();

                }
            }
        }
        protected void Login_button(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");

            cookie["username"]= Username.Text;
            cookie["password"]= Password.Text;

            string connectionString = "Server=localhost;Database=practice;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            String user = Username.Text;
            String pass = Password.Text;
            cookie.Expires = DateTime.Now.AddDays(7);

            Response.Cookies.Add(cookie);

            try
            {
                connection.Open();
                string query = "SELECT username, password FROM login WHERE username= @Username";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Username", user);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //string username = reader["username"].ToString();
                        string password = reader["password"].ToString();



                        if (pass == password)
                        {
                            Response.Redirect("~/edit1.aspx");
                        }
                        else
                        {

                        }


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
}