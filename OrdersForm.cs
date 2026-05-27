using System;
using System.Data;
using System.Windows.Forms;

namespace Demo_template.Forms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            OdersGridView.DataSource = dt;
        }
    }
}