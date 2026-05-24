using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Demo_template.Forms
{
    public partial class MainForm : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=root;database=mydb";

        string _role;

        public MainForm(string role)
        {
            _role = role;

            InitializeComponent();

            if (_role == "User")
            {
                tabControl1.TabPages.Remove(tabPage1);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    LoadData("SELECT * FROM mydb.users", UsersGridView);
                    LoadData("SELECT * FROM mydb.product", ProductGridView);
                    LoadData("SELECT * FROM mydb.specification", SpecificationGridView);
                    LoadData("SELECT * FROM mydb.order", OrdersGridView);
                    LoadData("SELECT * FROM mydb.customers", customersGridView);
                    LoadData("SELECT * FROM mydb.material", MaterialsGridView);                    

                    MessageBox.Show("Подключение к БД прошло успешно!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void UsersSave_Click(object sender, EventArgs e) => UpdateData("SELECT * FROM mydb.users", UsersGridView);
        private void ProductSave_Click(object sender, EventArgs e) => UpdateData("SELECT * FROM mydb.product", ProductGridView);
        private void SpecificationSave_Click(object sender, EventArgs e) => UpdateData("SELECT * FROM mydb.specification", SpecificationGridView);
        private void OrderSave_Click(object sender, EventArgs e) => UpdateData("SELECT * FROM mydb.order", OrdersGridView);
        private void CustomersSave_Click(object sender, EventArgs e) => UpdateData("SELECT * FROM mydb.customers", customersGridView);

        private void UpdateData(string command, DataGridView grid) 
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)) 
            {
                try
                {
                    connection.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                    DataTable dt = grid.DataSource as DataTable;

                    adapter.Update(dt);
                    dt.AcceptChanges();

                    MessageBox.Show("Данные были успешно сохранены!");
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Ошибка! Пользователь уже существует в системе!");
                    }

                }
            }
        }
        private void LoadData(string command, DataGridView grid) 
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                grid.DataSource = dt;
            }                
        }
    }
}