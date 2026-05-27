using Demo_entity.Database;
using Demo_entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_template.Forms
{
    public partial class MainForm : Form
    {

        MydbContext context;
        List<BindingSource> grids = new List<BindingSource>();

        public string Role;

        public MainForm()
        {
            InitializeComponent();

            context = new MydbContext();

            context.Users.Load();

            grids.AddRange
                (
                userBindingSource,
                productBindingSource,
                orderBindingSource,
                customerBindingSource,
                materialBindingSource,
                specificationBindingSource
                );

            userBindingSource.DataSource = context.Users.Local.ToBindingList();

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
        private void UsersSave_Click(object sender, EventArgs e)
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
    }
}