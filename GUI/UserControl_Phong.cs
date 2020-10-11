using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Properties;

namespace GUI
{
    public partial class UserControl_Phong : UserControl
    {
        public UserControl_Phong(GUI_FormPhong parent)
        {
            InitializeComponent();
            pnNen.Click += delegate { parent.MoFormThongTinPhong(parent, this); };
            pbLoaiphong.Click += delegate { parent.MoFormThongTinPhong(parent, this); };
            pbTrangThai.Click += delegate { parent.MoFormThongTinPhong(parent, this); };
            pbVip.Click += delegate { parent.MoFormThongTinPhong(parent, this); };
            label1.Click += delegate { parent.MoFormThongTinPhong(parent, this); };
            lbSoPhong.Click += delegate { parent.MoFormThongTinPhong(parent, this); };
            lbTrangThai.Click += delegate { parent.MoFormThongTinPhong(parent, this); };
            pnThanhNgang.Click += delegate { parent.MoFormThongTinPhong(parent, this); };
        }

        #region ThuocTinh

        private int SoPhong;
        private int TinhTrangPhong; //Tình trạng phòng: 1.Còn trống 2.Đã thuê 3.Đang dọn 4.Đang Sửa
        private int LoaiPhong; //Loại phòng: 1.Vip đơn 2.Vip Đôi 3.Thường đơn 4.Thường đôi

        public int _SoPhong
        {
            get { return SoPhong; }
            set { SoPhong = value; lbSoPhong.Text = value.ToString(); }
        }

        public int _TinhTrangPhong
        {
            get { return TinhTrangPhong; }
            set { 
                TinhTrangPhong = value;
                switch (value)
                {
                    case 1:
                        DatTrangThaiTrong();
                        break;
                    case 2:
                        DatTrangThaiDaThue();
                        break;
                    case 3:
                        DatTrangThaiDangDon();
                        break;
                    case 4:
                        DatTrangThaiDangSua();
                        break;
                }
            }
        }

        public int _LoaiPhong
        {
            get { return LoaiPhong; }
            set { 
                LoaiPhong = value;
                switch (value)
                {
                    case 1:
                        pbVip.Image = Resources.icVip;
                        pbLoaiphong.Image = Resources.icPhongDon;
                        break;
                    case 2:
                        pbVip.Image = Resources.icVip;
                        pbLoaiphong.Image = Resources.icPhongDoi;
                        break;
                    case 3:
                        pbLoaiphong.Image = Resources.icPhongDon;
                        break;
                    case 4:
                        pbLoaiphong.Image = Resources.icPhongDoi;
                        break;
                }
            }
        }

        #endregion

        private void UserControl_Phong_Load(object sender, EventArgs e)
        {
            pbBong.Image = Resources.imgNen;
            pbBong.Hide();
        }

        public void DatTrangThaiTrong()
        {
            lbTrangThai.Text = "Còn trống";
            pbTrangThai.Image = Resources.icYes;
            pnNen.BackColor = Color.FromArgb(181, 235, 220);
            pnThanhNgang.BackColor = Color.FromArgb(103, 222, 190);
            label1.BackColor = Color.FromArgb(181, 235, 220);
            lbSoPhong.BackColor = Color.FromArgb(181, 235, 220);
            lbTrangThai.BackColor = Color.FromArgb(181, 235, 220);
            pbTrangThai.BackColor = Color.FromArgb(181, 235, 220);
        }

        public void DatTrangThaiDaThue()
        {
            lbTrangThai.Text = "Đã thuê";
            pbTrangThai.Image = (LoaiPhong == 1 || LoaiPhong == 3) ? Resources.icDaThueDon : Resources.icDaThueDoi;
            pnNen.BackColor = Color.FromArgb(255, 200, 227);
            pnThanhNgang.BackColor = Color.FromArgb(255, 113, 184);
            label1.BackColor = Color.FromArgb(255, 200, 227);
            lbSoPhong.BackColor = Color.FromArgb(255, 200, 227);
            lbTrangThai.BackColor = Color.FromArgb(255, 200, 227);
            pbTrangThai.BackColor = Color.FromArgb(255, 200, 227);
        }

        public void DatTrangThaiDangDon()
        {
            lbTrangThai.Text = "Đang dọn";
            pbTrangThai.Image = Resources.icDonDep;
            pnNen.BackColor = Color.FromArgb(150, 228, 252);
            pnThanhNgang.BackColor = Color.FromArgb(0, 194, 255);
            label1.BackColor = Color.FromArgb(150, 228, 252);
            lbSoPhong.BackColor = Color.FromArgb(150, 228, 252);
            lbTrangThai.BackColor = Color.FromArgb(150, 228, 252);
            pbTrangThai.BackColor = Color.FromArgb(150, 228, 252);
        }

        public void DatTrangThaiDangSua()
        {
            lbTrangThai.Text = "Đang sửa";
            pbTrangThai.Image = Resources.icSuaChua;
            pnNen.BackColor = Color.FromArgb(247, 249, 194);
            pnThanhNgang.BackColor = Color.FromArgb(244, 251, 53);
            label1.BackColor = Color.FromArgb(247, 249, 194);
            lbSoPhong.BackColor = Color.FromArgb(247, 249, 194);
            lbTrangThai.BackColor = Color.FromArgb(247, 249, 194);
            pbTrangThai.BackColor = Color.FromArgb(247, 249, 194);
        }
        //
        //Hiệu ứng
        //
        private void pnNen_MouseMove(object sender, MouseEventArgs e)
        {
            pbBong.Show();
        }

        private void pnNen_MouseLeave(object sender, EventArgs e)
        {
            pbBong.Hide();
        }

        private void pnNen_Click(object sender, EventArgs e)
        {
            
        }
    }
}
