using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySlideShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int img = 3;

        private void LoadNextImage()
        {
            if (img == 6)
            {
                img = 1;
            }
            int a = img - 2;
            int b = img - 1;
            int c = img + 1;
            int d = img + 2;
            if (a == 0) a = 5;
            else if (a == -1) a = 4;
            if (b == 0) b = 5;
            if (c == 6) c = 1;
            if (d == 6) d = 1;
            else if (d == 7) d = 2;
            SlidePic.ImageLocation = string.Format(@"Image\{0}.PNG", img);
            picture1.ImageLocation = string.Format(@"Image\{0}.PNG", a);
            picture2.ImageLocation = string.Format(@"Image\{0}.PNG", b);
            picture3.ImageLocation = string.Format(@"Image\{0}.PNG", img);
            picture4.ImageLocation = string.Format(@"Image\{0}.PNG", c);
            picture5.ImageLocation = string.Format(@"Image\{0}.PNG", d);
            img++;
        }
            private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
