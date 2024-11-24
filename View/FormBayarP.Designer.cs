namespace App_SPP_New.View
{
    partial class FormBayarP
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
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdSPP = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TblSiswa = new App_SPP_New.CustomUI.HXButton();
            this.TblPetugas = new App_SPP_New.CustomUI.HXButton();
            this.TblSPP = new App_SPP_New.CustomUI.HXButton();
            this.Ekspor = new App_SPP_New.CustomUI.HXButton();
            this.Reset = new App_SPP_New.CustomUI.HXButton();
            this.CariNISN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdPetugas = new System.Windows.Forms.ComboBox();
            this.Simpan = new App_SPP_New.CustomUI.HXButton();
            this.NISN = new System.Windows.Forms.ComboBox();
            this.Ubah = new App_SPP_New.CustomUI.HXButton();
            this.Hapus = new App_SPP_New.CustomUI.HXButton();
            this.JumlahBayar = new System.Windows.Forms.NumericUpDown();
            this.Kembali = new App_SPP_New.CustomUI.HXButton();
            this.TahunBayar = new System.Windows.Forms.ComboBox();
            this.TanggalBayar = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BulanBayar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumlahBayar)).BeginInit();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(9, 20);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(761, 200);
            this.DataTable.TabIndex = 10;
            this.DataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 226);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel List Pembayaran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tanggal Bayar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID Spp";
            // 
            // IdSPP
            // 
            this.IdSPP.FormattingEnabled = true;
            this.IdSPP.Location = new System.Drawing.Point(345, 64);
            this.IdSPP.Name = "IdSPP";
            this.IdSPP.Size = new System.Drawing.Size(159, 21);
            this.IdSPP.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TblSiswa);
            this.groupBox3.Controls.Add(this.TblPetugas);
            this.groupBox3.Controls.Add(this.TblSPP);
            this.groupBox3.Controls.Add(this.Ekspor);
            this.groupBox3.Controls.Add(this.Reset);
            this.groupBox3.Controls.Add(this.CariNISN);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(528, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 194);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // TblSiswa
            // 
            this.TblSiswa.BackColor = System.Drawing.Color.Silver;
            this.TblSiswa.BackgrounColor = System.Drawing.Color.Silver;
            this.TblSiswa.BorderColor = System.Drawing.Color.Black;
            this.TblSiswa.BorderRadius = 29;
            this.TblSiswa.BorderSize = 1;
            this.TblSiswa.FlatAppearance.BorderSize = 0;
            this.TblSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TblSiswa.ForeColor = System.Drawing.Color.Black;
            this.TblSiswa.Location = new System.Drawing.Point(71, 137);
            this.TblSiswa.Name = "TblSiswa";
            this.TblSiswa.Size = new System.Drawing.Size(112, 29);
            this.TblSiswa.TabIndex = 40;
            this.TblSiswa.Text = "Tabel Siswa";
            this.TblSiswa.TextColor = System.Drawing.Color.Black;
            this.TblSiswa.UseVisualStyleBackColor = false;
            this.TblSiswa.Click += new System.EventHandler(this.TblSiswa_Click);
            // 
            // TblPetugas
            // 
            this.TblPetugas.BackColor = System.Drawing.Color.Silver;
            this.TblPetugas.BackgrounColor = System.Drawing.Color.Silver;
            this.TblPetugas.BorderColor = System.Drawing.Color.Black;
            this.TblPetugas.BorderRadius = 29;
            this.TblPetugas.BorderSize = 1;
            this.TblPetugas.FlatAppearance.BorderSize = 0;
            this.TblPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TblPetugas.ForeColor = System.Drawing.Color.Black;
            this.TblPetugas.Location = new System.Drawing.Point(134, 102);
            this.TblPetugas.Name = "TblPetugas";
            this.TblPetugas.Size = new System.Drawing.Size(112, 29);
            this.TblPetugas.TabIndex = 38;
            this.TblPetugas.Text = "Tabel Petugas";
            this.TblPetugas.TextColor = System.Drawing.Color.Black;
            this.TblPetugas.UseVisualStyleBackColor = false;
            this.TblPetugas.Click += new System.EventHandler(this.TblPetugas_Click);
            // 
            // TblSPP
            // 
            this.TblSPP.BackColor = System.Drawing.Color.Silver;
            this.TblSPP.BackgrounColor = System.Drawing.Color.Silver;
            this.TblSPP.BorderColor = System.Drawing.Color.Black;
            this.TblSPP.BorderRadius = 29;
            this.TblSPP.BorderSize = 1;
            this.TblSPP.FlatAppearance.BorderSize = 0;
            this.TblSPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TblSPP.ForeColor = System.Drawing.Color.Black;
            this.TblSPP.Location = new System.Drawing.Point(16, 102);
            this.TblSPP.Name = "TblSPP";
            this.TblSPP.Size = new System.Drawing.Size(112, 29);
            this.TblSPP.TabIndex = 39;
            this.TblSPP.Text = "Tabel SPP";
            this.TblSPP.TextColor = System.Drawing.Color.Black;
            this.TblSPP.UseVisualStyleBackColor = false;
            this.TblSPP.Click += new System.EventHandler(this.TblSPP_Click);
            // 
            // Ekspor
            // 
            this.Ekspor.BackColor = System.Drawing.Color.ForestGreen;
            this.Ekspor.BackgrounColor = System.Drawing.Color.ForestGreen;
            this.Ekspor.BorderColor = System.Drawing.Color.Black;
            this.Ekspor.BorderRadius = 29;
            this.Ekspor.BorderSize = 1;
            this.Ekspor.FlatAppearance.BorderSize = 0;
            this.Ekspor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekspor.ForeColor = System.Drawing.Color.Transparent;
            this.Ekspor.Location = new System.Drawing.Point(134, 67);
            this.Ekspor.Name = "Ekspor";
            this.Ekspor.Size = new System.Drawing.Size(112, 29);
            this.Ekspor.TabIndex = 38;
            this.Ekspor.Text = "Ekspor Ke Excel";
            this.Ekspor.TextColor = System.Drawing.Color.Transparent;
            this.Ekspor.UseVisualStyleBackColor = false;
            this.Ekspor.Click += new System.EventHandler(this.Ekspor_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Red;
            this.Reset.BackgrounColor = System.Drawing.Color.Red;
            this.Reset.BorderColor = System.Drawing.Color.Black;
            this.Reset.BorderRadius = 29;
            this.Reset.BorderSize = 1;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.ForeColor = System.Drawing.Color.Transparent;
            this.Reset.Location = new System.Drawing.Point(16, 67);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(112, 29);
            this.Reset.TabIndex = 33;
            this.Reset.Text = "Reset Pencarian";
            this.Reset.TextColor = System.Drawing.Color.Transparent;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // CariNISN
            // 
            this.CariNISN.FormattingEnabled = true;
            this.CariNISN.Location = new System.Drawing.Point(71, 25);
            this.CariNISN.Name = "CariNISN";
            this.CariNISN.Size = new System.Drawing.Size(168, 21);
            this.CariNISN.TabIndex = 24;
            this.CariNISN.SelectedIndexChanged += new System.EventHandler(this.CariNISN_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NISN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IdPetugas);
            this.groupBox2.Controls.Add(this.Simpan);
            this.groupBox2.Controls.Add(this.NISN);
            this.groupBox2.Controls.Add(this.Ubah);
            this.groupBox2.Controls.Add(this.Hapus);
            this.groupBox2.Controls.Add(this.JumlahBayar);
            this.groupBox2.Controls.Add(this.Kembali);
            this.groupBox2.Controls.Add(this.TahunBayar);
            this.groupBox2.Controls.Add(this.TanggalBayar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.IdSPP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BulanBayar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 194);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form User";
            // 
            // IdPetugas
            // 
            this.IdPetugas.FormattingEnabled = true;
            this.IdPetugas.Location = new System.Drawing.Point(84, 31);
            this.IdPetugas.Name = "IdPetugas";
            this.IdPetugas.Size = new System.Drawing.Size(159, 21);
            this.IdPetugas.TabIndex = 30;
            // 
            // Simpan
            // 
            this.Simpan.BackColor = System.Drawing.Color.LawnGreen;
            this.Simpan.BackgrounColor = System.Drawing.Color.LawnGreen;
            this.Simpan.BorderColor = System.Drawing.Color.Black;
            this.Simpan.BorderRadius = 29;
            this.Simpan.BorderSize = 1;
            this.Simpan.FlatAppearance.BorderSize = 0;
            this.Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Simpan.ForeColor = System.Drawing.Color.Black;
            this.Simpan.Location = new System.Drawing.Point(23, 159);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(112, 29);
            this.Simpan.TabIndex = 34;
            this.Simpan.Text = "Simpan";
            this.Simpan.TextColor = System.Drawing.Color.Black;
            this.Simpan.UseVisualStyleBackColor = false;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // NISN
            // 
            this.NISN.FormattingEnabled = true;
            this.NISN.Location = new System.Drawing.Point(84, 61);
            this.NISN.Name = "NISN";
            this.NISN.Size = new System.Drawing.Size(159, 21);
            this.NISN.TabIndex = 29;
            // 
            // Ubah
            // 
            this.Ubah.BackColor = System.Drawing.Color.Khaki;
            this.Ubah.BackgrounColor = System.Drawing.Color.Khaki;
            this.Ubah.BorderColor = System.Drawing.Color.Black;
            this.Ubah.BorderRadius = 29;
            this.Ubah.BorderSize = 1;
            this.Ubah.FlatAppearance.BorderSize = 0;
            this.Ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ubah.ForeColor = System.Drawing.Color.Black;
            this.Ubah.Location = new System.Drawing.Point(141, 159);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(112, 29);
            this.Ubah.TabIndex = 35;
            this.Ubah.Text = "Ubah";
            this.Ubah.TextColor = System.Drawing.Color.Black;
            this.Ubah.UseVisualStyleBackColor = false;
            this.Ubah.Click += new System.EventHandler(this.Ubah_Click);
            // 
            // Hapus
            // 
            this.Hapus.BackColor = System.Drawing.Color.Red;
            this.Hapus.BackgrounColor = System.Drawing.Color.Red;
            this.Hapus.BorderColor = System.Drawing.Color.Black;
            this.Hapus.BorderRadius = 29;
            this.Hapus.BorderSize = 1;
            this.Hapus.FlatAppearance.BorderSize = 0;
            this.Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hapus.ForeColor = System.Drawing.Color.Transparent;
            this.Hapus.Location = new System.Drawing.Point(259, 159);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(112, 29);
            this.Hapus.TabIndex = 36;
            this.Hapus.Text = "Hapus";
            this.Hapus.TextColor = System.Drawing.Color.Transparent;
            this.Hapus.UseVisualStyleBackColor = false;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // JumlahBayar
            // 
            this.JumlahBayar.Location = new System.Drawing.Point(345, 94);
            this.JumlahBayar.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.JumlahBayar.Name = "JumlahBayar";
            this.JumlahBayar.Size = new System.Drawing.Size(159, 20);
            this.JumlahBayar.TabIndex = 28;
            // 
            // Kembali
            // 
            this.Kembali.BackColor = System.Drawing.Color.Silver;
            this.Kembali.BackgrounColor = System.Drawing.Color.Silver;
            this.Kembali.BorderColor = System.Drawing.Color.Black;
            this.Kembali.BorderRadius = 29;
            this.Kembali.BorderSize = 1;
            this.Kembali.FlatAppearance.BorderSize = 0;
            this.Kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kembali.ForeColor = System.Drawing.Color.Black;
            this.Kembali.Location = new System.Drawing.Point(377, 159);
            this.Kembali.Name = "Kembali";
            this.Kembali.Size = new System.Drawing.Size(112, 29);
            this.Kembali.TabIndex = 37;
            this.Kembali.Text = "Kembali";
            this.Kembali.TextColor = System.Drawing.Color.Black;
            this.Kembali.UseVisualStyleBackColor = false;
            this.Kembali.Click += new System.EventHandler(this.Kembali_Click);
            // 
            // TahunBayar
            // 
            this.TahunBayar.FormattingEnabled = true;
            this.TahunBayar.Location = new System.Drawing.Point(345, 34);
            this.TahunBayar.Name = "TahunBayar";
            this.TahunBayar.Size = new System.Drawing.Size(159, 21);
            this.TahunBayar.TabIndex = 27;
            // 
            // TanggalBayar
            // 
            this.TanggalBayar.CustomFormat = "dd-MM-yyyy";
            this.TanggalBayar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TanggalBayar.Location = new System.Drawing.Point(84, 95);
            this.TanggalBayar.Name = "TanggalBayar";
            this.TanggalBayar.Size = new System.Drawing.Size(159, 20);
            this.TanggalBayar.TabIndex = 26;
            this.TanggalBayar.Value = new System.DateTime(2024, 9, 29, 20, 18, 46, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Jumlah Bayar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tahun Bayar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bulan Bayar";
            // 
            // BulanBayar
            // 
            this.BulanBayar.FormattingEnabled = true;
            this.BulanBayar.Items.AddRange(new object[] {
            "Januari",
            "Febuari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.BulanBayar.Location = new System.Drawing.Point(84, 125);
            this.BulanBayar.Name = "BulanBayar";
            this.BulanBayar.Size = new System.Drawing.Size(159, 21);
            this.BulanBayar.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NISN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id Petugas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Data Pemasukan/Pembayaran SPP";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(716, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(84, 36);
            this.Close.TabIndex = 11;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_MouseMove);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Silver;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(635, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(84, 36);
            this.Minimize.TabIndex = 14;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PnlTop.Controls.Add(this.label9);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(800, 35);
            this.PnlTop.TabIndex = 17;
            // 
            // FormBayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBayar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pembayaran";
            this.Load += new System.EventHandler(this.FormBayar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumlahBayar)).EndInit();
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IdSPP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CariNISN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BulanBayar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TanggalBayar;
        private System.Windows.Forms.ComboBox TahunBayar;
        private System.Windows.Forms.NumericUpDown JumlahBayar;
        private System.Windows.Forms.ComboBox IdPetugas;
        private System.Windows.Forms.ComboBox NISN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel PnlTop;
        private CustomUI.HXButton Ekspor;
        private CustomUI.HXButton Reset;
        private CustomUI.HXButton Simpan;
        private CustomUI.HXButton Ubah;
        private CustomUI.HXButton Hapus;
        private CustomUI.HXButton Kembali;
        private CustomUI.HXButton TblSiswa;
        private CustomUI.HXButton TblPetugas;
        private CustomUI.HXButton TblSPP;
    }
}