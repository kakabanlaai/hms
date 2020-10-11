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
    public partial class GUI_FormThongTinPhong : UserControl
    {
        public GUI_FormThongTinPhong(GUI_FormPhong formhienthiphong, UserControl_Phong daidienphong)
        {
            InitializeComponent();
            pictureBox4.Click += delegate { formhienthiphong.DongFormThongTinPhong(this); };
        }

    }
}
