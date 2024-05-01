using MuzikEnstrumaniDukkani.Class;
using MuzikEnstrumaniDukkani.Mesajlar;
using MuzikEnstrumaniDukkani.Model;
using MuzikEnstrumaniDukkani.Properties;
using MuzikEnstrumaniDukkani.View.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikEnstrumaniDukkani
{
    public partial class Form1 : Form
    {
        public static Form1 instance = new Form1();

        public char[] charsToTrim = { '*', ' ', '\'', '_', '-', '+', '$', '!', '^', '#', '%', '&', '/', '?', '(', ')', '=', '<', '>', '|', '£', '½', '{', '[', ']', '}' };

        public string pool = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public List<int> Cart = new List<int>();

        public Form1()
        {
            InitializeComponent();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            SoruMesaj.instance.CloseApp();
            if (SoruMesaj.instance.res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerPanel1.Hide();
            adminPanel1.Hide();
            Settings.Default.UserId = 0;
            Settings.Default.Save();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Customers.instance.LogIn(User_TextBox.Text, Pass_TextBox.Text))
                {
                    if (Customers.instance.IsAdmin)
                    {
                        customerPanel1.Hide();
                        adminPanel1.Show();
                    }
                    else
                    {
                        customerPanel1.Show();
                        //customerPanel1.instance.LoadOrdersData();
                        adminPanel1.Hide();
                    }
                    pictureBox2.Dispose(); //giriş yapılırsa kaybolacak
                    User_TextBox.Text = "";
                    Pass_TextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                HataliMesaj.CatchError(ex);
            }

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Hide();
                KayitForm f2 = new KayitForm();
                f2.ShowDialog();
            }
            catch (Exception ex)
            {
                HataliMesaj.CatchError(ex);
            }
        }

        public void ShowLoadingScreen()
        {
            pictureBox2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Pass_TextBox.PasswordChar = '\0';
            }
            else
            {
                Pass_TextBox.PasswordChar = '*';
            }
        }

        private void Pass_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                LoginBtn_Click(sender, e);
            }
        }

        private void User_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                LoginBtn_Click(sender, e);
            }
        }

        public void LogOut()
        {
            adminPanel1.Hide();
            customerPanel1.Hide();
        }

        private void Restart_Button(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
