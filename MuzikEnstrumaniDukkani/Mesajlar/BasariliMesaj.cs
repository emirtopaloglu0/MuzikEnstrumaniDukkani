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
    }
}
