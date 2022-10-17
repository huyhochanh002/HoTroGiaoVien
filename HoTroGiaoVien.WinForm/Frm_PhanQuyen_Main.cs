using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroGiaoVien.WinForm
{
    public partial class Frm_PhanQuyen_Main : Form
    {
        public Frm_PhanQuyen_Main()
        {
            InitializeComponent();
        }
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        private void Frm_PhanQuyen_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
