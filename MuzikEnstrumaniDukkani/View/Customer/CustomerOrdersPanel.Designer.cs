namespace MuzikEnstrumaniDukkani.View.Customer
{
    partial class CustomerOrdersPanel
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
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ıptalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tamamlandiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıptalTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparislerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Purch_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.ıptalDataGridViewCheckBoxColumn,
            this.tamamlandiDataGridViewCheckBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn,
            this.ıptalTarihiDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.siparislerBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(660, 604);
            this.dataGridView5.TabIndex = 0;
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
            // ıptalDataGridViewCheckBoxColumn
            // 
            this.ıptalDataGridViewCheckBoxColumn.DataPropertyName = "Iptal";
            this.ıptalDataGridViewCheckBoxColumn.HeaderText = "Iptal";
            this.ıptalDataGridViewCheckBoxColumn.Name = "ıptalDataGridViewCheckBoxColumn";
            this.ıptalDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ıptalDataGridViewCheckBoxColumn.Width = 40;
            // 
            // tamamlandiDataGridViewCheckBoxColumn
            // 
            this.tamamlandiDataGridViewCheckBoxColumn.DataPropertyName = "Tamamlandi";
            this.tamamlandiDataGridViewCheckBoxColumn.HeaderText = "Tamamlandi";
            this.tamamlandiDataGridViewCheckBoxColumn.Name = "tamamlandiDataGridViewCheckBoxColumn";
            this.tamamlandiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.tamamlandiDataGridViewCheckBoxColumn.Width = 40;
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "Teslim_Tarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "Teslim_Tarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            this.teslimTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıptalTarihiDataGridViewTextBoxColumn
            // 
            this.ıptalTarihiDataGridViewTextBoxColumn.DataPropertyName = "Iptal_Tarihi";
            this.ıptalTarihiDataGridViewTextBoxColumn.HeaderText = "Iptal_Tarihi";
            this.ıptalTarihiDataGridViewTextBoxColumn.Name = "ıptalTarihiDataGridViewTextBoxColumn";
            this.ıptalTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparislerBindingSource
            // 
            this.siparislerBindingSource.DataSource = typeof(MuzikEnstrumaniDukkani.Model.Siparisler);
            // 
            // Purch_Btn
            // 
            this.Purch_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Purch_Btn.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Purch_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Purch_Btn.Location = new System.Drawing.Point(669, 539);
            this.Purch_Btn.Name = "Purch_Btn";
            this.Purch_Btn.Size = new System.Drawing.Size(318, 68);
            this.Purch_Btn.TabIndex = 18;
            this.Purch_Btn.Text = "Seçili Siparişi İptal Et";
            this.Purch_Btn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(669, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 68);
            this.button1.TabIndex = 18;
            this.button1.Text = "Aktif Siparişleri Göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Active_Orders);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(672, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 68);
            this.button2.TabIndex = 18;
            this.button2.Text = "İptal Edilen Siparişleri Göster";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Cancelled_Orders);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(669, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(318, 68);
            this.button3.TabIndex = 18;
            this.button3.Text = "Teslim Edilmiş Siparişleri Göster";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Delivered_Orders);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(669, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(318, 68);
            this.button4.TabIndex = 18;
            this.button4.Text = "Tüm Siparişleri Göster";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.All_Orders);
            // 
            // CustomerOrdersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Purch_Btn);
            this.Controls.Add(this.dataGridView5);
            this.Name = "CustomerOrdersPanel";
            this.Size = new System.Drawing.Size(990, 610);
            this.Load += new System.EventHandler(this.CustomerOrdersPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ıptalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tamamlandiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıptalTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource siparislerBindingSource;
        private System.Windows.Forms.Button Purch_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
