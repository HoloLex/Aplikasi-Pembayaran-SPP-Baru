namespace App_SPP_New
{
    partial class FormSiswa
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Ekspor = new App_SPP_New.CustomUI.HXButton();
            this.Reset = new App_SPP_New.CustomUI.HXButton();
            this.TblSPP = new App_SPP_New.CustomUI.HXButton();
            this.TblKelas = new App_SPP_New.CustomUI.HXButton();
            this.label9 = new System.Windows.Forms.Label();
            this.CariNISN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Simpan = new App_SPP_New.CustomUI.HXButton();
            this.Ubah = new App_SPP_New.CustomUI.HXButton();
            this.Hapus = new App_SPP_New.CustomUI.HXButton();
            this.Kembali = new App_SPP_New.CustomUI.HXButton();
            this.NoTelepon = new App_SPP_New.CustomUI.HXTextBox();
            this.Alamat = new App_SPP_New.CustomUI.HXTextBox();
            this.NamaSiswa = new App_SPP_New.CustomUI.HXTextBox();
            this.NIS = new App_SPP_New.CustomUI.HXTextBox();
            this.NISN = new App_SPP_New.CustomUI.HXTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdSPP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdKelas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Ekspor);
            this.groupBox3.Controls.Add(this.Reset);
            this.groupBox3.Controls.Add(this.TblSPP);
            this.groupBox3.Controls.Add(this.TblKelas);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.CariNISN);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(528, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 194);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // Ekspor
            // 
            this.Ekspor.BackColor = System.Drawing.Color.ForestGreen;
            this.Ekspor.BackgrounColor = System.Drawing.Color.ForestGreen;
            this.Ekspor.BorderColor = System.Drawing.Color.Black;
            this.Ekspor.BorderRadius = 28;
            this.Ekspor.BorderSize = 1;
            this.Ekspor.FlatAppearance.BorderSize = 0;
            this.Ekspor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekspor.ForeColor = System.Drawing.Color.Transparent;
            this.Ekspor.Location = new System.Drawing.Point(142, 60);
            this.Ekspor.Name = "Ekspor";
            this.Ekspor.Size = new System.Drawing.Size(112, 31);
            this.Ekspor.TabIndex = 39;
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
            this.Reset.Location = new System.Drawing.Point(9, 61);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(112, 29);
            this.Reset.TabIndex = 28;
            this.Reset.Text = "Reset Pencarian";
            this.Reset.TextColor = System.Drawing.Color.Transparent;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
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
            this.TblSPP.Location = new System.Drawing.Point(145, 97);
            this.TblSPP.Name = "TblSPP";
            this.TblSPP.Size = new System.Drawing.Size(109, 29);
            this.TblSPP.TabIndex = 27;
            this.TblSPP.Text = "Tabel SPP";
            this.TblSPP.TextColor = System.Drawing.Color.Black;
            this.TblSPP.UseVisualStyleBackColor = false;
            this.TblSPP.Click += new System.EventHandler(this.TblSPP_Click);
            // 
            // TblKelas
            // 
            this.TblKelas.BackColor = System.Drawing.Color.Silver;
            this.TblKelas.BackgrounColor = System.Drawing.Color.Silver;
            this.TblKelas.BorderColor = System.Drawing.Color.Black;
            this.TblKelas.BorderRadius = 29;
            this.TblKelas.BorderSize = 1;
            this.TblKelas.FlatAppearance.BorderSize = 0;
            this.TblKelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TblKelas.ForeColor = System.Drawing.Color.Black;
            this.TblKelas.Location = new System.Drawing.Point(9, 96);
            this.TblKelas.Name = "TblKelas";
            this.TblKelas.Size = new System.Drawing.Size(112, 29);
            this.TblKelas.TabIndex = 26;
            this.TblKelas.Text = "Tabel Kelas";
            this.TblKelas.TextColor = System.Drawing.Color.Black;
            this.TblKelas.UseVisualStyleBackColor = false;
            this.TblKelas.Click += new System.EventHandler(this.TblKelas_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(29, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "NISN tidak bisa diubah bila telah ditambah.";
            // 
            // CariNISN
            // 
            this.CariNISN.FormattingEnabled = true;
            this.CariNISN.Location = new System.Drawing.Point(80, 25);
            this.CariNISN.Name = "CariNISN";
            this.CariNISN.Size = new System.Drawing.Size(159, 21);
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
            this.groupBox2.Controls.Add(this.Simpan);
            this.groupBox2.Controls.Add(this.Ubah);
            this.groupBox2.Controls.Add(this.Hapus);
            this.groupBox2.Controls.Add(this.Kembali);
            this.groupBox2.Controls.Add(this.NoTelepon);
            this.groupBox2.Controls.Add(this.Alamat);
            this.groupBox2.Controls.Add(this.NamaSiswa);
            this.groupBox2.Controls.Add(this.NIS);
            this.groupBox2.Controls.Add(this.NISN);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.IdSPP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.IdKelas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 194);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form User";
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
            this.Simpan.Location = new System.Drawing.Point(18, 156);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(112, 29);
            this.Simpan.TabIndex = 29;
            this.Simpan.Text = "Simpan";
            this.Simpan.TextColor = System.Drawing.Color.Black;
            this.Simpan.UseVisualStyleBackColor = false;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
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
            this.Ubah.Location = new System.Drawing.Point(136, 156);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(112, 29);
            this.Ubah.TabIndex = 30;
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
            this.Hapus.Location = new System.Drawing.Point(254, 156);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(112, 29);
            this.Hapus.TabIndex = 31;
            this.Hapus.Text = "Hapus";
            this.Hapus.TextColor = System.Drawing.Color.Transparent;
            this.Hapus.UseVisualStyleBackColor = false;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
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
            this.Kembali.Location = new System.Drawing.Point(381, 156);
            this.Kembali.Name = "Kembali";
            this.Kembali.Size = new System.Drawing.Size(112, 29);
            this.Kembali.TabIndex = 32;
            this.Kembali.Text = "Kembali";
            this.Kembali.TextColor = System.Drawing.Color.Black;
            this.Kembali.UseVisualStyleBackColor = false;
            this.Kembali.Click += new System.EventHandler(this.Kembali_Click);
            // 
            // NoTelepon
            // 
            this.NoTelepon.BackColor = System.Drawing.SystemColors.Control;
            this.NoTelepon.BorderColor = System.Drawing.Color.Black;
            this.NoTelepon.BorderFocusColor = System.Drawing.Color.Gray;
            this.NoTelepon.BorderSize = 2;
            this.NoTelepon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoTelepon.ForeColor = System.Drawing.Color.DimGray;
            this.NoTelepon.Location = new System.Drawing.Point(335, 55);
            this.NoTelepon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NoTelepon.Multiline = false;
            this.NoTelepon.Name = "NoTelepon";
            this.NoTelepon.Padding = new System.Windows.Forms.Padding(5);
            this.NoTelepon.PasswordChar = false;
            this.NoTelepon.Size = new System.Drawing.Size(159, 27);
            this.NoTelepon.TabIndex = 30;
            this.NoTelepon.Texts = "";
            this.NoTelepon.UnderlinedStyle = true;
            // 
            // Alamat
            // 
            this.Alamat.BackColor = System.Drawing.SystemColors.Control;
            this.Alamat.BorderColor = System.Drawing.Color.Black;
            this.Alamat.BorderFocusColor = System.Drawing.Color.Gray;
            this.Alamat.BorderSize = 2;
            this.Alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alamat.ForeColor = System.Drawing.Color.DimGray;
            this.Alamat.Location = new System.Drawing.Point(335, 22);
            this.Alamat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Alamat.Multiline = false;
            this.Alamat.Name = "Alamat";
            this.Alamat.Padding = new System.Windows.Forms.Padding(5);
            this.Alamat.PasswordChar = false;
            this.Alamat.Size = new System.Drawing.Size(159, 27);
            this.Alamat.TabIndex = 29;
            this.Alamat.Texts = "";
            this.Alamat.UnderlinedStyle = true;
            // 
            // NamaSiswa
            // 
            this.NamaSiswa.BackColor = System.Drawing.SystemColors.Control;
            this.NamaSiswa.BorderColor = System.Drawing.Color.Black;
            this.NamaSiswa.BorderFocusColor = System.Drawing.Color.Gray;
            this.NamaSiswa.BorderSize = 2;
            this.NamaSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaSiswa.ForeColor = System.Drawing.Color.DimGray;
            this.NamaSiswa.Location = new System.Drawing.Point(89, 82);
            this.NamaSiswa.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NamaSiswa.Multiline = false;
            this.NamaSiswa.Name = "NamaSiswa";
            this.NamaSiswa.Padding = new System.Windows.Forms.Padding(5);
            this.NamaSiswa.PasswordChar = false;
            this.NamaSiswa.Size = new System.Drawing.Size(159, 27);
            this.NamaSiswa.TabIndex = 28;
            this.NamaSiswa.Texts = "";
            this.NamaSiswa.UnderlinedStyle = true;
            // 
            // NIS
            // 
            this.NIS.BackColor = System.Drawing.SystemColors.Control;
            this.NIS.BorderColor = System.Drawing.Color.Black;
            this.NIS.BorderFocusColor = System.Drawing.Color.Gray;
            this.NIS.BorderSize = 2;
            this.NIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIS.ForeColor = System.Drawing.Color.DimGray;
            this.NIS.Location = new System.Drawing.Point(89, 49);
            this.NIS.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NIS.Multiline = false;
            this.NIS.Name = "NIS";
            this.NIS.Padding = new System.Windows.Forms.Padding(5);
            this.NIS.PasswordChar = false;
            this.NIS.Size = new System.Drawing.Size(159, 27);
            this.NIS.TabIndex = 27;
            this.NIS.Texts = "";
            this.NIS.UnderlinedStyle = true;
            // 
            // NISN
            // 
            this.NISN.BackColor = System.Drawing.SystemColors.Control;
            this.NISN.BorderColor = System.Drawing.Color.Black;
            this.NISN.BorderFocusColor = System.Drawing.Color.Gray;
            this.NISN.BorderSize = 2;
            this.NISN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NISN.ForeColor = System.Drawing.Color.DimGray;
            this.NISN.Location = new System.Drawing.Point(89, 16);
            this.NISN.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NISN.Multiline = false;
            this.NISN.Name = "NISN";
            this.NISN.Padding = new System.Windows.Forms.Padding(5);
            this.NISN.PasswordChar = false;
            this.NISN.Size = new System.Drawing.Size(159, 27);
            this.NISN.TabIndex = 26;
            this.NISN.Texts = "";
            this.NISN.UnderlinedStyle = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nama Siswa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID Spp";
            // 
            // IdSPP
            // 
            this.IdSPP.FormattingEnabled = true;
            this.IdSPP.Location = new System.Drawing.Point(335, 91);
            this.IdSPP.Name = "IdSPP";
            this.IdSPP.Size = new System.Drawing.Size(159, 21);
            this.IdSPP.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "No Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID Kelas";
            // 
            // IdKelas
            // 
            this.IdKelas.FormattingEnabled = true;
            this.IdKelas.Location = new System.Drawing.Point(89, 122);
            this.IdKelas.Name = "IdKelas";
            this.IdKelas.Size = new System.Drawing.Size(159, 21);
            this.IdKelas.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NISN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NIS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel List Siswa";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Data Siswa/Siswi";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(718, 0);
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
            this.Minimize.Location = new System.Drawing.Point(643, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(84, 36);
            this.Minimize.TabIndex = 15;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(800, 36);
            this.PnlTop.TabIndex = 17;
            // 
            // FormSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form User/Pengguna";
            this.Load += new System.EventHandler(this.FormSiswa_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox IdKelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IdSPP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CariNISN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel PnlTop;
        private CustomUI.HXTextBox NISN;
        private CustomUI.HXButton TblKelas;
        private CustomUI.HXButton TblSPP;
        private CustomUI.HXTextBox NIS;
        private CustomUI.HXTextBox NamaSiswa;
        private CustomUI.HXTextBox NoTelepon;
        private CustomUI.HXTextBox Alamat;
        private CustomUI.HXButton Reset;
        private CustomUI.HXButton Simpan;
        private CustomUI.HXButton Ubah;
        private CustomUI.HXButton Hapus;
        private CustomUI.HXButton Kembali;
        private CustomUI.HXButton Ekspor;
    }
}