using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_FormPhong : UserControl
    {
        public delegate void TaoFormThongTin();
        public TaoFormThongTin temp;

        public GUI_FormPhong()
        {
            InitializeComponent();
        }

        private void TaoPhong()
        {
            UserControl_Phong temp = new UserControl_Phong(this);
            temp._LoaiPhong = 1;
            temp._SoPhong = 202;
            temp._TinhTrangPhong = 1;
            this.flpnHienThiPhong.Controls.Add(temp);
        }

        private void TaiDuLieu()
        {
            TaoPhong();
        }

        private void GUI_FormPhong_Load(object sender, EventArgs e)
        {
            TaoPhong();
            panel4.Hide();
        }

        public void MoFormThongTinPhong(GUI_FormPhong formhienthiphong, UserControl_Phong daidienphong)
        {
            panel4.Show();
            GUI_FormThongTinPhong temp = new GUI_FormThongTinPhong(formhienthiphong, daidienphong);
            panel4.Controls.Add(temp);
        }

        public void DongFormThongTinPhong(GUI_FormThongTinPhong sender)
        {
            panel4.Controls.Remove(sender);
            panel4.Hide();
        }
    }
}
