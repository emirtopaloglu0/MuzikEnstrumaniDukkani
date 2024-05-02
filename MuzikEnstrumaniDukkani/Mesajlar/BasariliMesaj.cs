using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikEnstrumaniDukkani.Mesajlar
{
    internal class BasariliMesaj
    {
        internal static void KayitBasarili()
        {
            MessageBox.Show("Kayıt İşlemi Başarılı! \nHoş gedliniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal static void EnstrumanEklendi()
        {
            MessageBox.Show("Enstürman Başarıyla Eklendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void GuncellmeBasarili()
        {
            MessageBox.Show("Enstürman Başarıyla Güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void SilmeBasarili()
        {
            MessageBox.Show("Enstürman Başarıyla Silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void SatinAlim()
        {
            MessageBox.Show("Sipariş Başarıyla Oluşturulmuştur!\nSiparişinizi 3 gün içerisinde iptal edebilirsiniz." +
                "\nEğer iptal edilmezse teslimat yapılacaktır\nİyi günlerde kullanın!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void SiparisIptalEdildi()
        {
            MessageBox.Show("Siparişiniz Başarılı Bir Şekilde İptal Edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void DestekOlustu()
        {
            MessageBox.Show("Destek Talebiniz Başarıyla oluşturuldu.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
