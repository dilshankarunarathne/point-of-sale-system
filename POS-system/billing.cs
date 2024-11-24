using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_system
{
    public partial class billing : Form
    {
        public billing()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = item_box.Text;
            string price = price_box.Text;
            string search = search_box.Text;
            string discount = discount_box.Text;
            string quantity = quentity_box.Text;

            string searchText = search_box.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter an Item Name or Item ID to search.");
                return;
            }

            string mysqlconn = "server=127.0.0.1;user=root;database=billig_system;password=";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    conn.Open();

                    // SQL query to fetch item details based on name or ID
                    string query = "SELECT Item_Name, Item_Price FROM item_management WHERE Item_ID = @search OR Item_Name = @search";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", searchText);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the text boxes with the item's details
                                item_box.Text = reader["Item_Name"].ToString();   // Item Name
                                price_box.Text = reader["Item_Price"].ToString();  // Item Price
                            }
                            else
                            {
                                MessageBox.Show("No item found with the given name or ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void item_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
