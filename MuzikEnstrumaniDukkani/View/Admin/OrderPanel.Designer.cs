namespace MuzikEnstrumaniDukkani.View.Admin
{
    partial class OrderPanel
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
            this.siparislerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ıptalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tamamlandiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıptalTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destekTalepleriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sipariş Paneli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.siparisNoDataGridViewTextBoxColumn,
            this.musteriIdDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.siparisTarihiDataGridViewTextBoxColumn,
            this.aktifDataGridViewCheckBoxColumn,
            this.ıptalDataGridViewCheckBoxColumn,
            this.tamamlandiDataGridViewCheckBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn,
            this.ıptalTarihiDataGridViewTextBoxColumn,
            this.destekTalepleriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siparislerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(980, 546);
            this.dataGridView1.TabIndex = 12;
            // 
            // siparislerBindingSource
            // 
            this.siparislerBindingSource.DataSource = typeof(MuzikEnstrumaniDukkani.Model.Siparisler);
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
            // musteriIdDataGridViewTextBoxColumn
            // 
            this.musteriIdDataGridViewTextBoxColumn.DataPropertyName = "Musteri_Id";
            this.musteriIdDataGridViewTextBoxColumn.HeaderText = "M_Id";
            this.musteriIdDataGridViewTextBoxColumn.Name = "musteriIdDataGridViewTextBoxColumn";
            this.musteriIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriIdDataGridViewTextBoxColumn.Width = 50;
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
            this.aktifDataGridViewCheckBoxColumn.Width = 50;
            // 
            // ıptalDataGridViewCheckBoxColumn
            // 
            this.ıptalDataGridViewCheckBoxColumn.DataPropertyName = "Iptal";
            this.ıptalDataGridViewCheckBoxColumn.HeaderText = "Iptal";
            this.ıptalDataGridViewCheckBoxColumn.Name = "ıptalDataGridViewCheckBoxColumn";
            this.ıptalDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ıptalDataGridViewCheckBoxColumn.Width = 50;
            // 
            // tamamlandiDataGridViewCheckBoxColumn
            // 
            this.tamamlandiDataGridViewCheckBoxColumn.DataPropertyName = "Tamamlandi";
            this.tamamlandiDataGridViewCheckBoxColumn.HeaderText = "Tamamlandi";
            this.tamamlandiDataGridViewCheckBoxColumn.Name = "tamamlandiDataGridViewCheckBoxColumn";
            this.tamamlandiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.tamamlandiDataGridViewCheckBoxColumn.Width = 70;
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
            // destekTalepleriDataGridViewTextBoxColumn
            // 
            this.destekTalepleriDataGridViewTextBoxColumn.DataPropertyName = "Destek_Talepleri";
            this.destekTalepleriDataGridViewTextBoxColumn.HeaderText = "Destek_Talepleri";
            this.destekTalepleriDataGridViewTextBoxColumn.Name = "destekTalepleriDataGridViewTextBoxColumn";
            this.destekTalepleriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "OrderPanel";
            this.Size = new System.Drawing.Size(990, 575);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource siparislerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ıptalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tamamlandiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıptalTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destekTalepleriDataGridViewTextBoxColumn;
    }
}
