using MuzikEnstrumaniDukkani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikEnstrumaniDukkani.Class
{
    internal class C_Instruments
    {
        public static C_Instruments instance;

        public bool AddIns(string ad, string uretim, int stok, int fiyat, int kategori)
        {
            try
            {
                Enstrumanlar enstrumanlar = new Enstrumanlar();
                enstrumanlar.Ad = ad;
                enstrumanlar.Uretim_Yeri = uretim;
                enstrumanlar.Stok = stok;
                enstrumanlar.Fiyat = fiyat;
                enstrumanlar.Kategori_Id = kategori;

                DB_Connection.db.Enstrumanlar.Add(enstrumanlar);
                DB_Connection.db.SaveChanges();


                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool EditIns(int id, string ad, string uretim, int kategori, int stok, int fiyat)
        {
            try
            {
                var ens = DB_Connection.db.Enstrumanlar.Find(id);
                ens.Ad = ad;
                ens.Kategori_Id = kategori;
                ens.Uretim_Yeri = uretim;
                ens.Stok = stok;
                ens.Fiyat = fiyat;

                DB_Connection.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    
        public bool RemoveIns(int id)
        {
            try
            {
                var ins = DB_Connection.db.Enstrumanlar.Find(id);
                DB_Connection.db.Enstrumanlar.Remove(ins);
                DB_Connection.db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
