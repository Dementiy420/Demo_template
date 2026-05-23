using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Demo_template.Forms
{
    public partial class MainForm : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=root;database=mydb";


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    LoadGrid("SELECT * FROM mydb.users", usersGridView1, connectionString);
                    LoadGrid("SELECT * FROM mydb.product", productGridView, connectionString);
                    LoadGrid("SELECT * FROM mydb.specification", specificationGridView, connectionString);
                    LoadGrid("SELECT * FROM mydb.order", ordersGridView, connectionString);
                    LoadGrid("SELECT * FROM mydb.customers", customersGridView, connectionString);

                    MessageBox.Show("Подключение к БД прошло успешно!");
                }
                catch
                {
                    MessageBox.Show("Не удалось подключиться к базе данных!");
                }
            }
        }

        private void LoadGrid(string command, DataGridView grid, string connection) 
        {
            MySqlDataAdapter sda_users = new MySqlDataAdapter(command, connection);

            DataTable dt = new DataTable();
            sda_users.Fill(dt);

            grid.DataSource = dt;
        } 
    }
}