namespace App_SPP_New.View
{
    partial class TabelPetugas
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
            this.Tutup = new App_SPP_New.CustomUI.HXButton();
            this.label11 = new System.Windows.Forms.Label();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(12, 51);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(574, 189);
            this.DataTable.TabIndex = 2;
            // 
            // Tutup
            // 
            this.Tutup.BackColor = System.Drawing.Color.Black;
            this.Tutup.BackgrounColor = System.Drawing.Color.Black;
            this.Tutup.BorderColor = System.Drawing.Color.Black;
            this.Tutup.BorderRadius = 40;
            this.Tutup.BorderSize = 0;
            this.Tutup.FlatAppearance.BorderSize = 0;
            this.Tutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutup.ForeColor = System.Drawing.Color.White;
            this.Tutup.Location = new System.Drawing.Point(12, 263);
            this.Tutup.Name = "Tutup";
            this.Tutup.Size = new System.Drawing.Size(150, 40);
            this.Tutup.TabIndex = 3;
            this.Tutup.Text = "Tutup";
            this.Tutup.TextColor = System.Drawing.Color.White;
            this.Tutup.UseVisualStyleBackColor = false;
            this.Tutup.Click += new System.EventHandler(this.Tutup_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tabel Petugas";
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PnlTop.Controls.Add(this.label11);
            this.PnlTop.Controls.Add(this.Minimize);
            this.PnlTop.Controls.Add(this.Close);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(598, 36);
            this.PnlTop.TabIndex = 19;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Silver;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(439, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(84, 36);
            this.Minimize.TabIndex = 17;
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
            this.Close.Location = new System.Drawing.Point(514, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(84, 36);
            this.Close.TabIndex = 16;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_MouseMove);
            // 
            // TabelPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 329);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.Tutup);
            this.Controls.Add(this.DataTable);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabelPetugas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabelPetugas";
            this.Load += new System.EventHandler(this.TabelPetugas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataTable;
        private CustomUI.HXButton Tutup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
    }
}