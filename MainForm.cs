using Demo_entity.Database;
using Microsoft.EntityFrameworkCore;

namespace Demo_template.Forms
{
    public partial class MainForm : Form
    {

        MydbContext context;

        public string Role;

        public MainForm()
        {
            InitializeComponent();
            context = new MydbContext();

            context.Users.Load();
            context.Products.Load();
            context.Orders.Load();
            context.Specifications.Load();
            context.Materials.Load();
            context.Customers.Load();

            userBindingSource.DataSource = context.Users.Local.ToBindingList();
            productBindingSource.DataSource = context.Products.Local.ToBindingList();
            orderBindingSource.DataSource = context.Orders.Local.ToBindingList();
            specificationBindingSource.DataSource = context.Specifications.Local.ToBindingList();
            materialBindingSource.DataSource = context.Materials.Local.ToBindingList();
            customerBindingSource.DataSource = context.Customers.Local.ToBindingList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Role == "User")
                tabControl1.TabPages.Remove(tabPage1);

            try
            {
                MessageBox.Show("Подключение к БД прошло успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                MessageBox.Show("Данные удалены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка выполнения операции!\nЗаполните поля корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void тестированиеAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestAPI testForm = new TestAPI();

            testForm.ShowDialog();
        }

        private void OpenOrderTable_Click(object sender, EventArgs e)
        {
            using (OrdersForm ordersForm = new OrdersForm())
            {
                ordersForm.ShowDialog();
            }
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Controls.OfType<DataGridView>().FirstOrDefault().EndEdit();
            try
            {
                context.SaveChanges();

                MessageBox.Show("Данные были сохранены!", "Операция прошла успешно!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при сохранении!", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            context?.Dispose();
        }
    }
}