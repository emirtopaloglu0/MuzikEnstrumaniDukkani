using MuzikEnstrumaniDukkani.Class;
using MuzikEnstrumaniDukkani.Mesajlar;
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

    public partial class EnstrumanDuzenle : Form
    {
        public static EnstrumanDuzenle ins;

        public int id, kategori;
        public string ad, uretim, stok, fiyat;

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            SoruMesaj.instance.CloseApp();
            if (SoruMesaj.instance.res == DialogResult.Yes)
            {
                Form1.instance.ShowLoadingScreen();

                Close();
            }
        }

        public EnstrumanDuzenle()
        {
            InitializeComponent();
        }


        private void Register_Btn_Click(object sender, EventArgs e)
        {

            SoruMesaj.instance.GuncelleSoru();
            if (SoruMesaj.instance.res == DialogResult.Yes)
            {
                if (C_Instruments.instance.EditIns(id, Name_TextBox.Text, UretimYeri_TextBox.Text,
                    Cat_ComboBox.SelectedIndex + 1, Int32.Parse(Stok_TextBox.Text),
                    Int32.Parse(Fiyat_TextBox.Text)))
                {
                    BasariliMesaj.GuncellmeBasarili();
                    Close();
                }
            }


        }

        private void EnstrumanDuzenle_Load(object sender, EventArgs e)
        {
            try
            {
                id = Properties.Settings.Default.Id;


                var ens = DB_Connection.db.Enstrumanlar.Find(id);
                Name_TextBox.Text = ens.Ad;

                kategori = ens.Kategori_Id;
                var kat = DB_Connection.db.Enstruman_Kategorileri.Find(kategori);

                Cat_ComboBox.SelectedIndex = Cat_ComboBox.FindStringExact($"{kat.Ad.Trim()}");
                UretimYeri_TextBox.Text = ens.Uretim_Yeri;
                Stok_TextBox.Text = ens.Stok.ToString();
                Fiyat_TextBox.Text = ens.Fiyat.ToString();

            }
            catch (Exception ex)
            {
                HataliMesaj.CatchError(ex);
            }


        }
    }
}
