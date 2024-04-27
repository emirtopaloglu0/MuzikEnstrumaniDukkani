namespace MuzikEnstrumaniDukkani.View.Other
{
    partial class KayitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Register_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Address_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Mail_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Male_RadioBtn = new System.Windows.Forms.RadioButton();
            this.Female_RadioBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Figtree", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(109, 130);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.BackColor = System.Drawing.Color.Red;
            this.Cancel_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cancel_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cancel_Btn.Location = new System.Drawing.Point(233, 384);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(167, 54);
            this.Cancel_Btn.TabIndex = 10;
            this.Cancel_Btn.Text = "İptal Et";
            this.Cancel_Btn.UseVisualStyleBackColor = false;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Register_Btn
            // 
            this.Register_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Register_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Register_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Register_Btn.Location = new System.Drawing.Point(12, 384);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(167, 54);
            this.Register_Btn.TabIndex = 9;
            this.Register_Btn.Text = "Kayıt İşlemini Tamamla";
            this.Register_Btn.UseVisualStyleBackColor = false;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Password_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Password_Textbox.Location = new System.Drawing.Point(223, 120);
            this.Password_Textbox.MaxLength = 10;
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.PasswordChar = '*';
            this.Password_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Password_Textbox.TabIndex = 4;
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Username_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Username_Textbox.Location = new System.Drawing.Point(223, 84);
            this.Username_Textbox.MaxLength = 20;
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Username_Textbox.TabIndex = 3;
            this.Username_Textbox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.LastName_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastName_TextBox.Location = new System.Drawing.Point(223, 48);
            this.LastName_TextBox.MaxLength = 50;
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(167, 30);
            this.LastName_TextBox.TabIndex = 2;
            this.LastName_TextBox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Soyad";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Name_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name_TextBox.Location = new System.Drawing.Point(223, 12);
            this.Name_TextBox.MaxLength = 50;
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Name_TextBox.TabIndex = 1;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Adres";
            // 
            // Address_RichTextBox
            // 
            this.Address_RichTextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Address_RichTextBox.Location = new System.Drawing.Point(223, 242);
            this.Address_RichTextBox.Name = "Address_RichTextBox";
            this.Address_RichTextBox.Size = new System.Drawing.Size(167, 37);
            this.Address_RichTextBox.TabIndex = 8;
            this.Address_RichTextBox.Text = "";
            // 
            // Mail_TextBox
            // 
            this.Mail_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Mail_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mail_TextBox.Location = new System.Drawing.Point(223, 156);
            this.Mail_TextBox.MaxLength = 255;
            this.Mail_TextBox.Name = "Mail_TextBox";
            this.Mail_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Mail_TextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "E-Posta";
            // 
            // Male_RadioBtn
            // 
            this.Male_RadioBtn.AutoSize = true;
            this.Male_RadioBtn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Male_RadioBtn.Location = new System.Drawing.Point(223, 199);
            this.Male_RadioBtn.Name = "Male_RadioBtn";
            this.Male_RadioBtn.Size = new System.Drawing.Size(77, 27);
            this.Male_RadioBtn.TabIndex = 6;
            this.Male_RadioBtn.TabStop = true;
            this.Male_RadioBtn.Text = "Erkek";
            this.Male_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // Female_RadioBtn
            // 
            this.Female_RadioBtn.AutoSize = true;
            this.Female_RadioBtn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Female_RadioBtn.Location = new System.Drawing.Point(313, 199);
            this.Female_RadioBtn.Name = "Female_RadioBtn";
            this.Female_RadioBtn.Size = new System.Drawing.Size(77, 27);
            this.Female_RadioBtn.TabIndex = 7;
            this.Female_RadioBtn.TabStop = true;
            this.Female_RadioBtn.Text = "Kadın";
            this.Female_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(18, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cinsiyet";
            // 
            // KayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.Female_RadioBtn);
            this.Controls.Add(this.Male_RadioBtn);
            this.Controls.Add(this.Address_RichTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Register_Btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mail_TextBox);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.LastName_TextBox);
            this.Controls.Add(this.Username_Textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KayitForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Register_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.TextBox Username_Textbox;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Address_RichTextBox;
        private System.Windows.Forms.TextBox Mail_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Male_RadioBtn;
        private System.Windows.Forms.RadioButton Female_RadioBtn;
        private System.Windows.Forms.Label label7;
    }
}