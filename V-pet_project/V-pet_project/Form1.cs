using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace V_pet_project
{
    public partial class Form1 : Form
    {
        CDrawer Canvas = null;
        Bitmap picture = null;
        Bitmap picture2 = null;
        Timer timer = new Timer();
        tog statusofmon = tog.alive;
        enum tog
        {
            alive, dead
        }

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(100, 100);
            Canvas = new CDrawer(320, 320, false, false); //canvas matched the bitmap size
            Canvas.Position = new Point(this.Location.X + this.Width, this.Location.Y);
            Canvas.Scale = 20;
            //function assign
            timer.Tick += timer_Tick;
            timer.Interval = 1000;
            _rendorBTN.MouseDown += btnrendor;
            _2frameBTN.MouseDown += btn2frame;
            _StopBTN.MouseDown += stopAnimation;

        }
        //load a single img
        private void btnrendor(object sender, MouseEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            //draw image
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picture = new Bitmap(dlg.FileName, true);
            }
            Load_img(picture);
            Canvas.Render();
            //timer.Start();
        }
        //2 frame animation
        private void btn2frame(object sender, MouseEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            //draw image
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picture = new Bitmap(dlg.FileName, true);
            }
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picture2 = new Bitmap(dlg.FileName, true);
            }
            timer.Start();
        }
        //stop all animations 
        private void stopAnimation(object sender, EventArgs e)
        {
            timer.Stop();
        }
        //rendering for image 2 frames only atm
        private void timer_Tick(object sender, EventArgs e)
        {
            if (statusofmon == tog.alive)
            {
                //render picture
                Load_img(picture);
                statusofmon = tog.dead;
            }
            else
            {
                Load_img(picture2);
                statusofmon = tog.alive;
            }
            Canvas.Render(); // draw every frame
        }
        //load individual img for rendoring on the canvas

        //temp change to rip pictures into seprate pictures
        private void Load_img(Bitmap pic)
        {
            picture2 = new Bitmap(16,16);
            for (int i = 0; i < 16; i++) //width part
            {
                for (int j = 0; j < 16; j++) //height
                {
                    Canvas.SetBBScaledPixel(i, j, pic.GetPixel(i, j));
                    picture2.SetPixel(i,j,Color.Black);//set pixel on mapp
                }
            }
            // save img
            SaveFileDialog sf = new SaveFileDialog();
            if(sf.ShowDialog() == DialogResult.OK)
            {
                picture2.Save("digimonrend.Bmp", ImageFormat.Gif);
            }

        }

    }
}
