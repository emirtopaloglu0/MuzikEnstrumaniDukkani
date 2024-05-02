using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikEnstrumaniDukkani.View.Admin
{
    public partial class AdminPanel : UserControl
    {
        public static AdminPanel instance;
        public AdminPanel()
        {
            InitializeComponent();
            ınstrumentPanel1.Hide();
            supportPanel1.Hide();
            orderPanel1.Show();
        }

        private void View_Ins_Click(object sender, EventArgs e)
        {
            ınstrumentPanel1.Show();
            supportPanel1.Hide();
            orderPanel1.Hide();
            InstrumentPanel.instance.LoadData();
        }

        private void View_Orders_Click(object sender, EventArgs e)
        {
            ınstrumentPanel1.Hide();
            supportPanel1.Hide();
            orderPanel1.Show();
            orderPanel1.LoadData();
        }

        private void View_Tickets_Click(object sender, EventArgs e)
        {
            ınstrumentPanel1.Hide();
            supportPanel1.Show();
            orderPanel1.Hide();
            supportPanel1.LoadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.instance.LogOut();
        }

        private void ınstrumentPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
