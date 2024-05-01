using MuzikEnstrumaniDukkani.Class;
using MuzikEnstrumaniDukkani.Mesajlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuzikEnstrumaniDukkani.Properties;

namespace MuzikEnstrumaniDukkani.View.Customer
{
    public partial class CustomerPurchasePanel : UserControl
    {
        int id;
        public CustomerPurchasePanel()
        {
            InitializeComponent();
        }

        private void CustomerPurchasePanel_Load(object sender, EventArgs e)
        {
            try
            {
                var ins = DB_Connection.db.Enstrumanlar.ToList();
                dataGridView1.DataSource = ins;
            }
            catch
            {

            }
        }

        private void View_Ins_Click(object sender, EventArgs e)
        {
            try
            {
                var cat_Id = comboBox1.SelectedIndex + 1;
                var ins = DB_Connection.db.Enstrumanlar.Where(x => x.Kategori_Id == cat_Id).ToList();
                dataGridView1.DataSource = ins;
            }
            catch
            {

            }
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            var ins = DB_Connection.db.Enstrumanlar.ToList();
            dataGridView1.DataSource = ins;
        }

        private void AddToCart_Button_Click(object sender, EventArgs e)
        {
            try
            {

                int error = 0;
                //Form1.instance.Cart.Add(id);

                foreach (var item in Form1.instance.Cart)
                {
                    if (item == id)
                    {
                        HataliMesaj.SepetteVar();
                        error++;
                    }
                }
                if (error == 0)
                {
                    Form1.instance.Cart.Add(id);

                }

            }
            catch (Exception ex)
            {
                HataliMesaj.CatchError(ex);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Id = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                Settings.Default.Save();
                id = Settings.Default.Id;

                var ins = DB_Connection.db.Enstrumanlar.Find(id);

                //Name_TextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                Name_TextBox.Text = ins.Ad;

                var kategori = ins.Kategori_Id;
                var kat = DB_Connection.db.Enstruman_Kategorileri.Find(kategori);
                Cat_ComboBox.SelectedIndex = Cat_ComboBox.FindStringExact($"{kat.Ad.Trim()}");

                UretimYeri_TextBox.Text = ins.Uretim_Yeri;
                Stok_TextBox.Text = ins.Stok.ToString();
                Fiyat_TextBox.Text = ins.Fiyat.ToString();
            }
            catch
            {

            }


        }
    }
}
