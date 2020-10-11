namespace GUI
{
    partial class UserControl_Phong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbBong = new System.Windows.Forms.PictureBox();
            this.pnNen = new System.Windows.Forms.Panel();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.pnThanhNgang = new System.Windows.Forms.Panel();
            this.pbLoaiphong = new System.Windows.Forms.PictureBox();
            this.pbVip = new System.Windows.Forms.PictureBox();
            this.pbTrangThai = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSoPhong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBong)).BeginInit();
            this.pnNen.SuspendLayout();
            this.pnThanhNgang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaiphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrangThai)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBong
            // 
            this.pbBong.Location = new System.Drawing.Point(0, 0);
            this.pbBong.Name = "pbBong";
            this.pbBong.Size = new System.Drawing.Size(210, 170);
            this.pbBong.TabIndex = 0;
            this.pbBong.TabStop = false;
            // 
            // pnNen
            // 
            this.pnNen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.pnNen.Controls.Add(this.lbTrangThai);
            this.pnNen.Controls.Add(this.pnThanhNgang);
            this.pnNen.Controls.Add(this.pbTrangThai);
            this.pnNen.Controls.Add(this.label1);
            this.pnNen.Controls.Add(this.lbSoPhong);
            this.pnNen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnNen.Location = new System.Drawing.Point(0, 0);
            this.pnNen.Name = "pnNen";
            this.pnNen.Size = new System.Drawing.Size(200, 160);
            this.pnNen.TabIndex = 5;
            this.pnNen.Click += new System.EventHandler(this.pnNen_Click);
            this.pnNen.MouseLeave += new System.EventHandler(this.pnNen_MouseLeave);
            this.pnNen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnNen_MouseMove);
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lbTrangThai.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lbTrangThai.Location = new System.Drawing.Point(58, 61);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(112, 29);
            this.lbTrangThai.TabIndex = 3;
            this.lbTrangThai.Text = "Trạng thái";
            this.lbTrangThai.Click += new System.EventHandler(this.pnNen_Click);
            this.lbTrangThai.MouseLeave += new System.EventHandler(this.pnNen_MouseLeave);
            this.lbTrangThai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnNen_MouseMove);
            // 
            // pnThanhNgang
            // 
            this.pnThanhNgang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(222)))), ((int)(((byte)(190)))));
            this.pnThanhNgang.Controls.Add(this.pbLoaiphong);
            this.pnThanhNgang.Controls.Add(this.pbVip);
            this.pnThanhNgang.Location = new System.Drawing.Point(0, 120);
            this.pnThanhNgang.Name = "pnThanhNgang";
            this.pnThanhNgang.Size = new System.Drawing.Size(200, 40);
            this.pnThanhNgang.TabIndex = 0;
            this.pnThanhNgang.Click += new System.EventHandler(this.pnNen_Click);
            this.pnThanhNgang.MouseLeave += new System.EventHandler(this.pnNen_MouseLeave);
            this.pnThanhNgang.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnNen_MouseMove);
            // 
            // pbLoaiphong
            // 
            this.pbLoaiphong.Location = new System.Drawing.Point(152, 0);
            this.pbLoaiphong.Name = "pbLoaiphong";
            this.pbLoaiphong.Size = new System.Drawing.Size(48, 40);
            this.pbLoaiphong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoaiphong.TabIndex = 4;
            this.pbLoaiphong.TabStop = false;
            this.pbLoaiphong.Click += new System.EventHandler(this.pnNen_Click);
            this.pbLoaiphong.MouseLeave += new System.EventHandler(this.pnNen_MouseLeave);
            this.pbLoaiphong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnNen_MouseMove);
            // 
            // pbVip
            // 
            this.pbVip.Location = new System.Drawing.Point(108, 0);
            this.pbVip.Name = "pbVip";
            this.pbVip.Size = new System.Drawing.Size(48, 40);
            this.pbVip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVip.TabIndex = 4;
            this.pbVip.TabStop = false;
            this.pbVip.Click += new System.EventHandler(this.pnNen_Click);
            this.pbVip.MouseLeave += new System.EventHandler(this.pnNen_MouseLeave);
            this.pbVip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnNen_MouseMove);
            // 
            // pbTrangThai
            // 
            this.pbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.pbTrangThai.Location = new System.Drawing.Point(10, 55);
            this.pbTrangThai.Name = "pbTrangThai";
            this.pbTrangThai.Size = new System.Drawing.Size(48, 40);
            this.pbTrangThai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrangThai.TabIndex = 2;
            this.pbTrangThai.TabStop = false;
            this.pbTrangThai.Click += new System.EventHandler(this.pnNen_Click);
            this.pbTrangThai.MouseLeave += new System.EventHandler(this.pnNen_MouseLeave);
            this.pbTrangThai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnNen_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng";
            this.label1.Click += new System.EventHandler(this.pnNen_Click);
            this.label1.MouseLeave += new System.EventHandler(this.pnNen_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnNen_MouseMove);
            // 
            // lbSoPhong
            // 
            this.lbSoPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lbSoPhong.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lbSoPhong.Location = new System.Drawing.Point(101, 0);
            this.lbSoPhong.Name = "lbSoPhong";
            this.lbSoPhong.Size = new System.Drawing.Size(70, 41);
            this.lbSoPhong.TabIndex = 1;
            this.lbSoPhong.Text = "101";
            this.lbSoPhong.Click += new System.EventHandler(this.pnNen_Click);
            this.lbSoPhong.MouseLeave += new System.EventHandler(this.pnNen_MouseLeave);
            this.lbSoPhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnNen_MouseMove);
            // 
            // UserControl_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnNen);
            this.Controls.Add(this.pbBong);
            this.Name = "UserControl_Phong";
            this.Size = new System.Drawing.Size(210, 170);
            this.Load += new System.EventHandler(this.UserControl_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBong)).EndInit();
            this.pnNen.ResumeLayout(false);
            this.pnNen.PerformLayout();
            this.pnThanhNgang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaiphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrangThai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBong;
        private System.Windows.Forms.Panel pnNen;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Panel pnThanhNgang;
        private System.Windows.Forms.PictureBox pbLoaiphong;
        private System.Windows.Forms.PictureBox pbVip;
        private System.Windows.Forms.PictureBox pbTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSoPhong;
    }
}
