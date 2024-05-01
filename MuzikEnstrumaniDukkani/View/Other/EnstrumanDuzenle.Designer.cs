namespace MuzikEnstrumaniDukkani.View.Other
{
    partial class EnstrumanDuzenle
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
            this.Cat_ComboBox = new System.Windows.Forms.ComboBox();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Register_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fiyat_TextBox = new System.Windows.Forms.TextBox();
            this.Stok_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.UretimYeri_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cat_ComboBox
            // 
            this.Cat_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cat_ComboBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cat_ComboBox.FormattingEnabled = true;
            this.Cat_ComboBox.Items.AddRange(new object[] {
            "Vurmalı",
            "Telli",
            "Yaylı",
            "Nefesli",
            "Tuşlu"});
            this.Cat_ComboBox.Location = new System.Drawing.Point(223, 62);
            this.Cat_ComboBox.Name = "Cat_ComboBox";
            this.Cat_ComboBox.Size = new System.Drawing.Size(167, 31);
            this.Cat_ComboBox.TabIndex = 62;
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.BackColor = System.Drawing.Color.Red;
            this.Cancel_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cancel_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cancel_Btn.Location = new System.Drawing.Point(233, 384);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(167, 54);
            this.Cancel_Btn.TabIndex = 56;
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
            this.Register_Btn.TabIndex = 55;
            this.Register_Btn.Text = "Enstrüman Düzenle";
            this.Register_Btn.UseVisualStyleBackColor = false;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 58;
            this.label6.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Üretim Yeri";
            // 
            // Fiyat_TextBox
            // 
            this.Fiyat_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyat_TextBox.Location = new System.Drawing.Point(223, 213);
            this.Fiyat_TextBox.MaxLength = 255;
            this.Fiyat_TextBox.Name = "Fiyat_TextBox";
            this.Fiyat_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Fiyat_TextBox.TabIndex = 54;
            // 
            // Stok_TextBox
            // 
            this.Stok_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Stok_TextBox.Location = new System.Drawing.Point(223, 163);
            this.Stok_TextBox.MaxLength = 255;
            this.Stok_TextBox.Name = "Stok_TextBox";
            this.Stok_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Stok_TextBox.TabIndex = 53;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Name_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name_TextBox.Location = new System.Drawing.Point(223, 12);
            this.Name_TextBox.MaxLength = 50;
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Name_TextBox.TabIndex = 51;
            // 
            // UretimYeri_TextBox
            // 
            this.UretimYeri_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UretimYeri_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UretimYeri_TextBox.Location = new System.Drawing.Point(223, 113);
            this.UretimYeri_TextBox.MaxLength = 255;
            this.UretimYeri_TextBox.Name = "UretimYeri_TextBox";
            this.UretimYeri_TextBox.Size = new System.Drawing.Size(167, 30);
            this.UretimYeri_TextBox.TabIndex = 52;
            // 
            // EnstrumanDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.Cat_ComboBox);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Register_Btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fiyat_TextBox);
            this.Controls.Add(this.Stok_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.UretimYeri_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnstrumanDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnstrumanDuzenle";
            this.Load += new System.EventHandler(this.EnstrumanDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cat_ComboBox;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Register_Btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fiyat_TextBox;
        private System.Windows.Forms.TextBox Stok_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox UretimYeri_TextBox;
    }
}