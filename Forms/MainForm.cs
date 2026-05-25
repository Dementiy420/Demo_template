using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Demo_template.Forms
{
    public partial class MainForm : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=root;database=mydb";

        Dictionary<string, DataGridView> grids = new Dictionary<string, DataGridView>();

        public string Role { get; set; }

        public MainForm() => InitializeComponent();        

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Role == "User")
                tabControl1.TabPages.Remove(tabPage1);

            grids.Add("SELECT * FROM mydb.users", UsersGridView);
            grids.Add("SELECT * FROM mydb.product", ProductGridView);
            grids.Add("SELECT * FROM mydb.specification", SpecificationGridView);
            grids.Add("SELECT * FROM mydb.order", OrdersGridView);
            grids.Add("SELECT * FROM mydb.customers", customersGridView);
            grids.Add("SELECT * FROM mydb.material", MaterialsGridView);

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
        private void UsersSave_Click(object sender, EventArgs e) 
        {
            DataGridView grid = tabControl1.SelectedTab.Controls.OfType<DataGridView>().FirstOrDefault();

            var command = grids.FirstOrDefault(g => g.Value == grid);

            UpdateData(command.Key, command.Value);
        }

        private void DeleteRow_Click(object sender, EventArgs e) 
        {
            try
            {
                DataGridView grid = tabControl1.SelectedTab.Controls.OfType<DataGridView>().FirstOrDefault();

                foreach (DataGridViewRow row in grid.SelectedRows) 
                {
                    grid.Rows.Remove(row);
                }
                MessageBox.Show("Данные удалены!");

            }
            catch 
            {
                MessageBox.Show("Ошибка выполнения операции!");
            }

        }

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

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        MessageBox.Show("Ошибка! Пользователь уже существует в системе!");
                    else
                        MessageBox.Show($"Error: {ex.Message}");
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

        private void тестированиеAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestAPI testForm = new TestAPI();

            testForm.ShowDialog();
        }

        private void OpenOrderTable_Click(object sender, EventArgs e)
        {
            using(OrdersForm ordersForm = new OrdersForm()) 
            {
                ordersForm.ShowDialog();
            }
        }
    }
}