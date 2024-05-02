using MuzikEnstrumaniDukkani.Mesajlar;
using MuzikEnstrumaniDukkani.Model;
using MuzikEnstrumaniDukkani.Properties;
using MuzikEnstrumaniDukkani.View.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MuzikEnstrumaniDukkani.Class
{
    public class C_Orders
    {
        public static C_Orders instance = new C_Orders();
        //public int[] cart;


        public Siparisler sip_No;
        public bool ConfirmCart(int tutar)
        {
            try
            {
                Random rand = new Random();

            again:
                var pool = Form1.instance.pool;

                char[] chars = new char[10];
                for (int i = 0; i < 10; i++)
                {
                    chars[i] = pool[rand.Next(pool.Length)];
                }

                string charsStr = new string(chars);
                sip_No = DB_Connection.db.Siparisler.FirstOrDefault(x => x.Siparis_No == charsStr);
                
                if (sip_No == null)
                {
                    Siparisler siparisler = new Siparisler();
                    siparisler.Siparis_No = charsStr;

                    Settings.Default.Siparis_No = charsStr;
                    Settings.Default.Save();

                    siparisler.Musteri_Id = Settings.Default.UserId;
                    siparisler.Tutar = tutar;
                    siparisler.Siparis_Tarihi = DateTime.Now;
                    siparisler.Aktif = true;
                    siparisler.Iptal = false;
                    siparisler.Tamamlandi = false;

                    DB_Connection.db.Siparisler.Add(siparisler);
                    DB_Connection.db.SaveChanges();

                    return true;
                }
                else
                    goto again;
            }
            catch
            {
                return false;
            }
        }

        public bool CancelOrder(int id)
        {
            try
            {
                var order = DB_Connection.db.Siparisler.Find(id);

                order.Aktif = false;
                order.Iptal = true;
                order.Iptal_Tarihi = DateTime.Now;
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
