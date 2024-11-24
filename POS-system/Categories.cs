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

namespace POS_system
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            Fillgrid();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=billig_system;password=";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {

                    string category = textBox2.Text.Trim();


                    if (
                        string.IsNullOrEmpty(category))
                    {
                        MessageBox.Show("No empty fields allowed");
                    }
                    else
                    {
                        conn.Open();

                        string query = "INSERT INTO category (category_name) " +
                                       "VALUES (@category)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("@category", category);


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
                    string query = "SELECT * FROM category";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string categoryId = dataGridView1.SelectedRows[0].Cells["category_ID"].Value.ToString();
                    string updatedCategory = textBox2.Text.Trim();

                    if (string.IsNullOrEmpty(updatedCategory))
                    {
                        MessageBox.Show("Category name cannot be empty.");
                        return;
                    }

                    using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                    {
                        conn.Open();
                        string query = "UPDATE category SET category_name = @updatedCategory WHERE category_ID = @categoryId";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@updatedCategory", updatedCategory);
                            cmd.Parameters.AddWithValue("@categoryId", categoryId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Category updated successfully!");

                            // Refresh the grid after editing
                            Fillgrid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a category to edit.");
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    string categoryId = dataGridView1.SelectedRows[0].Cells["category_ID"].Value.ToString();

                    using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                    {
                        conn.Open();
                        string query = "DELETE FROM category WHERE category_ID = @categoryId";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@categoryId", categoryId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Category deleted successfully!");


                            Fillgrid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a category to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
