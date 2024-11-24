namespace App_SPP_New.View
{
    partial class MenuStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuStart));
            this.Login = new System.Windows.Forms.Button();
            this.Keluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPetugas = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(129, 128);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(310, 58);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login Sebagai Admin";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Keluar
            // 
            this.Keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keluar.Location = new System.Drawing.Point(129, 310);
            this.Keluar.Name = "Keluar";
            this.Keluar.Size = new System.Drawing.Size(310, 58);
            this.Keluar.TabIndex = 1;
            this.Keluar.Text = "Keluar";
            this.Keluar.UseVisualStyleBackColor = true;
            this.Keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplikasi Pembayaran SPP";
            // 
            // LoginPetugas
            // 
            this.LoginPetugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPetugas.Location = new System.Drawing.Point(123, 220);
            this.LoginPetugas.Name = "LoginPetugas";
            this.LoginPetugas.Size = new System.Drawing.Size(310, 58);
            this.LoginPetugas.TabIndex = 3;
            this.LoginPetugas.Text = "Login Sebagai Petugas";
            this.LoginPetugas.UseVisualStyleBackColor = true;
            this.LoginPetugas.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(460, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(93, 35);
            this.Close.TabIndex = 9;
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
            this.Minimize.Location = new System.Drawing.Point(379, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(84, 35);
            this.Minimize.TabIndex = 15;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PnlTop.Controls.Add(this.label4);
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(553, 35);
            this.PnlTop.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Aplikasi Pembayaran SPP";
            // 
            // MenuStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(545, 447);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.LoginPetugas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Keluar);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuStart";
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Keluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginPetugas;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label label4;
    }
}