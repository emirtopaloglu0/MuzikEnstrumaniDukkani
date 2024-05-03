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
using MuzikEnstrumaniDukkani.Mesajlar;

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

        private void Cancel_Purch_Btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView5.SelectedCells[0].Value);
            var order = DB_Connection.db.Siparisler.Find(id);

            if (order != null)
            {
                //var dt = Convert.ToDateTime(order.Siparis_Tarihi);
                if (DateTime.Now <= order.Siparis_Tarihi.Date.AddDays(3))
                {
                    SoruMesaj.instance.SiparisIptal();
                    if (SoruMesaj.instance.res == DialogResult.Yes)
                    {
                        if (C_Orders.instance.CancelOrder(id))
                        {
                            BasariliMesaj.SiparisIptalEdildi();
                            Application.Restart();
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    HataliMesaj.SiparisZamanAsimi();
                }
            }
            else
                HataliMesaj.SatiriSeciniz();
        }
    }
}
