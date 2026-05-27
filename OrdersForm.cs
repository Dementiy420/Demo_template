using Demo_entity.Database;
using Demo_entity.Models;
using System.Data;

namespace Demo_template.Forms
{
    public partial class OrdersForm : Form
    {
        private MydbContext context;
        public OrdersForm()
        {
            context = new MydbContext();
            InitializeComponent();
            var result = context.Orders.GroupBy(o => o.Salesman.Name).Select(g => new QueryDTO()
            {
                Customer = g.Key,
                Products = g.Select(x => x.Product.Name).Distinct().Count(),
                Total = g.Sum(x => x.Product.Price * x.Valueproduct)
            }).ToList();
            OdersGridView.DataSource = result;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
        }

        private void OrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            context?.Dispose();
        }
    }
}