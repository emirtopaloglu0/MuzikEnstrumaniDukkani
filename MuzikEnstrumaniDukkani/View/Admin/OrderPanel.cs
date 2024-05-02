using MuzikEnstrumaniDukkani.Class;
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
    public partial class OrderPanel : UserControl
    {
        public OrderPanel()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            var orders = DB_Connection.db.Siparisler.ToList();
            dataGridView1.DataSource = orders;
        }
    }
}
