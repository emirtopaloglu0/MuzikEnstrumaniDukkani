namespace MuzikEnstrumaniDukkani.View.Customer
{
    partial class CustomerPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 92);
            this.label1.TabIndex = 11;
            this.label1.Text = "İSTEDİĞİ KADAR ÜRÜN SATIN ALABİLİR\r\nSİPARİŞLERİYLE İLGİLİ DESTEK OLUŞTURABİLİR\r\nS" +
    "İPARİŞİ 3 GÜN İÇİNDE İPTAL EDEBİLİR\r\nTÜM SİPARİŞLERİ GÖRÜNTÜLEYEBİLİR (IPTAL, TA" +
    "MAM, AKTİF)";
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Name = "CustomerPanel";
            this.Size = new System.Drawing.Size(1000, 690);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}
