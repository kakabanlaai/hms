using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_FormChinh : Form
    {
        public GUI_FormChinh()
        {
            InitializeComponent();
        }

        private bool isChonBtPhong = false, isChonBtDV = false, isChonBtBaoCao = false, ischonBtQuanLy = false;

        private void GUI_FormChinh_Load(object sender, EventArgs e)
        {
            isChonBtPhong = true;
            AnDauChon();
            pnSubMenuDV.Hide();
            pnSubMenuQuanLy.Hide();
            pnSubMenuBaoCao.Hide();
            pbAnhNhanVien.Image = Resources.icLeTan;
            GUI_FormPhong temp = new GUI_FormPhong();
            panel4.Controls.Add(temp);
        }

        private void AnDauChon()
        {
            if (!isChonBtBaoCao)
            {
                pnDauChonBaoCao.Hide();
            }
            if (!isChonBtDV)
            {
                pnDauChonDV.Hide();
            }
            if (!isChonBtPhong)
            {
                pnDauChonPhong.Hide();
            }
            if (!ischonBtQuanLy)
            {
                pnDauChonQuanLy.Hide();
            }
        }

        private void DatLaiTrangThai()
        {
            if (ischonBtQuanLy)
            {
                ischonBtQuanLy = false;
                pnDauChonQuanLy.Hide();
                pbMuiTenQL.Image = Resources.icTenNgang;
                pnSubMenuQuanLy.Hide();
            }
            if (isChonBtPhong)
            {
                isChonBtPhong = false;
                pnDauChonPhong.Hide();
            }
            if (isChonBtDV)
            {
                isChonBtDV = false;
                pnDauChonDV.Hide();
                pbMuiTenDV.Image = Resources.icTenNgang;
                pnSubMenuDV.Hide();
            }
            if (isChonBtBaoCao)
            {
                isChonBtBaoCao = false;
                pnDauChonBaoCao.Hide();
                pbMuiTenBC.Image = Resources.icTenNgang;
                pnSubMenuBaoCao.Hide();
            }

        }
        //
        //Xử lý button Dịch vụ
        //
        private void btDichvu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChonBtDV)
            {
                pnDauChonDV.Show();
            }
            btDichvu.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void btDichvu_MouseLeave(object sender, EventArgs e)
        {
            if (!isChonBtDV)
            {
                pnDauChonDV.Hide();
            }
            btDichvu.BackColor = Color.White;
        }

        private void btDichvu_Click(object sender, EventArgs e)
        {
            DatLaiTrangThai();
            isChonBtDV = true;
            pnDauChonDV.Show();
            pbMuiTenDV.Image = Resources.icTenDoc;
            pnSubMenuDV.Show();
        }
        //
        //Xử lý button Báo cáo
        //
        private void btBaoCao_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChonBtBaoCao)
            {
                pnDauChonBaoCao.Show();
            }
            btBaoCao.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void btBaoCao_MouseLeave(object sender, EventArgs e)
        {
            if (!isChonBtBaoCao)
            {
                pnDauChonBaoCao.Hide();
            }
            btBaoCao.BackColor = Color.White;
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            DatLaiTrangThai();
            isChonBtBaoCao = true;
            pnDauChonBaoCao.Show();
            pbMuiTenBC.Image = Resources.icTenDoc;
            pnSubMenuBaoCao.Show();
        }
        //
        //Xử lý button quản lý
        //
        private void btQuanLy_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ischonBtQuanLy)
            {
                pnDauChonQuanLy.Show();
            }
            btQuanLy.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void btQuanLy_MouseLeave(object sender, EventArgs e)
        {
            if (!ischonBtQuanLy)
            {
                pnDauChonQuanLy.Hide();
            }
            btQuanLy.BackColor = Color.White;
        }

        private void btQuanLy_Click(object sender, EventArgs e)
        {
            DatLaiTrangThai();
            ischonBtQuanLy = true;
            pnDauChonQuanLy.Show();
            pbMuiTenQL.Image = Resources.icTenDoc;
            pnSubMenuQuanLy.Show();
        }
        //
        //Xử lý button Phòng
        //
        private void btPhong_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChonBtPhong)
            {
                pnDauChonPhong.Show();
            }
            btPhong.BackColor=Color.FromArgb(246, 246, 246);
        }

        private void btPhong_MouseLeave(object sender, EventArgs e)
        {
            if (!isChonBtPhong)
            {
                pnDauChonPhong.Hide();
            }
            btPhong.BackColor = Color.White;
        }

        private void btPhong_Click(object sender, EventArgs e)
        {
            DatLaiTrangThai();
            isChonBtPhong = true;
            pnDauChonPhong.Show();
        }

        //Hieu ung panel menu con DichVu
        private void pnAnUong_MouseMove(object sender, MouseEventArgs e)
        {
            pnAnUong.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnAnUong_MouseLeave(object sender, EventArgs e)
        {
            pnAnUong.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void pnGiatUi_MouseMove(object sender, MouseEventArgs e)
        {
            pnGiatUi.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnGiatUi_MouseLeave(object sender, EventArgs e)
        {
            pnGiatUi.BackColor = Color.FromArgb(245, 245, 245);
        }

        //Hieu ung panel menu con BaoCao
        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            pnDoanhThu.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            pnDoanhThu.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            pnHoaDon.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            pnHoaDon.BackColor = Color.FromArgb(245, 245, 245);
        }

        //Hieu ung panel menu con QuanLy
        private void pnNhanVien_MouseMove(object sender, MouseEventArgs e)
        {
            pnNhanVien.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            pnNhanVien.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void pnKhachHang_MouseMove(object sender, MouseEventArgs e)
        {
            pnKhachHang.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnKhachHang_MouseLeave(object sender, EventArgs e)
        {
            pnKhachHang.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void pnKhoHang_MouseMove(object sender, MouseEventArgs e)
        {
            pnKhoHang.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnKhoHang_MouseLeave(object sender, EventArgs e)
        {
            pnKhoHang.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void pnDichVu_MouseMove(object sender, MouseEventArgs e)
        {
            pnDichVu.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnDichVu_MouseLeave(object sender, EventArgs e)
        {
            pnDichVu.BackColor = Color.FromArgb(245, 245, 245);
        }


    }
}
