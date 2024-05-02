namespace MuzikEnstrumaniDukkani.View.Customer
{
    partial class CustomerCartPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uretimYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enstrumanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cat_ComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fiyat_TextBox = new System.Windows.Forms.TextBox();
            this.Stok_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.UretimYeri_TextBox = new System.Windows.Forms.TextBox();
            this.Purch_Btn = new System.Windows.Forms.Button();
            this.Total_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Confirm_Total_Btn = new System.Windows.Forms.Button();
            this.Toplam_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enstrumanlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(634, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 68);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sepeti Temizle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Clear_Cart);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.kategoriIdDataGridViewTextBoxColumn,
            this.uretimYeriDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.Adet});
            this.dataGridView1.DataSource = this.enstrumanlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(624, 604);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriIdDataGridViewTextBoxColumn
            // 
            this.kategoriIdDataGridViewTextBoxColumn.DataPropertyName = "Kategori_Id";
            this.kategoriIdDataGridViewTextBoxColumn.HeaderText = "Kategori_Id";
            this.kategoriIdDataGridViewTextBoxColumn.Name = "kategoriIdDataGridViewTextBoxColumn";
            this.kategoriIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // uretimYeriDataGridViewTextBoxColumn
            // 
            this.uretimYeriDataGridViewTextBoxColumn.DataPropertyName = "Uretim_Yeri";
            this.uretimYeriDataGridViewTextBoxColumn.HeaderText = "Uretim_Yeri";
            this.uretimYeriDataGridViewTextBoxColumn.Name = "uretimYeriDataGridViewTextBoxColumn";
            this.uretimYeriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Adet
            // 
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.ReadOnly = true;
            // 
            // enstrumanlarBindingSource
            // 
            this.enstrumanlarBindingSource.DataSource = typeof(MuzikEnstrumaniDukkani.Model.Enstrumanlar);
            // 
            // Cat_ComboBox
            // 
            this.Cat_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cat_ComboBox.Enabled = false;
            this.Cat_ComboBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cat_ComboBox.FormattingEnabled = true;
            this.Cat_ComboBox.Items.AddRange(new object[] {
            "Vurmalı",
            "Telli",
            "Yaylı",
            "Nefesli",
            "Tuşlu"});
            this.Cat_ComboBox.Location = new System.Drawing.Point(820, 58);
            this.Cat_ComboBox.Name = "Cat_ComboBox";
            this.Cat_ComboBox.Size = new System.Drawing.Size(167, 31);
            this.Cat_ComboBox.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(633, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 66;
            this.label6.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(633, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(633, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 67;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(633, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(633, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "Üretim Yeri";
            // 
            // Fiyat_TextBox
            // 
            this.Fiyat_TextBox.Enabled = false;
            this.Fiyat_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyat_TextBox.Location = new System.Drawing.Point(820, 200);
            this.Fiyat_TextBox.MaxLength = 255;
            this.Fiyat_TextBox.Name = "Fiyat_TextBox";
            this.Fiyat_TextBox.ReadOnly = true;
            this.Fiyat_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Fiyat_TextBox.TabIndex = 64;
            // 
            // Stok_TextBox
            // 
            this.Stok_TextBox.Enabled = false;
            this.Stok_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Stok_TextBox.Location = new System.Drawing.Point(820, 153);
            this.Stok_TextBox.MaxLength = 255;
            this.Stok_TextBox.Name = "Stok_TextBox";
            this.Stok_TextBox.ReadOnly = true;
            this.Stok_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Stok_TextBox.TabIndex = 63;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Name_TextBox.Enabled = false;
            this.Name_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name_TextBox.Location = new System.Drawing.Point(820, 11);
            this.Name_TextBox.MaxLength = 50;
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.ReadOnly = true;
            this.Name_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Name_TextBox.TabIndex = 61;
            // 
            // UretimYeri_TextBox
            // 
            this.UretimYeri_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UretimYeri_TextBox.Enabled = false;
            this.UretimYeri_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UretimYeri_TextBox.Location = new System.Drawing.Point(820, 106);
            this.UretimYeri_TextBox.MaxLength = 255;
            this.UretimYeri_TextBox.Name = "UretimYeri_TextBox";
            this.UretimYeri_TextBox.ReadOnly = true;
            this.UretimYeri_TextBox.Size = new System.Drawing.Size(167, 30);
            this.UretimYeri_TextBox.TabIndex = 62;
            // 
            // Purch_Btn
            // 
            this.Purch_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Purch_Btn.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Purch_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Purch_Btn.Location = new System.Drawing.Point(634, 468);
            this.Purch_Btn.Name = "Purch_Btn";
            this.Purch_Btn.Size = new System.Drawing.Size(353, 68);
            this.Purch_Btn.TabIndex = 17;
            this.Purch_Btn.Text = "Sepeti Onayla";
            this.Purch_Btn.UseVisualStyleBackColor = false;
            this.Purch_Btn.Click += new System.EventHandler(this.Purch_Btn_Click);
            // 
            // Total_TextBox
            // 
            this.Total_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Total_TextBox.Location = new System.Drawing.Point(820, 253);
            this.Total_TextBox.MaxLength = 255;
            this.Total_TextBox.Name = "Total_TextBox";
            this.Total_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Total_TextBox.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(633, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "Adet";
            // 
            // Confirm_Total_Btn
            // 
            this.Confirm_Total_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Confirm_Total_Btn.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Confirm_Total_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Confirm_Total_Btn.Location = new System.Drawing.Point(820, 289);
            this.Confirm_Total_Btn.Name = "Confirm_Total_Btn";
            this.Confirm_Total_Btn.Size = new System.Drawing.Size(167, 43);
            this.Confirm_Total_Btn.TabIndex = 17;
            this.Confirm_Total_Btn.Text = "Adeti Onayla";
            this.Confirm_Total_Btn.UseVisualStyleBackColor = false;
            this.Confirm_Total_Btn.Click += new System.EventHandler(this.Confirm_Btn_Click);
            // 
            // Toplam_TextBox
            // 
            this.Toplam_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Toplam_TextBox.Location = new System.Drawing.Point(817, 396);
            this.Toplam_TextBox.MaxLength = 255;
            this.Toplam_TextBox.Name = "Toplam_TextBox";
            this.Toplam_TextBox.ReadOnly = true;
            this.Toplam_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Toplam_TextBox.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(630, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 66;
            this.label7.Text = "Toplam";
            // 
            // CustomerCartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cat_ComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Toplam_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Total_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fiyat_TextBox);
            this.Controls.Add(this.Stok_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.UretimYeri_TextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Confirm_Total_Btn);
            this.Controls.Add(this.Purch_Btn);
            this.Controls.Add(this.button1);
            this.Name = "CustomerCartPanel";
            this.Size = new System.Drawing.Size(990, 610);
            this.Load += new System.EventHandler(this.CustomerCartPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enstrumanlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource enstrumanlarBindingSource;
        private System.Windows.Forms.ComboBox Cat_ComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fiyat_TextBox;
        private System.Windows.Forms.TextBox Stok_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox UretimYeri_TextBox;
        private System.Windows.Forms.Button Purch_Btn;
        private System.Windows.Forms.TextBox Total_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Confirm_Total_Btn;
        private System.Windows.Forms.TextBox Toplam_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uretimYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}
