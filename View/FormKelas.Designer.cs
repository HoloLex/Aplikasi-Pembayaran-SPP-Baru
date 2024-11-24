namespace App_SPP_New
{
    partial class FormKelas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NamaKelas = new App_SPP_New.CustomUI.HXTextBox();
            this.KK = new System.Windows.Forms.ComboBox();
            this.Simpan = new App_SPP_New.CustomUI.HXButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Ubah = new App_SPP_New.CustomUI.HXButton();
            this.Hapus = new App_SPP_New.CustomUI.HXButton();
            this.Kembali = new App_SPP_New.CustomUI.HXButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hxButton1 = new App_SPP_New.CustomUI.HXButton();
            this.Reset = new App_SPP_New.CustomUI.HXButton();
            this.CariKK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Kelas";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kompetensi Keahalian";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NamaKelas);
            this.groupBox2.Controls.Add(this.KK);
            this.groupBox2.Controls.Add(this.Simpan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Ubah);
            this.groupBox2.Controls.Add(this.Hapus);
            this.groupBox2.Controls.Add(this.Kembali);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 194);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Kelas";
            // 
            // NamaKelas
            // 
            this.NamaKelas.BackColor = System.Drawing.SystemColors.Control;
            this.NamaKelas.BorderColor = System.Drawing.Color.Black;
            this.NamaKelas.BorderFocusColor = System.Drawing.Color.Gray;
            this.NamaKelas.BorderSize = 2;
            this.NamaKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaKelas.ForeColor = System.Drawing.Color.DimGray;
            this.NamaKelas.Location = new System.Drawing.Point(130, 19);
            this.NamaKelas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NamaKelas.Multiline = false;
            this.NamaKelas.Name = "NamaKelas";
            this.NamaKelas.Padding = new System.Windows.Forms.Padding(5);
            this.NamaKelas.PasswordChar = false;
            this.NamaKelas.Size = new System.Drawing.Size(168, 27);
            this.NamaKelas.TabIndex = 38;
            this.NamaKelas.Texts = "";
            this.NamaKelas.UnderlinedStyle = true;
            // 
            // KK
            // 
            this.KK.FormattingEnabled = true;
            this.KK.Items.AddRange(new object[] {
            "Rekayasa Perangkat Lunak",
            "Desain Grafika",
            "Analisa Pengujian Laboratorium",
            "Kimia Industri",
            "Teknik Logistik"});
            this.KK.Location = new System.Drawing.Point(130, 61);
            this.KK.Name = "KK";
            this.KK.Size = new System.Drawing.Size(168, 21);
            this.KK.TabIndex = 15;
            // 
            // Simpan
            // 
            this.Simpan.BackColor = System.Drawing.Color.LawnGreen;
            this.Simpan.BackgrounColor = System.Drawing.Color.LawnGreen;
            this.Simpan.BorderColor = System.Drawing.Color.Black;
            this.Simpan.BorderRadius = 28;
            this.Simpan.BorderSize = 1;
            this.Simpan.FlatAppearance.BorderSize = 0;
            this.Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Simpan.ForeColor = System.Drawing.Color.Black;
            this.Simpan.Location = new System.Drawing.Point(17, 103);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(125, 34);
            this.Simpan.TabIndex = 34;
            this.Simpan.Text = "Simpan";
            this.Simpan.TextColor = System.Drawing.Color.Black;
            this.Simpan.UseVisualStyleBackColor = false;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama Kelas";
            // 
            // Ubah
            // 
            this.Ubah.BackColor = System.Drawing.Color.Khaki;
            this.Ubah.BackgrounColor = System.Drawing.Color.Khaki;
            this.Ubah.BorderColor = System.Drawing.Color.Black;
            this.Ubah.BorderRadius = 28;
            this.Ubah.BorderSize = 1;
            this.Ubah.FlatAppearance.BorderSize = 0;
            this.Ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ubah.ForeColor = System.Drawing.Color.Black;
            this.Ubah.Location = new System.Drawing.Point(159, 103);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(125, 34);
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
            this.Hapus.BorderRadius = 28;
            this.Hapus.BorderSize = 1;
            this.Hapus.FlatAppearance.BorderSize = 0;
            this.Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hapus.ForeColor = System.Drawing.Color.Transparent;
            this.Hapus.Location = new System.Drawing.Point(300, 103);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(125, 34);
            this.Hapus.TabIndex = 36;
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
            this.Kembali.BorderRadius = 28;
            this.Kembali.BorderSize = 1;
            this.Kembali.FlatAppearance.BorderSize = 0;
            this.Kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kembali.ForeColor = System.Drawing.Color.Black;
            this.Kembali.Location = new System.Drawing.Point(159, 143);
            this.Kembali.Name = "Kembali";
            this.Kembali.Size = new System.Drawing.Size(125, 34);
            this.Kembali.TabIndex = 37;
            this.Kembali.Text = "Kembali";
            this.Kembali.TextColor = System.Drawing.Color.Black;
            this.Kembali.UseVisualStyleBackColor = false;
            this.Kembali.Click += new System.EventHandler(this.Kembali_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kompetensi Keahlian";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hxButton1);
            this.groupBox3.Controls.Add(this.Reset);
            this.groupBox3.Controls.Add(this.CariKK);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(461, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 194);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // hxButton1
            // 
            this.hxButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.hxButton1.BackgrounColor = System.Drawing.Color.ForestGreen;
            this.hxButton1.BorderColor = System.Drawing.Color.Black;
            this.hxButton1.BorderRadius = 28;
            this.hxButton1.BorderSize = 1;
            this.hxButton1.FlatAppearance.BorderSize = 0;
            this.hxButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hxButton1.ForeColor = System.Drawing.Color.Transparent;
            this.hxButton1.Location = new System.Drawing.Point(174, 61);
            this.hxButton1.Name = "hxButton1";
            this.hxButton1.Size = new System.Drawing.Size(125, 34);
            this.hxButton1.TabIndex = 38;
            this.hxButton1.Text = "Ekspor Ke Excel";
            this.hxButton1.TextColor = System.Drawing.Color.Transparent;
            this.hxButton1.UseVisualStyleBackColor = false;
            this.hxButton1.Click += new System.EventHandler(this.Ekspor_Click);
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
            this.Reset.Location = new System.Drawing.Point(29, 61);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(125, 34);
            this.Reset.TabIndex = 33;
            this.Reset.Text = "Reset Pencarian";
            this.Reset.TextColor = System.Drawing.Color.Transparent;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // CariKK
            // 
            this.CariKK.FormattingEnabled = true;
            this.CariKK.Items.AddRange(new object[] {
            "Rekayasa Perangkat Lunak",
            "Desain Grafika",
            "Analisa Pengujian Laboratorium",
            "Kimia Industri",
            "Teknik Logistik"});
            this.CariKK.Location = new System.Drawing.Point(157, 25);
            this.CariKK.Name = "CariKK";
            this.CariKK.Size = new System.Drawing.Size(163, 21);
            this.CariKK.TabIndex = 16;
            this.CariKK.SelectedIndexChanged += new System.EventHandler(this.CariKK_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data Kelas";
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
            this.Minimize.TabIndex = 13;
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
            this.PnlTop.Size = new System.Drawing.Size(800, 35);
            this.PnlTop.TabIndex = 17;
            // 
            // FormKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Kelas";
            this.Load += new System.EventHandler(this.FormKelas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox KK;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.ComboBox CariKK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel PnlTop;
        private CustomUI.HXButton Simpan;
        private CustomUI.HXButton Ubah;
        private CustomUI.HXButton Hapus;
        private CustomUI.HXButton Kembali;
        private CustomUI.HXButton hxButton1;
        private CustomUI.HXButton Reset;
        private CustomUI.HXTextBox NamaKelas;
    }
}