namespace MuzikEnstrumaniDukkani.View.Admin
{
    partial class AdminPanel
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
            this.View_Ins = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ınstrumentPanel1 = new MuzikEnstrumaniDukkani.View.Admin.InstrumentPanel();
            this.orderPanel1 = new MuzikEnstrumaniDukkani.View.Admin.OrderPanel();
            this.supportPanel1 = new MuzikEnstrumaniDukkani.View.Admin.SupportPanel();
            this.View_Orders = new System.Windows.Forms.Button();
            this.View_Tickets = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // View_Ins
            // 
            this.View_Ins.BackColor = System.Drawing.SystemColors.Info;
            this.View_Ins.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.View_Ins.ForeColor = System.Drawing.SystemColors.ControlText;
            this.View_Ins.Location = new System.Drawing.Point(3, 3);
            this.View_Ins.Name = "View_Ins";
            this.View_Ins.Size = new System.Drawing.Size(214, 68);
            this.View_Ins.TabIndex = 11;
            this.View_Ins.Text = "Enstrümanları Görüntüle";
            this.View_Ins.UseVisualStyleBackColor = false;
            this.View_Ins.Click += new System.EventHandler(this.View_Ins_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ınstrumentPanel1);
            this.panel1.Controls.Add(this.orderPanel1);
            this.panel1.Controls.Add(this.supportPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 580);
            this.panel1.TabIndex = 12;
            // 
            // ınstrumentPanel1
            // 
            this.ınstrumentPanel1.Location = new System.Drawing.Point(1, 2);
            this.ınstrumentPanel1.Name = "ınstrumentPanel1";
            this.ınstrumentPanel1.Size = new System.Drawing.Size(990, 575);
            this.ınstrumentPanel1.TabIndex = 2;
            this.ınstrumentPanel1.Load += new System.EventHandler(this.ınstrumentPanel1_Load);
            // 
            // orderPanel1
            // 
            this.orderPanel1.Location = new System.Drawing.Point(1, 5);
            this.orderPanel1.Name = "orderPanel1";
            this.orderPanel1.Size = new System.Drawing.Size(990, 575);
            this.orderPanel1.TabIndex = 1;
            // 
            // supportPanel1
            // 
            this.supportPanel1.Location = new System.Drawing.Point(4, 2);
            this.supportPanel1.Name = "supportPanel1";
            this.supportPanel1.Size = new System.Drawing.Size(990, 575);
            this.supportPanel1.TabIndex = 0;
            // 
            // View_Orders
            // 
            this.View_Orders.BackColor = System.Drawing.SystemColors.Info;
            this.View_Orders.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.View_Orders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.View_Orders.Location = new System.Drawing.Point(393, 3);
            this.View_Orders.Name = "View_Orders";
            this.View_Orders.Size = new System.Drawing.Size(214, 68);
            this.View_Orders.TabIndex = 11;
            this.View_Orders.Text = "Siparişleri Görüntüle";
            this.View_Orders.UseVisualStyleBackColor = false;
            this.View_Orders.Click += new System.EventHandler(this.View_Orders_Click);
            // 
            // View_Tickets
            // 
            this.View_Tickets.BackColor = System.Drawing.SystemColors.Info;
            this.View_Tickets.Font = new System.Drawing.Font("Figtree Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.View_Tickets.ForeColor = System.Drawing.SystemColors.ControlText;
            this.View_Tickets.Location = new System.Drawing.Point(783, 3);
            this.View_Tickets.Name = "View_Tickets";
            this.View_Tickets.Size = new System.Drawing.Size(214, 68);
            this.View_Tickets.TabIndex = 11;
            this.View_Tickets.Text = "Destek Taleplerini Görüntüle";
            this.View_Tickets.UseVisualStyleBackColor = false;
            this.View_Tickets.Click += new System.EventHandler(this.View_Tickets_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MuzikEnstrumaniDukkani.Properties.Resources.logout1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 652);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.View_Tickets);
            this.Controls.Add(this.View_Orders);
            this.Controls.Add(this.View_Ins);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(1000, 690);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button View_Ins;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button View_Orders;
        private System.Windows.Forms.Button View_Tickets;
        private SupportPanel supportPanel1;
        private OrderPanel orderPanel1;
        private InstrumentPanel ınstrumentPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
