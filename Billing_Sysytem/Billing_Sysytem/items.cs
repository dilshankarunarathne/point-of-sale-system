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

namespace Billing_Sysytem
{
    public partial class items : Form
    {
        public items()
        {
            InitializeComponent();
        }

        private void items_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=billig_system;password=";
            try
            {
                MySqlConnection conn = new MySqlConnection(mysqlconn);

                string item = textBox1.Text.ToString();
                string category = comboBox1.Text.ToString();
                string price = textBox3.Text.ToString();    
                string stock= textBox4.Text.ToString(); 
                string manufacture= textBox5.Text.ToString();

                if (String.IsNullOrEmpty(item) || String.IsNullOrEmpty(category)||String.IsNullOrEmpty(price)|| String.IsNullOrEmpty(stock)|| String.IsNullOrEmpty(manufacture))
                {
                    MessageBox.Show("No empty fields allowd");
                }
                else
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO 'item_management'('Item_id', 'Item_Name', 'Item_Category', 'Item_Price', 'Stock', 'Manufacture') VALUES (item,category,price,stock,manufacture) ", conn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

            }


        }
    }
}
