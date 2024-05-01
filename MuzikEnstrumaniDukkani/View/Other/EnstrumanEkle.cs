using MuzikEnstrumaniDukkani.Class;
using MuzikEnstrumaniDukkani.Mesajlar;
using MuzikEnstrumaniDukkani.Model;
using MuzikEnstrumaniDukkani.View.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikEnstrumaniDukkani.View.Other
{
    public partial class EnstrumanEkle : Form
    {
        public EnstrumanEkle()
        {
            InitializeComponent();
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                SoruMesaj.instance.EnstrumanEkle();
                if (SoruMesaj.instance.res == DialogResult.Yes)
                {
                    if (Name_TextBox.Text != null && Cat_ComboBox.Text != null && UretimYeri_TextBox.Text != null
                    && Stok_TextBox.Text != null && Fiyat_TextBox.Text != null)
                    {
                        Enstrumanlar enstrumanlar = new Enstrumanlar();
                        enstrumanlar.Ad = Name_TextBox.Text.Trim();
                        enstrumanlar.Uretim_Yeri = UretimYeri_TextBox.Text.Trim();
                        enstrumanlar.Stok = Convert.ToInt32(Stok_TextBox.Text);
                        enstrumanlar.Fiyat = Convert.ToInt32(Fiyat_TextBox.Text);

                        enstrumanlar.Kategori_Id = Cat_ComboBox.SelectedIndex + 1;

                        DB_Connection.db.Enstrumanlar.Add(enstrumanlar);
                        DB_Connection.db.SaveChanges();

                        BasariliMesaj.EnstrumanEklendi();
                        InstrumentPanel.instance.LoadData();

                        Close();
                    }
                    else
                    {
                        HataliMesaj.BosBirakmayin();
                    }
                }


            }
            catch (Exception ex)
            {
                HataliMesaj.CatchError(ex);
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            SoruMesaj.instance.CloseApp();
            if (SoruMesaj.instance.res == DialogResult.Yes)
            {
                Form1.instance.ShowLoadingScreen();

                Close();
            }
        }
    }
}
