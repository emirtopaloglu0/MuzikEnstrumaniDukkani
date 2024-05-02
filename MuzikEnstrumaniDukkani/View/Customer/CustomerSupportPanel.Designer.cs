namespace MuzikEnstrumaniDukkani.View.Customer
{
    partial class CustomerSupportPanel
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
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Purch_Btn = new System.Windows.Forms.Button();
            this.Talep_TextBox = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tamamlandiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparislerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.siparisNoDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.siparisTarihiDataGridViewTextBoxColumn,
            this.aktifDataGridViewCheckBoxColumn,
            this.tamamlandiDataGridViewCheckBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.siparislerBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(618, 604);
            this.dataGridView5.TabIndex = 1;
            // 
            // Purch_Btn
            // 
            this.Purch_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Purch_Btn.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Purch_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Purch_Btn.Location = new System.Drawing.Point(627, 453);
            this.Purch_Btn.Name = "Purch_Btn";
            this.Purch_Btn.Size = new System.Drawing.Size(360, 68);
            this.Purch_Btn.TabIndex = 18;
            this.Purch_Btn.Text = "Talep Oluştur";
            this.Purch_Btn.UseVisualStyleBackColor = false;
            this.Purch_Btn.Click += new System.EventHandler(this.Support_Btn_Click);
            // 
            // Talep_TextBox
            // 
            this.Talep_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Talep_TextBox.Location = new System.Drawing.Point(740, 286);
            this.Talep_TextBox.Name = "Talep_TextBox";
            this.Talep_TextBox.Size = new System.Drawing.Size(247, 96);
            this.Talep_TextBox.TabIndex = 19;
            this.Talep_TextBox.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Eksik Ürün",
            "Arızalı Ürün",
            "Yanlış Ürün",
            "Kargo/Adres",
            "Diğer"});
            this.comboBox1.Location = new System.Drawing.Point(740, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 31);
            this.comboBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(627, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Şikayetiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(627, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 46);
            this.label2.TabIndex = 70;
            this.label2.Text = "Şikayet\r\nTürü";
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // siparisNoDataGridViewTextBoxColumn
            // 
            this.siparisNoDataGridViewTextBoxColumn.DataPropertyName = "Siparis_No";
            this.siparisNoDataGridViewTextBoxColumn.HeaderText = "Siparis_No";
            this.siparisNoDataGridViewTextBoxColumn.Name = "siparisNoDataGridViewTextBoxColumn";
            this.siparisNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            this.tutarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisTarihiDataGridViewTextBoxColumn
            // 
            this.siparisTarihiDataGridViewTextBoxColumn.DataPropertyName = "Siparis_Tarihi";
            this.siparisTarihiDataGridViewTextBoxColumn.HeaderText = "Siparis_Tarihi";
            this.siparisTarihiDataGridViewTextBoxColumn.Name = "siparisTarihiDataGridViewTextBoxColumn";
            this.siparisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            this.aktifDataGridViewCheckBoxColumn.DataPropertyName = "Aktif";
            this.aktifDataGridViewCheckBoxColumn.HeaderText = "Aktif";
            this.aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            this.aktifDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aktifDataGridViewCheckBoxColumn.Width = 40;
            // 
            // tamamlandiDataGridViewCheckBoxColumn
            // 
            this.tamamlandiDataGridViewCheckBoxColumn.DataPropertyName = "Tamamlandi";
            this.tamamlandiDataGridViewCheckBoxColumn.HeaderText = "Tamamlandi";
            this.tamamlandiDataGridViewCheckBoxColumn.Name = "tamamlandiDataGridViewCheckBoxColumn";
            this.tamamlandiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.tamamlandiDataGridViewCheckBoxColumn.Width = 80;
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "Teslim_Tarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "Teslim_Tarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            this.teslimTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparislerBindingSource
            // 
            this.siparislerBindingSource.DataSource = typeof(MuzikEnstrumaniDukkani.Model.Siparisler);
            // 
            // CustomerSupportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Talep_TextBox);
            this.Controls.Add(this.Purch_Btn);
            this.Controls.Add(this.dataGridView5);
            this.Name = "CustomerSupportPanel";
            this.Size = new System.Drawing.Size(990, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource siparislerBindingSource;
        private System.Windows.Forms.Button Purch_Btn;
        private System.Windows.Forms.RichTextBox Talep_TextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tamamlandiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
    }
}
