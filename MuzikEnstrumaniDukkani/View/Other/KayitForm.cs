using MuzikEnstrumaniDukkani.Class;
using MuzikEnstrumaniDukkani.Mesajlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikEnstrumaniDukkani.View.Other
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password_Textbox.PasswordChar = '\0';
            }
            else
            {
                Password_Textbox.PasswordChar = '*';

            }
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;

            char[] charsToTrim = Form1.instance.charsToTrim;

            textbox.Text = textbox.Text.Trim(charsToTrim);
            textbox.SelectionStart = textbox.Text.Length;
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            SoruMesaj.instance.KayitEminMisin();
            if (SoruMesaj.instance.res != DialogResult.Yes)
            { return; }

            if (Name_TextBox != null && LastName_TextBox != null && Username_Textbox != null
            && Password_Textbox != null && Mail_TextBox != null 
            && (Male_RadioBtn.Checked || Female_RadioBtn.Checked)
            && Address_RichTextBox != null)
            {
                char gender;
                if (Male_RadioBtn.Checked)
                    gender = 'E';
                else
                    gender = 'K';

                if (Customers.instance.Register(Name_TextBox.Text, LastName_TextBox.Text, Username_Textbox.Text,
                    Password_Textbox.Text, Mail_TextBox.Text, gender, Address_RichTextBox.Text))
                {
                    Form1.instance.ShowLoadingScreen();
                    Close();
                }


            }
            else
            {
                HataliMesaj.BosBirakmayin();
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            SoruMesaj.instance.CloseApp();
            if (SoruMesaj.instance.res == DialogResult.Yes)
            {
                Form1.instance.ShowLoadingScreen();

                Close();
            }
        }
    }
}
