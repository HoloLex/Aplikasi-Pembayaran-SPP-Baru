namespace App_SPP_New
{
    partial class FormSPPP
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
            this.Kembali = new App_SPP_New.CustomUI.HXButton();
            this.CariTahun = new System.Windows.Forms.ComboBox();
            this.Reset = new App_SPP_New.CustomUI.HXButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.Close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Kembali);
            this.groupBox3.Controls.Add(this.CariTahun);
            this.groupBox3.Controls.Add(this.Reset);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(238, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 150);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
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
            this.Kembali.Location = new System.Drawing.Point(175, 59);
            this.Kembali.Name = "Kembali";
            this.Kembali.Size = new System.Drawing.Size(125, 34);
            this.Kembali.TabIndex = 43;
            this.Kembali.Text = "Kembali";
            this.Kembali.TextColor = System.Drawing.Color.Black;
            this.Kembali.UseVisualStyleBackColor = false;
            this.Kembali.Click += new System.EventHandler(this.Kembali_Click);
            // 
            // CariTahun
            // 
            this.CariTahun.FormattingEnabled = true;
            this.CariTahun.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.CariTahun.Location = new System.Drawing.Point(116, 25);
            this.CariTahun.Name = "CariTahun";
            this.CariTahun.Size = new System.Drawing.Size(184, 21);
            this.CariTahun.TabIndex = 23;
            this.CariTahun.SelectedIndexChanged += new System.EventHandler(this.CariTahun_SelectedIndexChanged);
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
            this.Reset.Location = new System.Drawing.Point(21, 59);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(125, 34);
            this.Reset.TabIndex = 39;
            this.Reset.Text = "Reset Pencarian";
            this.Reset.TextColor = System.Drawing.Color.Transparent;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tahun Tagihan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel List Tahun Dan Tagihannya";
            // 
            // DataTable
            // 
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(9, 20);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(761, 200);
            this.DataTable.TabIndex = 10;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(717, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(84, 36);
            this.Close.TabIndex = 9;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Tahun SPP";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Silver;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(636, 0);
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
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(801, 36);
            this.PnlTop.TabIndex = 17;
            // 
            // FormSPPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSPPP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form User/Pengguna";
            this.Load += new System.EventHandler(this.FormSPP_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.ComboBox CariTahun;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel PnlTop;
        private CustomUI.HXButton Reset;
        private CustomUI.HXButton Kembali;
    }
}