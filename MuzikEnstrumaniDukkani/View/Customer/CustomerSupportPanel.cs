using MuzikEnstrumaniDukkani.Class;
using MuzikEnstrumaniDukkani.Mesajlar;
using MuzikEnstrumaniDukkani.Model;
using MuzikEnstrumaniDukkani.Properties;
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
    public partial class CustomerSupportPanel : UserControl
    {
        public CustomerSupportPanel()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dataGridView5.DataSource = DB_Connection.db.Siparisler
                .Where(x => x.Musteri_Id == Settings.Default.UserId && (x.Tamamlandi == true || x.Aktif == true))
                .ToList();

        }

        private void Support_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex > -1 || (comboBox1.SelectedIndex == 4 && Talep_TextBox.Text != " "))
                {
                    AddTicketToDb();

                    BasariliMesaj.DestekOlustu();

                    Talep_TextBox.Text = " ";
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    HataliMesaj.BosBirakmayin();
                }
            }
            catch (Exception ex)
            {
                HataliMesaj.CatchError(ex);
            }
        }

        private void AddTicketToDb()
        {
            int id = Convert.ToInt32(dataGridView5.SelectedCells[0].Value);
            var order = DB_Connection.db.Siparisler.Find(id);

            Destek_Talepleri destek = new Destek_Talepleri();
            destek.Siparis_Id = order.Id;
            destek.Destek_Kategori_Id = comboBox1.SelectedIndex + 1;
            destek.Talep = Talep_TextBox.Text;
            destek.Aktif = true;
            destek.Talep_Tarihi = DateTime.Now;
            DB_Connection.db.Destek_Talepleri.Add(destek);
            DB_Connection.db.SaveChanges();
        }
    }
}
