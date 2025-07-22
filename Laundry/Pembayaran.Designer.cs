namespace Laundry
{
    partial class Pembayaran
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
            this.dataGridPembayaran = new System.Windows.Forms.DataGridView();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.tambah_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPembayaran)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPembayaran
            // 
            this.dataGridPembayaran.AllowUserToAddRows = false;
            this.dataGridPembayaran.AllowUserToDeleteRows = false;
            this.dataGridPembayaran.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridPembayaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPembayaran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPembayaran.Location = new System.Drawing.Point(0, 40);
            this.dataGridPembayaran.Name = "dataGridPembayaran";
            this.dataGridPembayaran.Size = new System.Drawing.Size(600, 370);
            this.dataGridPembayaran.TabIndex = 8;
            this.dataGridPembayaran.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPembayaran_CellEndEdit);
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.LightGray;
            this.actionPanel.Controls.Add(this.Delete_btn);
            this.actionPanel.Controls.Add(this.tambah_btn);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionPanel.Location = new System.Drawing.Point(0, 0);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(600, 40);
            this.actionPanel.TabIndex = 7;
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
            // Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridPembayaran);
            this.Controls.Add(this.actionPanel);
            this.Name = "Pembayaran";
            this.Size = new System.Drawing.Size(600, 410);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPembayaran)).EndInit();
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPembayaran;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button tambah_btn;
    }
}
