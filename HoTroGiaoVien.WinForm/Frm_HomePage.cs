
using HoTroGiaoVien.BussinessLayer.TacVu;
using HoTroGiaoVien.DAO.EF;
using HoTroGiaoVien.WinForm.TacVu;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace HoTroGiaoVien.WinForm
{
    public partial class Frm_HomePage : Form
    {
        public Frm_HomePage()
        {
            InitializeComponent();


        }
        public FrmMain frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;

        BLL__HomePage bLL__HomePage;

        IList<string> year;
        ChartValues<int> listquantity;
        ChartValues<int> liststudentBreak;

        List<MyChart> list;

        DataTable dataTable;

        int male = 0;
        int female = 0;
        int quantity = 0;

        DataTable dtDanhSachLop;
        DataTable dtDanhSachCanBoLop;
        DataTable dtDanhSachSinhVien;

        string err = string.Empty;
        bool statusLoadCboLop = false;
        bool statusLoadCboGV = false;


        private void LoadDataChart(List<MyChart> list)
        {
            IList<string> year = new List<string>();
            ChartValues<int> listquantity = new ChartValues<int>();
            ChartValues<int> liststudentBreak = new ChartValues<int>();
            foreach (var item in list)
            {
                year.Add(item.Year.ToString());
                listquantity.Add(item.Quantity);
                liststudentBreak.Add(item.StudentBreak);

                male += item.Male;

                female += item.Female;

                quantity += item.Quantity;
            }

            lblSoLuongSinhVien.Text = string.Format("{0:#,###0}", quantity);
            lblNam.Text = string.Format("{0:#,###0}", male);
            lblNu.Text = string.Format("{0:#,###0}", female);

            HienThiBieuDo(year, listquantity, liststudentBreak);
        }
        private void LoadDataChart(DataTable list)
        {
            IList<string> year = new List<string>();
            ChartValues<int> listquantity = new ChartValues<int>();
            ChartValues<int> liststudentBreak = new ChartValues<int>();
            foreach (DataRow item in list.Rows)
            {
                year.Add(item["Nam"].ToString());
                listquantity.Add(Convert.ToInt32(item["Tong"].ToString()));
                liststudentBreak.Add(Convert.ToInt32(item["nghi"].ToString()));

                male += Convert.ToInt32(item["Male"].ToString());

                female += Convert.ToInt32(item["Female"].ToString());

                quantity += Convert.ToInt32(item["Tong"].ToString());
            }

            lblSoLuongSinhVien.Text = string.Format("{0:#,###0}", quantity);
            lblNam.Text = string.Format("{0:#,###0}", male);
            lblNu.Text = string.Format("{0:#,###0}", female);

            HienThiBieuDo(year, listquantity, liststudentBreak);
        }
        private void Frm_HomePage_Load(object sender, EventArgs e)
        {
            bLL__HomePage = new BLL__HomePage(ClsMain.arrayPath, ClsMain.fileType);

            statusLoadCboLop = false;
            LoadcomBoGiaoVien(cboGiaoVien);
            //Hiển thị danh sách lớp trên Lưới
            HienThiDanhSachLop();

            tabControl1.SelectedTabIndex = 0;

            if (!ClsMain.giaoVien.MaNhom.Equals("1"))
            {
                HienThiThongTinThongKe(ClsMain.giaoVien.MaGiaoVien);
                cboGiaoVien.Enabled = false;
                cboGiaoVien.SelectedValue = ClsMain.giaoVien.MaGiaoVien;

                HienThiLuoi(dgvCanBoLop, ref dtDanhSachCanBoLop, true, ClsMain.giaoVien.MaGiaoVien);
                HienThiLuoi(dgvDanhSachSinhVien, ref dtDanhSachSinhVien, false, ClsMain.giaoVien.MaGiaoVien);
                LoadcomBoLop(cboLop, ClsMain.giaoVien.MaGiaoVien);
            }
            else
            {
                HienThiThongTinThongKe("0");
                HienThiLuoi(dgvCanBoLop, ref dtDanhSachCanBoLop, true, "0");
                HienThiLuoi(dgvDanhSachSinhVien, ref dtDanhSachSinhVien, false, "0");
                LoadcomBoLop(cboLop, "0");
            }


        }

        private void HienThiDanhSachLop()
        {
            dtDanhSachLop = new DataTable();
            dtDanhSachLop = bLL__HomePage.LayDanhSachLop(ref err);

            dgvDanhSachLop.DataSource = dtDanhSachLop.DefaultView;
            lblSoLuongLop.Text = String.Format("{0:#,###}", dtDanhSachLop.Rows.Count);
        }
        private void LoadcomBoLop(ComboBox comboBox, string maGiaoVien)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = bLL__HomePage.LayDuLieuChoComboLop(ref err, maGiaoVien);
                //Chinh Lai theo thong tin dang nhap
                comboBox.DataSource = dataTable;

                comboBox.DisplayMember = "TenLop";
                comboBox.ValueMember = "MaLop";

                comboBox.SelectedIndex = -1;
                comboBox.Text = "---Chọn lớp---";
                statusLoadCboLop = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                lblErr.Text = err;
                lblErr.ForeColor = Color.Red;
            }

        }

        private void LoadcomBoGiaoVien(ComboBox comboBox)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = bLL__HomePage.LayDuLieuChoComboGiaoVien(ref err);
                comboBox.DataSource = dataTable;

                comboBox.DisplayMember = "HoTenGiaoVien";
                comboBox.ValueMember = "MaGiaoVien";

                comboBox.SelectedIndex = -1;
                comboBox.Text = "---Chọn Giáo viên---";
                statusLoadCboGV = true;
            }
            catch (Exception ex)
            {

                err = ex.Message;
                lblErr.Text = err;
                lblErr.ForeColor = Color.Red;
            }

        }
        /// <summary>
        /// Hiển thị danh sách sinh viên trên lưới
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="_dt"></param>
        /// <param name="isCanBo"></param>
        private void HienThiLuoi(DataGridView dgv, ref DataTable _dt, bool isCanBo, string maGiaovien)
        {
            _dt = bLL__HomePage.LayDanhSachSinhVien(ref err, isCanBo, maGiaovien);
            dgv.DataSource = _dt.DefaultView;
            lblSoLuongTong.Text = string.Format("{0:#,###0}", _dt.DefaultView.Count);
        }
        private void HienThiThongTinThongKe(string maGiaoVien)
        {
            dataTable = bLL__HomePage.LaySoLuongThuongKe(ref err, maGiaoVien);
            LoadDataChart(dataTable);
        }
        public void HienThiBieuDo(IList<string> year, ChartValues<int> quantity, ChartValues<int> studentBreak)
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "SV đang học",
                    Values = quantity
                },
                new LineSeries
                {
                    Title = "SV nghỉ",
                    Values = studentBreak
                   // PointGeometry = null
                },
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Năm",
                Labels = year
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Số lượng sinh viên",
                LabelFormatter = value => value.ToString()
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

            ////modifying the series collection will animate and update the chart
            //cartesianChart1.Series.Add(new LineSeries
            //{
            //    Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
            //    LineSmoothness = 0, //straight lines, 1 really smooth lines
            //    PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
            //    PointGeometrySize = 50,
            //    PointForeground = System.Windows.Media.Brushes.Gray
            //});

            //modifying any series values will also animate and update the chart
            //  cartesianChart1.Series[2].Values.Add(5d);


            cartesianChart1.DataClick += CartesianChart1OnDataClick;

        }
        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Frm_Contact_SinhVien frmProfile_SinhVien = new Frm_Contact_SinhVien();
            frmProfile_SinhVien.ShowDialog();
        }

        private void txtSearchingSV_TextChanged(object sender, EventArgs e)
        {
            DataView view = dtDanhSachSinhVien.DefaultView;
            view.RowFilter = string.Empty;

            if (!string.IsNullOrEmpty(txtSearchingSV.Text))
            {
                if (ckbSearchingbyTen.Checked)
                {
                    view.RowFilter = string.Format("TenSinhVien like '{0}%'", txtSearchingSV.Text);

                }
                else
                {
                    view.RowFilter = string.Format("MaSinhVien like '{0}%'", txtSearchingSV.Text);
                }
            }
            else
            {
                view.RowFilter = string.Empty;
            }
            dgvDanhSachSinhVien.DataSource = view;
            lblSoLuongTong.Text = string.Format("{0:#,###0}", view.Count);
        }


        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataView view = dtDanhSachSinhVien.DefaultView;
            view.RowFilter = string.Empty;
            if (cboLop.SelectedIndex > -1 && statusLoadCboLop == true)
            {
                if (cboLop.SelectedValue.ToString().Equals("0"))
                {
                    view.RowFilter = string.Empty;
                }
                else
                {
                    view.RowFilter = string.Format("MaLop like '{0}%'", cboLop.SelectedValue.ToString());
                    lblTitleStudentList.Text = string.Format("Danh sách sinh viên lớp {0}", cboLop.SelectedValue.ToString());
                }

            }
            else
            {
                view.RowFilter = string.Empty;
            }
            dgvDanhSachSinhVien.DataSource = view;
            lblSoLuongTong.Text = string.Format("{0:#,###0}", view.Count);
        }

        private void ckbSearchingbyTen_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSearchingbyTen.Checked)
            {
                ckbSearchingbyTen.Text = "Theo tên";
            }
            else
            {
                ckbSearchingbyTen.Text = "Theo MSSV";
            }
        }

        private void txtSearchingGiaoVien_TextChanged(object sender, EventArgs e)
        {
            DataView view = dtDanhSachLop.DefaultView;
            view.RowFilter = string.Empty;

            if (!string.IsNullOrEmpty(txtSearchingGiaoVien.Text))
            {
                if (ckbSearchingbyTen.Checked)
                {
                    view.RowFilter = string.Format("TenGiaoVien like '{0}%'", txtSearchingGiaoVien.Text);

                }
                else
                {
                    view.RowFilter = string.Format("MaGiaoVien like '{0}%'", txtSearchingGiaoVien.Text);
                }
            }
            else
            {
                view.RowFilter = string.Empty;
            }
            dgvDanhSachLop.DataSource = view;
            lblSoLuongLop.Text = string.Format("{0:#,###0}", view.Count);
        }

        private void cboGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtDanhSachLop != null)
            {
                DataView view = dtDanhSachLop.DefaultView;
                view.RowFilter = string.Empty;
                if (cboGiaoVien.SelectedIndex > -1 && statusLoadCboGV == true)
                {
                    if (cboGiaoVien.SelectedValue.ToString().Equals("0"))
                    {
                        view.RowFilter = string.Empty;
                    }
                    else { view.RowFilter = string.Format("MaGiaoVien like '%{0}%'", cboGiaoVien.SelectedValue.ToString()); }

                }
                else
                {
                    view.RowFilter = string.Empty;
                }
                dgvDanhSachLop.DataSource = view;
                lblSoLuongLop.Text = string.Format("{0:#,###0}", view.Count);
            }
        }

        private void ckbTenGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTenGiaoVien.Checked)
            {
                ckbTenGiaoVien.Text = "Theo tên";
            }
            else
            {
                ckbTenGiaoVien.Text = "Theo MSSV";
            }
        }

        private void tabControl1_SelectedTabChanging(object sender, DevComponents.DotNetBar.TabStripTabChangingEventArgs e)
        {
            if (tabControl1.SelectedTabIndex == 0)//Chon tab danh sach sinh vien
            {
                cboLop.Enabled = true;
                txtSearchingSV.Enabled = true;
            }
            else
            {
                cboLop.Enabled = false;
                txtSearchingSV.Enabled = false;
            }
        }
        /// <summary>
        /// Hiển thị profile của sinh viên được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDanhSachSinhVien_DoubleClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVien))
            {
                Frm_Profile_SinhVien frm_Profile_SinhVien = new Frm_Profile_SinhVien();
                frm_Profile_SinhVien.openFromHomePage = true;
                frm_Profile_SinhVien.maSinhVien = maSinhVien;
                frm_Profile_SinhVien.ShowDialog();
            }
        }
        SinhVien sinhVien;
        string maSinhVien = string.Empty;
        private void dgvDanhSachSinhVien_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSinhVien.Rows.Count > 0)
            {
                //sinhVien = new SinhVien()
                //{
                //    MaSinhVien = dgvDanhSachSinhVien.CurrentRow.Cells["colMaSinhVien"].Value.ToString()
                //};
                maSinhVien = dgvDanhSachSinhVien.CurrentRow.Cells["colMaSinhVien"].Value.ToString();
            }
        }

        private void dgvCanBoLop_DoubleClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSinhVien))
            {
                Frm_Profile_SinhVien frm_Profile_SinhVien = new Frm_Profile_SinhVien();
                frm_Profile_SinhVien.openFromHomePage = true;
                frm_Profile_SinhVien.maSinhVien = maSinhVien;
                frm_Profile_SinhVien.ShowDialog();
            }
        }

        private void dgvCanBoLop_Click(object sender, EventArgs e)
        {
            if (dgvCanBoLop.Rows.Count > 0)
            {
                maSinhVien = dgvCanBoLop.CurrentRow.Cells["colMSSVCanBo"].Value.ToString();
            }
        }
    }
}
