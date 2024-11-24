namespace App_SPP_New
{
    partial class MenuPetugas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPetugas));
            this.label1 = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Tanggal = new System.Windows.Forms.Label();
            this.Jam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Logout = new App_SPP_New.CustomUI.HXButton();
            this.Tombol_Tagihan = new App_SPP_New.CustomUI.HXButton();
            this.Tombol_SPP = new App_SPP_New.CustomUI.HXButton();
            this.Tombol_Kelas = new App_SPP_New.CustomUI.HXButton();
            this.Tombol_Siswa = new App_SPP_New.CustomUI.HXButton();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selamat Datang di Menu Petugas";
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Silver;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(635, -1);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(84, 42);
            this.Minimize.TabIndex = 16;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(716, -1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(84, 42);
            this.Close.TabIndex = 15;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_MouseMove);
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PnlTop.Controls.Add(this.label2);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(800, 41);
            this.PnlTop.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Menu Petugas";
            // 
            // Tanggal
            // 
            this.Tanggal.AutoSize = true;
            this.Tanggal.BackColor = System.Drawing.Color.Transparent;
            this.Tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tanggal.Location = new System.Drawing.Point(135, 165);
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Size = new System.Drawing.Size(63, 13);
            this.Tanggal.TabIndex = 18;
            this.Tanggal.Text = "ni tanggal";
            // 
            // Jam
            // 
            this.Jam.AutoSize = true;
            this.Jam.BackColor = System.Drawing.Color.Transparent;
            this.Jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jam.Location = new System.Drawing.Point(135, 120);
            this.Jam.Name = "Jam";
            this.Jam.Size = new System.Drawing.Size(72, 17);
            this.Jam.TabIndex = 19;
            this.Jam.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tanggal     :  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Jam           : ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(286, 215);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(522, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(286, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(407, 287);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Red;
            this.Logout.BackgrounColor = System.Drawing.Color.Red;
            this.Logout.BorderColor = System.Drawing.Color.Black;
            this.Logout.BorderRadius = 40;
            this.Logout.BorderSize = 2;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.ForeColor = System.Drawing.Color.Transparent;
            this.Logout.Location = new System.Drawing.Point(477, 287);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(150, 47);
            this.Logout.TabIndex = 39;
            this.Logout.Text = "Logout";
            this.Logout.TextColor = System.Drawing.Color.Transparent;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Tombol_Tagihan
            // 
            this.Tombol_Tagihan.BackColor = System.Drawing.Color.Silver;
            this.Tombol_Tagihan.BackgrounColor = System.Drawing.Color.Silver;
            this.Tombol_Tagihan.BorderColor = System.Drawing.Color.Black;
            this.Tombol_Tagihan.BorderRadius = 40;
            this.Tombol_Tagihan.BorderSize = 1;
            this.Tombol_Tagihan.FlatAppearance.BorderSize = 0;
            this.Tombol_Tagihan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tombol_Tagihan.ForeColor = System.Drawing.Color.Black;
            this.Tombol_Tagihan.Location = new System.Drawing.Point(355, 215);
            this.Tombol_Tagihan.Name = "Tombol_Tagihan";
            this.Tombol_Tagihan.Size = new System.Drawing.Size(150, 47);
            this.Tombol_Tagihan.TabIndex = 38;
            this.Tombol_Tagihan.Text = "Histori Pembayaran";
            this.Tombol_Tagihan.TextColor = System.Drawing.Color.Black;
            this.Tombol_Tagihan.UseVisualStyleBackColor = false;
            this.Tombol_Tagihan.Click += new System.EventHandler(this.Tombol_Tagihan_Click);
            // 
            // Tombol_SPP
            // 
            this.Tombol_SPP.BackColor = System.Drawing.Color.Silver;
            this.Tombol_SPP.BackgrounColor = System.Drawing.Color.Silver;
            this.Tombol_SPP.BorderColor = System.Drawing.Color.Black;
            this.Tombol_SPP.BorderRadius = 40;
            this.Tombol_SPP.BorderSize = 1;
            this.Tombol_SPP.FlatAppearance.BorderSize = 0;
            this.Tombol_SPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tombol_SPP.ForeColor = System.Drawing.Color.Black;
            this.Tombol_SPP.Location = new System.Drawing.Point(592, 215);
            this.Tombol_SPP.Name = "Tombol_SPP";
            this.Tombol_SPP.Size = new System.Drawing.Size(150, 47);
            this.Tombol_SPP.TabIndex = 37;
            this.Tombol_SPP.Text = "Data Tahun SPP";
            this.Tombol_SPP.TextColor = System.Drawing.Color.Black;
            this.Tombol_SPP.UseVisualStyleBackColor = false;
            this.Tombol_SPP.Click += new System.EventHandler(this.Tombol_SPP_Click);
            // 
            // Tombol_Kelas
            // 
            this.Tombol_Kelas.BackColor = System.Drawing.Color.Silver;
            this.Tombol_Kelas.BackgrounColor = System.Drawing.Color.Silver;
            this.Tombol_Kelas.BorderColor = System.Drawing.Color.Black;
            this.Tombol_Kelas.BorderRadius = 40;
            this.Tombol_Kelas.BorderSize = 1;
            this.Tombol_Kelas.FlatAppearance.BorderSize = 0;
            this.Tombol_Kelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tombol_Kelas.ForeColor = System.Drawing.Color.Black;
            this.Tombol_Kelas.Location = new System.Drawing.Point(592, 139);
            this.Tombol_Kelas.Name = "Tombol_Kelas";
            this.Tombol_Kelas.Size = new System.Drawing.Size(150, 49);
            this.Tombol_Kelas.TabIndex = 36;
            this.Tombol_Kelas.Text = "Data Kelas";
            this.Tombol_Kelas.TextColor = System.Drawing.Color.Black;
            this.Tombol_Kelas.UseVisualStyleBackColor = false;
            this.Tombol_Kelas.Click += new System.EventHandler(this.Tombol_Kelas_Click);
            // 
            // Tombol_Siswa
            // 
            this.Tombol_Siswa.BackColor = System.Drawing.Color.Silver;
            this.Tombol_Siswa.BackgrounColor = System.Drawing.Color.Silver;
            this.Tombol_Siswa.BorderColor = System.Drawing.Color.Black;
            this.Tombol_Siswa.BorderRadius = 40;
            this.Tombol_Siswa.BorderSize = 1;
            this.Tombol_Siswa.FlatAppearance.BorderSize = 0;
            this.Tombol_Siswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tombol_Siswa.ForeColor = System.Drawing.Color.Black;
            this.Tombol_Siswa.Location = new System.Drawing.Point(355, 141);
            this.Tombol_Siswa.Name = "Tombol_Siswa";
            this.Tombol_Siswa.Size = new System.Drawing.Size(150, 49);
            this.Tombol_Siswa.TabIndex = 35;
            this.Tombol_Siswa.Text = "Data Siswa";
            this.Tombol_Siswa.TextColor = System.Drawing.Color.Black;
            this.Tombol_Siswa.UseVisualStyleBackColor = false;
            this.Tombol_Siswa.Click += new System.EventHandler(this.Tombol_Siswa_Click);
            // 
            // MenuPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Tombol_Tagihan);
            this.Controls.Add(this.Tombol_SPP);
            this.Controls.Add(this.Tombol_Kelas);
            this.Controls.Add(this.Tombol_Siswa);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Jam);
            this.Controls.Add(this.Tanggal);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPetugas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tanggal;
        private System.Windows.Forms.Label Jam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private CustomUI.HXButton Logout;
        private CustomUI.HXButton Tombol_Tagihan;
        private CustomUI.HXButton Tombol_SPP;
        private CustomUI.HXButton Tombol_Kelas;
        private CustomUI.HXButton Tombol_Siswa;
    }
}