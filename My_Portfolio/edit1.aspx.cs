using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace My_Portfolio
{
    public partial class edit1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
                show();
                     
        }
        protected void show()
        {
            string connectionString = "Server=localhost;Database=practice;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT id, name, description, image_url , order_number FROM projects";
                MySqlCommand command = new MySqlCommand(query, connection);

                int serial_no = 0;


                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        string description = reader.GetString("description");
                        string imageUrl = reader.GetString("image_url");
                        string id = reader.GetInt32("id").ToString();
                        String order_number = reader.GetString("order_number");
                        
                        serial_no++;
                        
                        TableRow row = new TableRow();
                       

                        TableCell cell = new TableCell();
                        cell.Text = serial_no.ToString();
                        row.Cells.Add(cell);

                        TableCell cell2 = new TableCell();
                        cell2.Text = reader.GetString("name");
                        row.Cells.Add(cell2);

                        TableCell cell3 = new TableCell();
                        cell3.Text = reader.GetString("description");
                        row.Cells.Add(cell3);

                        TableCell cell4 = new TableCell();
                        Image img = new Image();
                        img.ImageUrl = reader.GetString("image_url");
                        img.Width = 100;
                        cell4.Controls.Add(img);
                        row.Cells.Add(cell4);

                        TableCell cell5 = new TableCell();
                        cell5.Text = order_number;
                        row.Cells.Add(cell5);

                        TableCell cell6 = new TableCell();
                        Button update = new Button();
                        update.Text = "Update";
                        update.CommandArgument = id;
                        update.Command += Update_Command; // Attach command event handler
                        cell6.Controls.Add(update);

                        Button delete = new Button();
                        delete.Text = "Delete";
                        delete.CommandArgument = id; // Set the command argument to the description
                        delete.Command += Delete_Command; // Attach command event handler

                        cell6.Controls.Add(new LiteralControl(" ")); // Line break between buttons
                        cell6.Controls.Add(delete);
                        row.Cells.Add(cell6);

                        //row.Attributes["style"] = "margin: 5px; border: 1px solid #000; padding: 5px;";
                        dynamicTable.Rows.Add(row);

                        row.CssClass = "table-row";

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }


        
    }
        protected void Update_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("~/edit.aspx?id="+ e.CommandArgument +"");

        }

        protected void Delete_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            string connectionString = "Server=localhost;Database=practice;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

     
                string query = "DELETE FROM projects WHERE ID = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Row deleted successfully");
                }
                else
                {
                    Console.WriteLine("No row deleted. ID not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            dynamicTable.Rows.Clear();

             show();

        }

        protected void Add_Button(object sender, EventArgs e)
        {
            Response.Redirect("~/add.aspx");
        }
    }
}