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

        internal static void AdetYanlis()
        {
            MessageBox.Show("Lütfen adetleri doğru giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        internal static void SatiriSeciniz()
        {
            MessageBox.Show("Satırı düzgün seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void SepetteVar()
        {
            MessageBox.Show("Eklemeye çalıştığınız ürün zaten sepetinizde bulunuyor!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void SifreYanlis()
        {
            MessageBox.Show("Hatalı şifre! Lütfen tekrar deneyin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void SiparisZamanAsimi()
        {
            MessageBox.Show("Siparişinizin üstünden 3 gün geçtiği için iptal edemezsiniz!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void StokHatasi()
        {
            MessageBox.Show("Stok adedinden fazla satın alım yapmaya çalıştınız. Lütfen tekrar deneyin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
