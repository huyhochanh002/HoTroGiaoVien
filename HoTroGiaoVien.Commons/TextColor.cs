using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroGiaoVien.Commons
{
    public class TextColor : TextBox
    {
        public TextColor()
        {
            this.TextAlign = HorizontalAlignment.Left;
            this.Font = new Font("Tahoma", 18F);
        }
        Color backColorFocus = Color.FromArgb(105, 185, 255);
        public Color BackColorFocus
        {
            get
            {
                return backColorFocus;
            }
            set
            {
                backColorFocus = value;
            }
        }
        protected override void OnEnter(EventArgs e)
        {
            this.BackColor = BackColorFocus;
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = Color.White;
            base.OnLeave(e);
        }
    }
}
