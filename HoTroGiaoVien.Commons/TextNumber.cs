using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroGiaoVien.Commons
{
    public class TextNumber : TextColor
    {
        public new string Text
        {
            get
            {
                if (base.Text.Length == 0)
                    return "0";
                return base.Text.Trim();
            }
            set
            {

                try
                {
                    base.Text = string.Format("{0:#,###0}", Convert.ToInt64(value.Replace(",", "")));
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }
        public int IntValue
        {
            get
            {
                return Convert.ToInt32(this.Text.Replace(",", ""));//10,000==>10000
            }
            set
            {
                this.Text = value.ToString();
            }
        }
        public double DoubleValue
        {
            get
            {
                return Convert.ToDouble(this.Text.Replace(",", ""));//10,000==>10000
            }
            set
            {
                this.Text = value.ToString();
            }
        }//10
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 45 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (base.Text.Length != 0)
            {
                int p = this.SelectionStart;
                int l = base.Text.Length;

                this.Text = base.Text;
                this.SelectionStart = this.Text.Length <= p ? Math.Abs(this.Text.Length) : Math.Abs(this.Text.Length + p - l);
            }
            base.OnKeyUp(e);
        }


    }
}
