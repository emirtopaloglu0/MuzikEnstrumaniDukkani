using MuzikEnstrumaniDukkani.Class;
using MuzikEnstrumaniDukkani.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuzikEnstrumaniDukkani.Properties;

namespace MuzikEnstrumaniDukkani.View.Customer
{
    public partial class CustomerOrdersPanel : UserControl
    {
        public CustomerOrdersPanel()
        {
            InitializeComponent();
        }

        private void CustomerOrdersPanel_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        public void LoadData()
        {
            dataGridView5.DataSource = DB_Connection.db.Siparisler.Where(x => x.Musteri_Id == Settings.Default.UserId).ToList();
        }

        private void Active_Orders(object sender, EventArgs e)
        {
            dataGridView5.DataSource = DB_Connection.db.Siparisler.Where(x => x.Aktif == true && x.Musteri_Id == Settings.Default.UserId).ToList();

        }

        private void Cancelled_Orders(object sender, EventArgs e)
        {
            dataGridView5.DataSource = DB_Connection.db.Siparisler.Where(x => x.Iptal == true && x.Musteri_Id == Settings.Default.UserId).ToList();

        }

        private void Delivered_Orders(object sender, EventArgs e)
        {
            dataGridView5.DataSource = DB_Connection.db.Siparisler.Where(x => x.Tamamlandi == true && x.Musteri_Id == Settings.Default.UserId).ToList();
        }

        private void All_Orders(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
