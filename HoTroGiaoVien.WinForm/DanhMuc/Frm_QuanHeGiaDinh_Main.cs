﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroGiaoVien.WinForm.DanhMuc
{
    public partial class Frm_QuanHeGiaDinh_Main : Form
    {
        public Frm_QuanHeGiaDinh_Main()
        {
            InitializeComponent();
        }
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DongTab();
        }

        private void Frm_QuanHeGiaDinh_Main_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
        }
    }
}
