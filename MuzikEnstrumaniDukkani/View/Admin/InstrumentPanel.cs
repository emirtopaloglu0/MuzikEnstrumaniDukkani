using MuzikEnstrumaniDukkani.Class;
using MuzikEnstrumaniDukkani.View.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MuzikEnstrumaniDukkani.Mesajlar;

namespace MuzikEnstrumaniDukkani.View.Admin
{
    public partial class InstrumentPanel : UserControl
    {
        public static InstrumentPanel instance = new InstrumentPanel();

        //private BindingSource bs = new BindingSource();

        public int idd, kategori;
        public string ad, uretim, stok, fiyat;

        public InstrumentPanel()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }

        }

        private void Remove_Ins(object sender, EventArgs e)
        {
            Properties.Settings.Default.Id = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            Properties.Settings.Default.Save();
            SoruMesaj.instance.SilSoru();
            if (SoruMesaj.instance.res == DialogResult.Yes)
            {
                var ins = DB_Connection.db.Enstrumanlar.Find(Properties.Settings.Default.Id);
                DB_Connection.db.Enstrumanlar.Remove(ins);
                DB_Connection.db.SaveChanges();
                BasariliMesaj.SilmeBasarili();
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

        internal void LoadData()
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

        private void Add_Ins(object sender, EventArgs e)
        {
            EnstrumanEkle enstrumanEkle = new EnstrumanEkle();
            enstrumanEkle.ShowDialog();
        }

        private void InstrumentPanel_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Edit_Ins(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Id = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                Properties.Settings.Default.Save();

                EnstrumanDuzenle enstrumanDuzenle = new EnstrumanDuzenle();
                enstrumanDuzenle.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
