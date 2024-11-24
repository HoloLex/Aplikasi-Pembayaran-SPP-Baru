namespace App_SPP_New.View
{
    partial class LoginPetugas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPetugas));
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Loginn = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.BackColor = System.Drawing.Color.Transparent;
            this.ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPass.Location = new System.Drawing.Point(15, 191);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(102, 17);
            this.ShowPass.TabIndex = 14;
            this.ShowPass.Text = "Show Password";
            this.ShowPass.UseVisualStyleBackColor = false;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Silver;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(15, 279);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(216, 35);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Kembali ke Menu";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aplikasi Pembayaran SPP (Petugas)";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Gray;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(15, 96);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Username.Size = new System.Drawing.Size(185, 20);
            this.Username.TabIndex = 11;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Gray;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(15, 156);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(185, 20);
            this.Password.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // Loginn
            // 
            this.Loginn.BackColor = System.Drawing.Color.Silver;
            this.Loginn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginn.Location = new System.Drawing.Point(15, 228);
            this.Loginn.Name = "Loginn";
            this.Loginn.Size = new System.Drawing.Size(216, 35);
            this.Loginn.TabIndex = 15;
            this.Loginn.Text = "Login";
            this.Loginn.UseVisualStyleBackColor = false;
            this.Loginn.Click += new System.EventHandler(this.Login_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(192, -1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 25);
            this.Close.TabIndex = 16;
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
            this.Minimize.Location = new System.Drawing.Point(125, -1);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(75, 25);
            this.Minimize.TabIndex = 17;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PnlTop.Controls.Add(this.label4);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(266, 24);
            this.PnlTop.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Login";
            // 
            // LoginPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(266, 363);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Loginn);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPetugas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPetugas";
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowPass;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Loginn;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label label4;
    }
}