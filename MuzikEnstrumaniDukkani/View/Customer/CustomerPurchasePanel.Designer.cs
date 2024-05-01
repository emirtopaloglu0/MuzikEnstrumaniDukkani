namespace MuzikEnstrumaniDukkani.View.Customer
{
    partial class CustomerPurchasePanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uretimYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enstrumanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.View_Ins = new System.Windows.Forms.Button();
            this.AddToCart_Button = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enstrumanlarBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.enstrumanlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(447, 604);
            this.dataGridView1.TabIndex = 0;
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
            this.uretimYeriDataGridViewTextBoxColumn.HeaderText = "Uretim Yeri";
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
            // enstrumanlarBindingSource
            // 
            this.enstrumanlarBindingSource.DataSource = typeof(MuzikEnstrumaniDukkani.Model.Enstrumanlar);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vurmalı",
            "Telli",
            "Yaylı",
            "Nefesli",
            "Tuşlu"});
            this.comboBox1.Location = new System.Drawing.Point(555, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 31);
            this.comboBox1.TabIndex = 17;
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Reset_Btn.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Reset_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reset_Btn.Location = new System.Drawing.Point(555, 84);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(86, 68);
            this.Reset_Btn.TabIndex = 15;
            this.Reset_Btn.Text = "Sıfırla";
            this.Reset_Btn.UseVisualStyleBackColor = false;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // View_Ins
            // 
            this.View_Ins.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.View_Ins.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.View_Ins.ForeColor = System.Drawing.SystemColors.ControlText;
            this.View_Ins.Location = new System.Drawing.Point(646, 84);
            this.View_Ins.Name = "View_Ins";
            this.View_Ins.Size = new System.Drawing.Size(259, 68);
            this.View_Ins.TabIndex = 16;
            this.View_Ins.Text = "Sadece Seçili Kategoriyi Görüntüle";
            this.View_Ins.UseVisualStyleBackColor = false;
            this.View_Ins.Click += new System.EventHandler(this.View_Ins_Click);
            // 
            // AddToCart_Button
            // 
            this.AddToCart_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddToCart_Button.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddToCart_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddToCart_Button.Location = new System.Drawing.Point(555, 424);
            this.AddToCart_Button.Name = "AddToCart_Button";
            this.AddToCart_Button.Size = new System.Drawing.Size(353, 68);
            this.AddToCart_Button.TabIndex = 16;
            this.AddToCart_Button.Text = "Sepete Ekle";
            this.AddToCart_Button.UseVisualStyleBackColor = false;
            this.AddToCart_Button.Click += new System.EventHandler(this.AddToCart_Button_Click);
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
            this.Cat_ComboBox.Location = new System.Drawing.Point(738, 237);
            this.Cat_ComboBox.Name = "Cat_ComboBox";
            this.Cat_ComboBox.Size = new System.Drawing.Size(167, 31);
            this.Cat_ComboBox.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(551, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(551, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(551, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(551, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(551, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Üretim Yeri";
            // 
            // Fiyat_TextBox
            // 
            this.Fiyat_TextBox.Enabled = false;
            this.Fiyat_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyat_TextBox.Location = new System.Drawing.Point(738, 388);
            this.Fiyat_TextBox.MaxLength = 255;
            this.Fiyat_TextBox.Name = "Fiyat_TextBox";
            this.Fiyat_TextBox.ReadOnly = true;
            this.Fiyat_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Fiyat_TextBox.TabIndex = 54;
            // 
            // Stok_TextBox
            // 
            this.Stok_TextBox.Enabled = false;
            this.Stok_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Stok_TextBox.Location = new System.Drawing.Point(738, 338);
            this.Stok_TextBox.MaxLength = 255;
            this.Stok_TextBox.Name = "Stok_TextBox";
            this.Stok_TextBox.ReadOnly = true;
            this.Stok_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Stok_TextBox.TabIndex = 53;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Name_TextBox.Enabled = false;
            this.Name_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name_TextBox.Location = new System.Drawing.Point(738, 187);
            this.Name_TextBox.MaxLength = 50;
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.ReadOnly = true;
            this.Name_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Name_TextBox.TabIndex = 51;
            // 
            // UretimYeri_TextBox
            // 
            this.UretimYeri_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UretimYeri_TextBox.Enabled = false;
            this.UretimYeri_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UretimYeri_TextBox.Location = new System.Drawing.Point(738, 288);
            this.UretimYeri_TextBox.MaxLength = 255;
            this.UretimYeri_TextBox.Name = "UretimYeri_TextBox";
            this.UretimYeri_TextBox.ReadOnly = true;
            this.UretimYeri_TextBox.Size = new System.Drawing.Size(167, 30);
            this.UretimYeri_TextBox.TabIndex = 52;
            // 
            // CustomerPurchasePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cat_ComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fiyat_TextBox);
            this.Controls.Add(this.Stok_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.UretimYeri_TextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.AddToCart_Button);
            this.Controls.Add(this.View_Ins);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerPurchasePanel";
            this.Size = new System.Drawing.Size(990, 610);
            this.Load += new System.EventHandler(this.CustomerPurchasePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enstrumanlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uretimYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource enstrumanlarBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.Button View_Ins;
        private System.Windows.Forms.Button AddToCart_Button;
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
    }
}
