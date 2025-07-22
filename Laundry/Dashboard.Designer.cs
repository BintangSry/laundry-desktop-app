namespace Laundry
{
    partial class Dashboard
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
            this.topbarPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.pembayaran_btn = new System.Windows.Forms.Button();
            this.layanan_btn = new System.Windows.Forms.Button();
            this.detail_btn = new System.Windows.Forms.Button();
            this.pesanan_btn = new System.Windows.Forms.Button();
            this.user_btn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.topbarPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbarPanel
            // 
            this.topbarPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.topbarPanel.Controls.Add(this.panel2);
            this.topbarPanel.Controls.Add(this.logout_btn);
            this.topbarPanel.Controls.Add(this.label1);
            this.topbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbarPanel.Location = new System.Drawing.Point(0, 0);
            this.topbarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topbarPanel.Name = "topbarPanel";
            this.topbarPanel.Size = new System.Drawing.Size(800, 40);
            this.topbarPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 407);
            this.panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Red;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.logout_btn.Location = new System.Drawing.Point(725, 0);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 40);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manajemen Laundry";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.DarkGray;
            this.sidebarPanel.Controls.Add(this.pembayaran_btn);
            this.sidebarPanel.Controls.Add(this.layanan_btn);
            this.sidebarPanel.Controls.Add(this.detail_btn);
            this.sidebarPanel.Controls.Add(this.pesanan_btn);
            this.sidebarPanel.Controls.Add(this.user_btn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 40);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 410);
            this.sidebarPanel.TabIndex = 1;
            // 
            // pembayaran_btn
            // 
            this.pembayaran_btn.BackColor = System.Drawing.Color.Transparent;
            this.pembayaran_btn.FlatAppearance.BorderSize = 0;
            this.pembayaran_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.pembayaran_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pembayaran_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pembayaran_btn.Location = new System.Drawing.Point(0, 185);
            this.pembayaran_btn.Name = "pembayaran_btn";
            this.pembayaran_btn.Size = new System.Drawing.Size(200, 40);
            this.pembayaran_btn.TabIndex = 4;
            this.pembayaran_btn.Text = "Data Pembayaran";
            this.pembayaran_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pembayaran_btn.UseVisualStyleBackColor = false;
            this.pembayaran_btn.Click += new System.EventHandler(this.pembayaran_btn_Click);
            // 
            // layanan_btn
            // 
            this.layanan_btn.BackColor = System.Drawing.Color.Transparent;
            this.layanan_btn.FlatAppearance.BorderSize = 0;
            this.layanan_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.layanan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.layanan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layanan_btn.Location = new System.Drawing.Point(0, 137);
            this.layanan_btn.Name = "layanan_btn";
            this.layanan_btn.Size = new System.Drawing.Size(200, 40);
            this.layanan_btn.TabIndex = 3;
            this.layanan_btn.Text = "Manajemen Layanan";
            this.layanan_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.layanan_btn.UseVisualStyleBackColor = false;
            this.layanan_btn.Click += new System.EventHandler(this.layanan_btn_Click);
            // 
            // detail_btn
            // 
            this.detail_btn.BackColor = System.Drawing.Color.Transparent;
            this.detail_btn.FlatAppearance.BorderSize = 0;
            this.detail_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.detail_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_btn.Location = new System.Drawing.Point(0, 91);
            this.detail_btn.Name = "detail_btn";
            this.detail_btn.Size = new System.Drawing.Size(200, 40);
            this.detail_btn.TabIndex = 2;
            this.detail_btn.Text = "Detail Pesanan";
            this.detail_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detail_btn.UseVisualStyleBackColor = false;
            this.detail_btn.Click += new System.EventHandler(this.detail_btn_Click);
            // 
            // pesanan_btn
            // 
            this.pesanan_btn.BackColor = System.Drawing.Color.Transparent;
            this.pesanan_btn.FlatAppearance.BorderSize = 0;
            this.pesanan_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.pesanan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesanan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesanan_btn.Location = new System.Drawing.Point(0, 45);
            this.pesanan_btn.Name = "pesanan_btn";
            this.pesanan_btn.Size = new System.Drawing.Size(200, 40);
            this.pesanan_btn.TabIndex = 1;
            this.pesanan_btn.Text = "Data Pesanan";
            this.pesanan_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesanan_btn.UseVisualStyleBackColor = false;
            this.pesanan_btn.Click += new System.EventHandler(this.pesanan_btn_Click);
            // 
            // user_btn
            // 
            this.user_btn.BackColor = System.Drawing.Color.Transparent;
            this.user_btn.FlatAppearance.BorderSize = 0;
            this.user_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.user_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_btn.Location = new System.Drawing.Point(0, -1);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(200, 40);
            this.user_btn.TabIndex = 0;
            this.user_btn.Text = "Manajemen user";
            this.user_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_btn.UseVisualStyleBackColor = false;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 410);
            this.mainPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.topbarPanel);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Laundry";
            this.topbarPanel.ResumeLayout(false);
            this.topbarPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topbarPanel;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Button pesanan_btn;
        private System.Windows.Forms.Button detail_btn;
        private System.Windows.Forms.Button pembayaran_btn;
        private System.Windows.Forms.Button layanan_btn;
        private System.Windows.Forms.Panel mainPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}