using MuzikEnstrumaniDukkani.Class;
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
using MuzikEnstrumaniDukkani.Model;
using MuzikEnstrumaniDukkani.Mesajlar;

namespace MuzikEnstrumaniDukkani.View.Admin
{
    public partial class SupportPanel : UserControl
    {
        public SupportPanel()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                var user = DB_Connection.db.Destek_Talepleri.ToList();

                dataGridView1.DataSource = user;

            }
            catch (Exception ex)
            {
                HataliMesaj.CatchError(ex);
            }
        }

        private void Send_Respond(object sender, EventArgs e)
        {
            try
            {
                if (Admin_Mesaj.Text == " ")
                {
                    HataliMesaj.BosBirakmayin();
                }
                else
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                    var ticket = DB_Connection.db.Destek_Talepleri.Find(id);
                    ticket.Admin_Cevap = Admin_Mesaj.Text;
                    DB_Connection.db.SaveChanges();
                    BasariliMesaj.CevapGonderildi();
                }
            }
            catch (Exception ex) { HataliMesaj.CatchError(ex); }

        }

        private void Done_Btn(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            var ticket = DB_Connection.db.Destek_Talepleri.Find(id);
            ticket.Tamamlandi = true;
            DB_Connection.db.SaveChanges();
            BasariliMesaj.Tamamlandı();

        }

        private void IslemeAlindi_Btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            var ticket = DB_Connection.db.Destek_Talepleri.Find(id);
            ticket.Isleme_Alindi = true;
            DB_Connection.db.SaveChanges();
            BasariliMesaj.IslemeAlindi();
        }
    }
}
