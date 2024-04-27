using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikEnstrumaniDukkani.Mesajlar
{
    internal class HataliMesaj
    {
        public static void CatchError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void BosBirakmayin()
        {
            MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olun!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void KullaniciBulunamadi()
        {
            MessageBox.Show("Böyle bir kullanıcı bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void KullaniciVar()
        {
            MessageBox.Show("Yazdığınız kullanıcı adı alınmıştır. Lütfen başka bir kullanıcı adı seçiniz.!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void SifreYanlis()
        {
            MessageBox.Show("Hatalı şifre! Lütfen tekrar deneyin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
