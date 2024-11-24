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
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
            Fillgrid();
            PopulateCategoryComboBox();
        }
        private void items_Load(object sender, EventArgs e)
        {
            Fillgrid();
            PopulateCategoryComboBox();


        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=billig_system;password=";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    string item = textBox1.Text.Trim();
                    string category = comboBox.Text.Trim();
                    string price = textBox3.Text.Trim();
                    string stock = textBox4.Text.Trim();
                    string manufacture = textBox5.Text.Trim();

                    if (string.IsNullOrEmpty(item) ||
                        string.IsNullOrEmpty(category) ||
                        string.IsNullOrEmpty(price) ||
                        string.IsNullOrEmpty(stock) ||
                        string.IsNullOrEmpty(manufacture))
                    {
                        MessageBox.Show("No empty fields allowed");
                    }
                    else
                    {
                        conn.Open();

                        string query = "INSERT INTO item_management (Item_Name, Item_Category, Item_Price, Stock, Manufacture) " +
                                       "VALUES (@item, @category, @price, @stock, @manufacture)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@item", item);
                            cmd.Parameters.AddWithValue("@category", category);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@stock", stock);
                            cmd.Parameters.AddWithValue("@manufacture", manufacture);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Item added successfully!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Fillgrid()
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=billig_system;password=";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    conn.Open();

                    // Query to fetch data from 'item_management' table
                    string query = "SELECT Item_ID, Item_Name, Item_Category, Item_Price, Stock, Manufacture FROM item_management";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Bind data to DataGridView
                        dataGridView.DataSource = dt;

                        // Auto-resize columns for better display
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=billig_system;password=";

            try
            {
                // Check if a row is selected
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView.SelectedRows[0].Index;
                    string itemId = dataGridView.SelectedRows[0].Cells["Item_ID"].Value.ToString();

                    string updatedItem = textBox1.Text.Trim();
                    string updatedCategory = comboBox.Text.Trim();
                    string updatedPrice = textBox3.Text.Trim();
                    string updatedStock = textBox4.Text.Trim();
                    string updatedManufacture = textBox5.Text.Trim();

                    if (string.IsNullOrEmpty(updatedItem) ||
                        string.IsNullOrEmpty(updatedCategory) ||
                        string.IsNullOrEmpty(updatedPrice) ||
                        string.IsNullOrEmpty(updatedStock) ||
                        string.IsNullOrEmpty(updatedManufacture))
                    {
                        MessageBox.Show("No empty fields allowed");
                        return;
                    }

                    using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                    {
                        conn.Open();

                        string query = "UPDATE item_management SET " +
                                       "Item_Name = @item, " +
                                       "Item_Category = @category, " +
                                       "Item_Price = @price, " +
                                       "Stock = @stock, " +
                                       "Manufacture = @manufacture " +
                                       "WHERE Item_ID = @itemId";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@item", updatedItem);
                            cmd.Parameters.AddWithValue("@category", updatedCategory);
                            cmd.Parameters.AddWithValue("@price", updatedPrice);
                            cmd.Parameters.AddWithValue("@stock", updatedStock);
                            cmd.Parameters.AddWithValue("@manufacture", updatedManufacture);
                            cmd.Parameters.AddWithValue("@itemId", itemId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Item updated successfully!");


                            Fillgrid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=billig_system;password=";

            try
            {
                // Check if a row is selected
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView.SelectedRows[0].Index;
                    string itemId = dataGridView.SelectedRows[0].Cells["Item_ID"].Value.ToString();

                    using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                    {
                        conn.Open();
                        string query = "DELETE FROM item_management WHERE Item_ID = @itemId";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@itemId", itemId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Item deleted successfully!");


                            Fillgrid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void PopulateCategoryComboBox()
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=billig_system;password=";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    conn.Open();
                    string query = "SELECT category_name FROM category"; // Query to fetch category names

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        comboBox.Items.Clear(); // Clear existing items

                        while (reader.Read())
                        {
                            string categoryName = reader["category_name"].ToString();
                            comboBox.Items.Add(categoryName); // Add category names to ComboBox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
