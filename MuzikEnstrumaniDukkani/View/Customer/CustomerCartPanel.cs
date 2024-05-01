﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using MuzikEnstrumaniDukkani.Class;
using MuzikEnstrumaniDukkani.Properties;
using MuzikEnstrumaniDukkani.Model;
using MuzikEnstrumaniDukkani.Mesajlar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MuzikEnstrumaniDukkani.View.Customer
{
    public partial class CustomerCartPanel : UserControl
    {
        int id;

        public CustomerCartPanel()
        {
            InitializeComponent();
        }

        private void Clear_Cart(object sender, EventArgs e)
        {
            Form1.instance.Cart.Clear();
            Total_TextBox.Text = "";
            LoadData();
        }

        private void CustomerCartPanel_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Id = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                Settings.Default.Save();
                id = Settings.Default.Id;

                var ins = DB_Connection.db.Enstrumanlar.Find(id);

                Name_TextBox.Text = ins.Ad;

                var kategori = ins.Kategori_Id;
                var kat = DB_Connection.db.Enstruman_Kategorileri.Find(kategori);
                Cat_ComboBox.SelectedIndex = Cat_ComboBox.FindStringExact($"{kat.Ad.Trim()}");

                UretimYeri_TextBox.Text = ins.Uretim_Yeri;
                Stok_TextBox.Text = ins.Stok.ToString();
                Fiyat_TextBox.Text = ins.Fiyat.ToString();
                //dataGridView1.SelectedCells[6].Value = 1;
            }
            catch
            {

            }
        }

        int toplam_Adet = 0;
        Random rand = new Random();


        private void Purch_Btn_Click(object sender, EventArgs e)
        {
            try
            {

            //satın alım classına yolla, sipariş noyu oto oluştur ve kontrol et var mı yok mu diye.
            again:
                var pool = Form1.instance.pool;

                char[] chars = new char[10];
                for (int i = 0; i < 10; i++)
                {
                    chars[i] = pool[rand.Next(pool.Length)];
                }

                string charsStr = new string(chars);
                //MessageBox.Show(charsStr);

                var sip_No = DB_Connection.db.Siparisler.FirstOrDefault(x => x.Siparis_No == charsStr);



                if (sip_No == null)
                {


                    Siparisler siparisler = new Siparisler();
                    siparisler.Siparis_No = charsStr;
                    siparisler.Musteri_Id = Settings.Default.UserId;
                    siparisler.Tutar = Convert.ToInt32(Toplam_TextBox.Text);
                    siparisler.Siparis_Tarihi = DateTime.Now;
                    siparisler.Aktif = true;
                    siparisler.Iptal = false;
                    siparisler.Tamamlandi = false;

                    DB_Connection.db.Siparisler.Add(siparisler);
                    DB_Connection.db.SaveChanges();

                    Siparis_Detay siparis = new Siparis_Detay();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        var id = Convert.ToInt32(row.Cells["ıdDataGridViewTextBoxColumn"].Value);

                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            if (id == Convert.ToInt32(item.Cells["ıdDataGridViewTextBoxColumn"].Value))
                            {
                                toplam_Adet = 0;
                                if (item.Cells["Adet"].Value != null)
                                {
                                    toplam_Adet += Convert.ToInt32(item.Cells["Adet"].Value);
                                }
                                else
                                {
                                    toplam_Adet++;
                                }
                                break;
                            }

                        }
                        var enst = DB_Connection.db.Enstrumanlar.Find(id);
                        if (enst.Stok - toplam_Adet < 0)
                        {
                            HataliMesaj.StokHatasi();
                            return;
                        }
                        else
                        {
                            enst.Stok = enst.Stok - toplam_Adet;

                        }

                        siparis.Enstruman_Id = id;
                        siparis.Siparis_No = charsStr;
                        siparis.Adet = toplam_Adet;
                        DB_Connection.db.Siparis_Detay.Add(siparis);
                        DB_Connection.db.SaveChanges();
                    }


                }
                else
                    goto again;


                BasariliMesaj.SatinAlim();

                Clear_Cart(null, null);



            }
            catch
            {

            }

        }

        public void LoadData()
        {
            try
            {
                List<Enstrumanlar> ens = new List<Enstrumanlar>();

                if (Form1.instance.Cart != null)
                {
                    foreach (var item in Form1.instance.Cart)
                    {
                        if (item != 0)
                        {
                            ens.Add(DB_Connection.db.Enstrumanlar.Find(item));
                        }
                    }
                }
                dataGridView1.DataSource = ens;
                TotalHesap();
            }
            catch
            {

            }
        }

        private void Confirm_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.SelectedCells[6].Value = Int32.Parse(Total_TextBox.Text.Trim());
                TotalHesap();
            }
            catch
            {

            }
        }

        private void TotalHesap()
        {
            try
            {
                int topadet, toplam = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells["Adet"].Value != null)
                    {
                        topadet = Convert.ToInt32(item.Cells["fiyatDataGridViewTextBoxColumn"].Value) * Convert.ToInt32(item.Cells["Adet"].Value);

                    }
                    else
                    {
                        topadet = Convert.ToInt32(item.Cells["fiyatDataGridViewTextBoxColumn"].Value);
                    }

                    toplam += topadet;
                }
                Toplam_TextBox.Text = toplam.ToString();
            }
            catch
            {

            }

        }
    }
}
