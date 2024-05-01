using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikEnstrumaniDukkani.Mesajlar
{
    internal class SoruMesaj
    {
        public static SoruMesaj instance = new SoruMesaj();

        public DialogResult res;

        public void CloseApp()
        {
            res = MessageBox.Show("Çıkmak İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void KayitEminMisin()
        {
            res = MessageBox.Show("Kayıt Olmak İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        internal void EnstrumanEkle()
        {
            res = MessageBox.Show("Enstrümanı Eklemek İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void GuncelleSoru()
        {
            res = MessageBox.Show("Güncellemek İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        internal void SilSoru()
        {
            res = MessageBox.Show("Silmek İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void SatisSoru()
        {
            res = MessageBox.Show("Seçili Ürünü Satın Almak İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
