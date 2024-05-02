namespace MuzikEnstrumaniDukkani.View.Admin
{
    partial class SupportPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destekKategoriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminCevapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okunduDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ıslemeAlindiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tamamlandiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.destekTalepleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Admin_Mesaj = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destekTalepleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Destek Paneli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.siparisIdDataGridViewTextBoxColumn,
            this.destekKategoriIdDataGridViewTextBoxColumn,
            this.talepDataGridViewTextBoxColumn,
            this.adminCevapDataGridViewTextBoxColumn,
            this.okunduDataGridViewCheckBoxColumn,
            this.ıslemeAlindiDataGridViewCheckBoxColumn,
            this.tamamlandiDataGridViewCheckBoxColumn,
            this.aktifDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.destekTalepleriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 536);
            this.dataGridView1.TabIndex = 11;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // siparisIdDataGridViewTextBoxColumn
            // 
            this.siparisIdDataGridViewTextBoxColumn.DataPropertyName = "Siparis_Id";
            this.siparisIdDataGridViewTextBoxColumn.HeaderText = "Siparis_Id";
            this.siparisIdDataGridViewTextBoxColumn.Name = "siparisIdDataGridViewTextBoxColumn";
            this.siparisIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.siparisIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // destekKategoriIdDataGridViewTextBoxColumn
            // 
            this.destekKategoriIdDataGridViewTextBoxColumn.DataPropertyName = "Destek_Kategori_Id";
            this.destekKategoriIdDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.destekKategoriIdDataGridViewTextBoxColumn.Name = "destekKategoriIdDataGridViewTextBoxColumn";
            this.destekKategoriIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.destekKategoriIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // talepDataGridViewTextBoxColumn
            // 
            this.talepDataGridViewTextBoxColumn.DataPropertyName = "Talep";
            this.talepDataGridViewTextBoxColumn.HeaderText = "Talep";
            this.talepDataGridViewTextBoxColumn.Name = "talepDataGridViewTextBoxColumn";
            this.talepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminCevapDataGridViewTextBoxColumn
            // 
            this.adminCevapDataGridViewTextBoxColumn.DataPropertyName = "Admin_Cevap";
            this.adminCevapDataGridViewTextBoxColumn.HeaderText = "Cevap";
            this.adminCevapDataGridViewTextBoxColumn.Name = "adminCevapDataGridViewTextBoxColumn";
            this.adminCevapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okunduDataGridViewCheckBoxColumn
            // 
            this.okunduDataGridViewCheckBoxColumn.DataPropertyName = "Okundu";
            this.okunduDataGridViewCheckBoxColumn.HeaderText = "Okundu";
            this.okunduDataGridViewCheckBoxColumn.Name = "okunduDataGridViewCheckBoxColumn";
            this.okunduDataGridViewCheckBoxColumn.ReadOnly = true;
            this.okunduDataGridViewCheckBoxColumn.Width = 50;
            // 
            // ıslemeAlindiDataGridViewCheckBoxColumn
            // 
            this.ıslemeAlindiDataGridViewCheckBoxColumn.DataPropertyName = "Isleme_Alindi";
            this.ıslemeAlindiDataGridViewCheckBoxColumn.HeaderText = "İşlemde";
            this.ıslemeAlindiDataGridViewCheckBoxColumn.Name = "ıslemeAlindiDataGridViewCheckBoxColumn";
            this.ıslemeAlindiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ıslemeAlindiDataGridViewCheckBoxColumn.Width = 50;
            // 
            // tamamlandiDataGridViewCheckBoxColumn
            // 
            this.tamamlandiDataGridViewCheckBoxColumn.DataPropertyName = "Tamamlandi";
            this.tamamlandiDataGridViewCheckBoxColumn.HeaderText = "Tamamlandi";
            this.tamamlandiDataGridViewCheckBoxColumn.Name = "tamamlandiDataGridViewCheckBoxColumn";
            this.tamamlandiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.tamamlandiDataGridViewCheckBoxColumn.Width = 50;
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            this.aktifDataGridViewCheckBoxColumn.DataPropertyName = "Aktif";
            this.aktifDataGridViewCheckBoxColumn.HeaderText = "Aktif";
            this.aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            this.aktifDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aktifDataGridViewCheckBoxColumn.Width = 50;
            // 
            // destekTalepleriBindingSource
            // 
            this.destekTalepleriBindingSource.DataSource = typeof(MuzikEnstrumaniDukkani.Model.Destek_Talepleri);
            // 
            // Admin_Mesaj
            // 
            this.Admin_Mesaj.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Admin_Mesaj.Location = new System.Drawing.Point(558, 36);
            this.Admin_Mesaj.Name = "Admin_Mesaj";
            this.Admin_Mesaj.Size = new System.Drawing.Size(429, 169);
            this.Admin_Mesaj.TabIndex = 12;
            this.Admin_Mesaj.Text = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(597, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 68);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cevabı Gönder";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Send_Respond);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(597, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 68);
            this.button1.TabIndex = 15;
            this.button1.Text = "Seçili Sorunu Tamamlandı Olarak İşaretle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Done_Btn);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(597, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 68);
            this.button2.TabIndex = 15;
            this.button2.Text = "Seçili Sorunu \"İşleme Alındı\" Olarak İşaretle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SupportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Admin_Mesaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "SupportPanel";
            this.Size = new System.Drawing.Size(990, 575);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destekTalepleriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource destekTalepleriBindingSource;
        private System.Windows.Forms.RichTextBox Admin_Mesaj;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destekKategoriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminCevapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn okunduDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ıslemeAlindiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tamamlandiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
