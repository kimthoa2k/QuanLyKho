using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class CustomerButton : PictureBox
    {
        public CustomerButton()
        {
            InitializeComponent();
        }
        //Khai báo biến
        private Image Normal;
        private Image Hover;

        public Image ImageNormal
        {
            get { return Normal; }
            set { Normal = value;}
        }

        public Image ImageHover
        {
            get { return Hover; }
            set { Hover = value; }
        }

        private void CustomerButton_MouseHover(object sender, EventArgs e)
        {
            //khi hover vào thì thay đổi
            this.Image = Hover;
        }

        private void CustomerButton_MouseLeave(object sender, EventArgs e)
        {
            //khi không hover vào thì thay đổi
            this.Image = Normal;
        }
    }
}
