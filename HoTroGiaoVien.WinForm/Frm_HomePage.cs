
using HoTroGiaoVien.BussinessLayer.TacVu;
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
            IList<string> year=new List<string>();
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

            HienThiThongTinThongKe();
            HienThiLuoi(dgvCanBoLop, ref dtDanhSachCanBoLop, true);
            HienThiLuoi(dgvDanhSachSinhVien,ref dtDanhSachSinhVien, false);
            LoadcomBoLop(cboLopBanBo);
            statusLoadCboLop = false;
            LoadcomBoGiaoVien(cboGiaoVien);
            HienThiDanhSachLop();
        }
       
        private void HienThiDanhSachLop()
        {
            dtDanhSachLop = bLL__HomePage.LayDanhSachLop(ref err);

            dgvDanhSachLop.DataSource = dtDanhSachLop.DefaultView;
        }
        private void LoadcomBoLop(ComboBox comboBox)
        {
            DataTable dataTable = new DataTable();
            dataTable = bLL__HomePage.LayDuLieuChoComboLop(ref err,"0");//Chinh Lai theo thong tin dang nhap
            comboBox.DataSource = dataTable;

            comboBox.DisplayMember = "TenLop";
            comboBox.ValueMember = "MaLop";

            comboBox.SelectedIndex = -1;
            comboBox.Text = "---Chọn lớp---";
            statusLoadCboLop = true;
        }

        private void LoadcomBoGiaoVien(ComboBox comboBox)
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
        
        private void HienThiLuoi(DataGridView dgv,ref DataTable _dt,bool isCanBo)
        {
            _dt = bLL__HomePage.LayDanhSachSinhVien(ref err, isCanBo);
            dgv.DataSource = _dt.DefaultView;
        }
        private void HienThiThongTinThongKe()
        {
            dataTable = bLL__HomePage.LaySoLuongThuongKe(ref err);
            LoadDataChart(dataTable);
        }
        public void HienThiBieuDo(IList<string> year,ChartValues<int> quantity,ChartValues<int> studentBreak)
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

        private void txtSearchingCanBo_TextChanged(object sender, EventArgs e)
        {

        }


        private void cboLopBanBo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopBanBo.SelectedIndex > -1 && statusLoadCboLop == true)
            {

            }
        }

       
    }
}
