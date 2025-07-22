namespace Laundry
{
    partial class AddPembayaran
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.batal_btn = new System.Windows.Forms.Button();
            this.tambah_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmMetode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_pesanantxt = new System.Windows.Forms.TextBox();
            this.tanggal_bayartxt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.jumlah_bayartxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 50);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Pembayaran";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.batal_btn);
            this.panel2.Controls.Add(this.tambah_btn);
            this.panel2.Location = new System.Drawing.Point(12, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 40);
            this.panel2.TabIndex = 23;
            // 
            // batal_btn
            // 
            this.batal_btn.BackColor = System.Drawing.Color.Red;
            this.batal_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.batal_btn.FlatAppearance.BorderSize = 0;
            this.batal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.ForeColor = System.Drawing.Color.White;
            this.batal_btn.Location = new System.Drawing.Point(210, 0);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(200, 40);
            this.batal_btn.TabIndex = 1;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = false;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // tambah_btn
            // 
            this.tambah_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tambah_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.tambah_btn.FlatAppearance.BorderSize = 0;
            this.tambah_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_btn.ForeColor = System.Drawing.Color.White;
            this.tambah_btn.Location = new System.Drawing.Point(0, 0);
            this.tambah_btn.Name = "tambah_btn";
            this.tambah_btn.Size = new System.Drawing.Size(200, 40);
            this.tambah_btn.TabIndex = 0;
            this.tambah_btn.Text = "Tambah";
            this.tambah_btn.UseVisualStyleBackColor = false;
            this.tambah_btn.Click += new System.EventHandler(this.tambah_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Metode Pembayaran";
            // 
            // cmMetode
            // 
            this.cmMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmMetode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmMetode.FormattingEnabled = true;
            this.cmMetode.Items.AddRange(new object[] {
            "cash",
            "transfer"});
            this.cmMetode.Location = new System.Drawing.Point(12, 190);
            this.cmMetode.Name = "cmMetode";
            this.cmMetode.Size = new System.Drawing.Size(410, 32);
            this.cmMetode.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tanggal Bayar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID Pesanan";
            // 
            // id_pesanantxt
            // 
            this.id_pesanantxt.BackColor = System.Drawing.Color.White;
            this.id_pesanantxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_pesanantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_pesanantxt.Location = new System.Drawing.Point(12, 80);
            this.id_pesanantxt.Name = "id_pesanantxt";
            this.id_pesanantxt.Size = new System.Drawing.Size(410, 29);
            this.id_pesanantxt.TabIndex = 13;
            // 
            // tanggal_bayartxt
            // 
            this.tanggal_bayartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tanggal_bayartxt.Location = new System.Drawing.Point(12, 134);
            this.tanggal_bayartxt.Name = "tanggal_bayartxt";
            this.tanggal_bayartxt.Size = new System.Drawing.Size(410, 29);
            this.tanggal_bayartxt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Jumlah Bayar";
            // 
            // jumlah_bayartxt
            // 
            this.jumlah_bayartxt.BackColor = System.Drawing.Color.White;
            this.jumlah_bayartxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jumlah_bayartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah_bayartxt.Location = new System.Drawing.Point(12, 249);
            this.jumlah_bayartxt.Name = "jumlah_bayartxt";
            this.jumlah_bayartxt.Size = new System.Drawing.Size(410, 29);
            this.jumlah_bayartxt.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Status";
            // 
            // cmStatus
            // 
            this.cmStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmStatus.FormattingEnabled = true;
            this.cmStatus.Items.AddRange(new object[] {
            "belum lunas",
            "lunas"});
            this.cmStatus.Location = new System.Drawing.Point(12, 306);
            this.cmStatus.Name = "cmStatus";
            this.cmStatus.Size = new System.Drawing.Size(410, 32);
            this.cmStatus.TabIndex = 27;
            // 
            // AddPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 407);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jumlah_bayartxt);
            this.Controls.Add(this.tanggal_bayartxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmMetode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_pesanantxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddPembayaran";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Pembayaran";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button tambah_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmMetode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_pesanantxt;
        private System.Windows.Forms.DateTimePicker tanggal_bayartxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox jumlah_bayartxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmStatus;
    }
}