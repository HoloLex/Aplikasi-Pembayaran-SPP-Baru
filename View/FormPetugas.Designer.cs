namespace App_SPP_New
{
    partial class FormPetugas
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
            this.CariLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lvl = new System.Windows.Forms.ComboBox();
            this.Ekspor = new App_SPP_New.CustomUI.HXButton();
            this.Reset = new App_SPP_New.CustomUI.HXButton();
            this.Pass = new App_SPP_New.CustomUI.HXTextBox();
            this.NamaPetugas = new App_SPP_New.CustomUI.HXTextBox();
            this.User = new App_SPP_New.CustomUI.HXTextBox();
            this.Simpan = new App_SPP_New.CustomUI.HXButton();
            this.Ubah = new App_SPP_New.CustomUI.HXButton();
            this.Hapus = new App_SPP_New.CustomUI.HXButton();
            this.Kembali = new App_SPP_New.CustomUI.HXButton();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Ekspor);
            this.groupBox3.Controls.Add(this.Reset);
            this.groupBox3.Controls.Add(this.CariLevel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(495, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 194);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // CariLevel
            // 
            this.CariLevel.FormattingEnabled = true;
            this.CariLevel.Items.AddRange(new object[] {
            "Admin",
            "Petugas"});
            this.CariLevel.Location = new System.Drawing.Point(109, 25);
            this.CariLevel.Name = "CariLevel";
            this.CariLevel.Size = new System.Drawing.Size(168, 21);
            this.CariLevel.TabIndex = 18;
            this.CariLevel.SelectedIndexChanged += new System.EventHandler(this.CariLevel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel List Petugas/User Terdaftar";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Petugas Terdaftar";
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
            this.Minimize.Location = new System.Drawing.Point(638, 0);
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
            this.PnlTop.Size = new System.Drawing.Size(800, 35);
            this.PnlTop.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Level User : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nama Petugas :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lvl);
            this.groupBox2.Controls.Add(this.Pass);
            this.groupBox2.Controls.Add(this.NamaPetugas);
            this.groupBox2.Controls.Add(this.User);
            this.groupBox2.Controls.Add(this.Simpan);
            this.groupBox2.Controls.Add(this.Ubah);
            this.groupBox2.Controls.Add(this.Hapus);
            this.groupBox2.Controls.Add(this.Kembali);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 194);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form User";
            // 
            // Lvl
            // 
            this.Lvl.FormattingEnabled = true;
            this.Lvl.Items.AddRange(new object[] {
            "Admin",
            "Petugas"});
            this.Lvl.Location = new System.Drawing.Point(101, 116);
            this.Lvl.Name = "Lvl";
            this.Lvl.Size = new System.Drawing.Size(159, 21);
            this.Lvl.TabIndex = 45;
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
            this.Ekspor.Location = new System.Drawing.Point(152, 56);
            this.Ekspor.Name = "Ekspor";
            this.Ekspor.Size = new System.Drawing.Size(112, 29);
            this.Ekspor.TabIndex = 46;
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
            this.Reset.Location = new System.Drawing.Point(20, 56);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(112, 29);
            this.Reset.TabIndex = 34;
            this.Reset.Text = "Reset Pencarian";
            this.Reset.TextColor = System.Drawing.Color.Transparent;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.SystemColors.Control;
            this.Pass.BorderColor = System.Drawing.Color.Black;
            this.Pass.BorderFocusColor = System.Drawing.Color.Gray;
            this.Pass.BorderSize = 2;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.DimGray;
            this.Pass.Location = new System.Drawing.Point(101, 76);
            this.Pass.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Pass.Multiline = false;
            this.Pass.Name = "Pass";
            this.Pass.Padding = new System.Windows.Forms.Padding(5);
            this.Pass.PasswordChar = false;
            this.Pass.Size = new System.Drawing.Size(159, 27);
            this.Pass.TabIndex = 44;
            this.Pass.Texts = "";
            this.Pass.UnderlinedStyle = true;
            // 
            // NamaPetugas
            // 
            this.NamaPetugas.BackColor = System.Drawing.SystemColors.Control;
            this.NamaPetugas.BorderColor = System.Drawing.Color.Black;
            this.NamaPetugas.BorderFocusColor = System.Drawing.Color.Gray;
            this.NamaPetugas.BorderSize = 2;
            this.NamaPetugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaPetugas.ForeColor = System.Drawing.Color.DimGray;
            this.NamaPetugas.Location = new System.Drawing.Point(101, 43);
            this.NamaPetugas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NamaPetugas.Multiline = false;
            this.NamaPetugas.Name = "NamaPetugas";
            this.NamaPetugas.Padding = new System.Windows.Forms.Padding(5);
            this.NamaPetugas.PasswordChar = false;
            this.NamaPetugas.Size = new System.Drawing.Size(159, 27);
            this.NamaPetugas.TabIndex = 43;
            this.NamaPetugas.Texts = "";
            this.NamaPetugas.UnderlinedStyle = true;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.SystemColors.Control;
            this.User.BorderColor = System.Drawing.Color.Black;
            this.User.BorderFocusColor = System.Drawing.Color.Gray;
            this.User.BorderSize = 2;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.DimGray;
            this.User.Location = new System.Drawing.Point(101, 10);
            this.User.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.User.Multiline = false;
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(5);
            this.User.PasswordChar = false;
            this.User.Size = new System.Drawing.Size(159, 27);
            this.User.TabIndex = 42;
            this.User.Texts = "";
            this.User.UnderlinedStyle = true;
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
            this.Simpan.Location = new System.Drawing.Point(5, 159);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(112, 29);
            this.Simpan.TabIndex = 38;
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
            this.Ubah.Location = new System.Drawing.Point(123, 159);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(112, 29);
            this.Ubah.TabIndex = 39;
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
            this.Hapus.Location = new System.Drawing.Point(241, 159);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(112, 29);
            this.Hapus.TabIndex = 40;
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
            this.Kembali.Location = new System.Drawing.Point(359, 159);
            this.Kembali.Name = "Kembali";
            this.Kembali.Size = new System.Drawing.Size(112, 29);
            this.Kembali.TabIndex = 41;
            this.Kembali.Text = "Kembali";
            this.Kembali.TextColor = System.Drawing.Color.Black;
            this.Kembali.UseVisualStyleBackColor = false;
            this.Kembali.Click += new System.EventHandler(this.Kembali_Click);
            // 
            // FormPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPetugas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form User/Pengguna";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.ComboBox CariLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel PnlTop;
        private CustomUI.HXButton Reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomUI.HXButton Kembali;
        private CustomUI.HXButton Hapus;
        private CustomUI.HXButton Ubah;
        private CustomUI.HXButton Simpan;
        private CustomUI.HXTextBox User;
        private CustomUI.HXTextBox NamaPetugas;
        private CustomUI.HXTextBox Pass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Lvl;
        private CustomUI.HXButton Ekspor;
    }
}