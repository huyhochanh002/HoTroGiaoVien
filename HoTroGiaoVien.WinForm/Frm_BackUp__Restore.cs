using HoTroGiaoVien.BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroGiaoVien.WinForm
{
    public partial class Frm_BackUp__Restore : Form
    {
        public Frm_BackUp__Restore()
        {
            InitializeComponent();
        }
        string err = string.Empty;

        BLL_HeThong db;
        private void ckSaoLuu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSaoLuu.Checked)
            {
                ckSaoLuu.Text = "Backup database";

            }
            else
            {
                ckSaoLuu.Text = "Restore database";
            }
        }

        private void btnChonfile_Click(object sender, EventArgs e)
        {
            if (ckSaoLuu.Checked)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
                save.RestoreDirectory = true;
                save.AddExtension = true;
                save.DefaultExt = "bak";
                save.FileName = string.Format("backup_{0:0000}{1:00}{2:00}{3:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Second);
                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = save.FileName;
                }
            }
            else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
                open.RestoreDirectory = true;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = open.FileName;
                }

            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (ckSaoLuu.Checked)
            {
                lblErr.Text = "Đang sao lưu dữ liệu...";
                lblErr.ForeColor = Color.Red;
                Application.DoEvents();
                if (File.Exists(txtPath.Text))
                {
                    File.Delete(txtPath.Text);
                }

                try
                {

                    if (db.Backup(ref err, txtPath.Text))
                    {
                        lblErr.Text = "Đã sao lưu thành công";
                        lblErr.ForeColor = Color.White;
                    }
                    else
                    {
                        lblErr.Text = "Sao lưu không thành công" + err;
                        lblErr.ForeColor = Color.White;
                    }
                }
                catch (Exception ex)
                {
                    err = ex.Message;
                    lblErr.Text = "Sao lưu không thành công." + err;
                    lblErr.ForeColor = Color.Blue;

                }
            }
            else
            {
                //Phuc Hoi
                lblErr.Text = "Đang phục hồi dữ liệu...";
                lblErr.ForeColor = Color.Red;
                Application.DoEvents();
                string err = "";
                try
                {
                    string sql = string.Format("USE Master \n ALTER DATABASE {0} SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + " RESTORE DATABASE {1} FROM DISK = N'{2}' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10" + " ALTER DATABASE {3} SET MULTI_USER", ClsMain.connectionStringBuilder.InitialCatalog, ClsMain.connectionStringBuilder.InitialCatalog, txtPath.Text, ClsMain.connectionStringBuilder.InitialCatalog);
                    if (db.Restore( ref err,sql))
                    {
                        lblErr.Text = "Đã phục hồi thành công";
                        lblErr.ForeColor = Color.White;
                    }
                    else
                    {
                        lblErr.Text = "Phục hồi không thành công" + err;
                        lblErr.ForeColor = Color.White;
                    }
                }
                catch (Exception ex)
                {
                    err = ex.Message;
                    lblErr.Text = "Sao lưu không thành công" + err;
                    lblErr.ForeColor = Color.Blue;

                }
            }

        }
    }
}
