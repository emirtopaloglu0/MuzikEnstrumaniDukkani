using MuzikEnstrumaniDukkani.Mesajlar;
using MuzikEnstrumaniDukkani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikEnstrumaniDukkani.Class
{
    internal class Customers
    {
        public static Customers instance = new Customers();
        MuzikEnstrumaniDukkaniEntities db = DB_Connection.db;

        public bool IsAdmin;

        Model.Musteriler IsCustomerReal(string username)
        {
            try
            {

                var user = db.Musteriler.FirstOrDefault(x => x.Kullanici_Adi == username);
                if (user != null)
                {
                    return user;
                }
            }
            catch
            {

            }
            return null;
        }

        public bool LogIn(string username, string pass)
        {
            var user = IsCustomerReal(username);


            if (user != null)
            {
                if (user.Sifre == pass) 
                {
                    if(user.Id == 2)
                    {
                        IsAdmin = true;
                    }
                    else
                    {
                        IsAdmin = false;
                    }
                    Properties.Settings.Default.UserId = user.Id;
                    Properties.Settings.Default.Save();
                    return true;
                }
                else
                {
                    HataliMesaj.SifreYanlis();
                }
            }
            else
            {
                HataliMesaj.KullaniciBulunamadi();
            }

            

            return false;
        }


        public bool Register(string name, string surname, string username,
            string pass, string mail, char gender, string address)
        {
            try
            {
                var user = IsCustomerReal((string)username);
                if (user == null)
                {
                    Musteriler musteri = new Musteriler();
                    musteri.Ad = name;
                    musteri.Soyad = surname;
                    musteri.Kullanici_Adi = username;
                    musteri.Sifre = pass;
                    musteri.Posta = mail;
                    musteri.Cinsiyet = gender.ToString();
                    musteri.Adres = address;
                    db.Musteriler.Add(musteri);
                    db.SaveChanges();
                    BasariliMesaj.KayitBasarili();
                    return true;
                }
                else
                {
                    HataliMesaj.KullaniciVar();
                }
            }
            catch (Exception ex)
            {
                HataliMesaj.CatchError(ex);
            }


            return false;
        }
    }
}
