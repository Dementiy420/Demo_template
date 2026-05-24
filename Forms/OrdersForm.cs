using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Demo_template.Forms
{
    public partial class OrdersForm : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=root;database=mydb";

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string command = "SELECT DISTINCT COUNT(distinct product.name), SUM(product.price * mydb.order.valueproduct), customers.name FROM mydb.order " +
                    "JOIN product ON product.id = mydb.order.product_id " +
                    "JOIN customers ON customers.id = mydb.order.salesman_id " +
                    "GROUP BY customers.name;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                
                OdersGridView.DataSource = dt;
            }
        }
    }
}