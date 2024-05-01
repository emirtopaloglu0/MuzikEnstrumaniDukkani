using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikEnstrumaniDukkani.View.Customer
{
    public partial class CustomerPanel : UserControl
    {
        //public CustomerPanel instance = new CustomerPanel();
        public CustomerPanel()
        {
            InitializeComponent();
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            customerCartPanel1.Hide();
            customerOrdersPanel1.Show();
            customerPurchasePanel1.Hide();
            customerSupportPanel1.Hide();
        }

        private void View_Purch_Click(object sender, EventArgs e)
        {
            customerCartPanel1.Hide();
            customerOrdersPanel1.Hide();
            customerPurchasePanel1.Show();
            customerSupportPanel1.Hide();
        }

        private void View_Cart_Click(object sender, EventArgs e)
        {
            customerCartPanel1.Show();
            customerOrdersPanel1.Hide();
            customerPurchasePanel1.Hide();
            customerSupportPanel1.Hide();
            customerCartPanel1.LoadData();
        }

        private void View_Orders_Click(object sender, EventArgs e)
        {
            customerCartPanel1.Hide();
            customerOrdersPanel1.Show();
            customerPurchasePanel1.Hide();
            customerSupportPanel1.Hide();
            LoadOrdersData();
        }

        private void View_Support_Click(object sender, EventArgs e)
        {
            customerCartPanel1.Hide();
            customerOrdersPanel1.Hide();
            customerPurchasePanel1.Hide();
            customerSupportPanel1.Show();
        }

        public void LoadOrdersData()
        {
            customerOrdersPanel1.LoadData();
        }
    }
}
