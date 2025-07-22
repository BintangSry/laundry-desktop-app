namespace Laundry
{
    partial class Pesanan
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
            this.actionPanel = new System.Windows.Forms.Panel();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.tambah_btn = new System.Windows.Forms.Button();
            this.dataGridPesanan = new System.Windows.Forms.DataGridView();
            this.selesai_btn = new System.Windows.Forms.Button();
            this.actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.LightGray;
            this.actionPanel.Controls.Add(this.selesai_btn);
            this.actionPanel.Controls.Add(this.Delete_btn);
            this.actionPanel.Controls.Add(this.tambah_btn);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionPanel.Location = new System.Drawing.Point(0, 0);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(600, 40);
            this.actionPanel.TabIndex = 1;
            this.actionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.actionPanel_Paint);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Red;
            this.Delete_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Delete_btn.Location = new System.Drawing.Point(75, 0);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 40);
            this.Delete_btn.TabIndex = 2;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // tambah_btn
            // 
            this.tambah_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tambah_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.tambah_btn.FlatAppearance.BorderSize = 0;
            this.tambah_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tambah_btn.Location = new System.Drawing.Point(0, 0);
            this.tambah_btn.Name = "tambah_btn";
            this.tambah_btn.Size = new System.Drawing.Size(75, 40);
            this.tambah_btn.TabIndex = 0;
            this.tambah_btn.Text = "Tambah";
            this.tambah_btn.UseVisualStyleBackColor = false;
            this.tambah_btn.Click += new System.EventHandler(this.tambah_btn_Click);
            // 
            // dataGridPesanan
            // 
            this.dataGridPesanan.AllowUserToAddRows = false;
            this.dataGridPesanan.AllowUserToDeleteRows = false;
            this.dataGridPesanan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridPesanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPesanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPesanan.Location = new System.Drawing.Point(0, 40);
            this.dataGridPesanan.Name = "dataGridPesanan";
            this.dataGridPesanan.ReadOnly = true;
            this.dataGridPesanan.Size = new System.Drawing.Size(600, 370);
            this.dataGridPesanan.TabIndex = 2;
            this.dataGridPesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPesanan_CellContentClick);
            // 
            // selesai_btn
            // 
            this.selesai_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.selesai_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.selesai_btn.FlatAppearance.BorderSize = 0;
            this.selesai_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selesai_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selesai_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.selesai_btn.Location = new System.Drawing.Point(150, 0);
            this.selesai_btn.Name = "selesai_btn";
            this.selesai_btn.Size = new System.Drawing.Size(75, 40);
            this.selesai_btn.TabIndex = 3;
            this.selesai_btn.Text = "Selesai";
            this.selesai_btn.UseVisualStyleBackColor = false;
            this.selesai_btn.Click += new System.EventHandler(this.selesai_btn_Click);
            // 
            // Pesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridPesanan);
            this.Controls.Add(this.actionPanel);
            this.Name = "Pesanan";
            this.Size = new System.Drawing.Size(600, 410);
            this.actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesanan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button tambah_btn;
        private System.Windows.Forms.DataGridView dataGridPesanan;
        private System.Windows.Forms.Button selesai_btn;
    }
}
