using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Canvas = new CDrawer(360, 360, false, false); //canvas matched the bitmap size
            Canvas.Position = new Point(this.Location.X + this.Width, this.Location.Y);
            Canvas.Scale = 10;
            //function assign
            timer.Tick += timer_Tick;
            _rendorBTN.MouseDown += btnrendor;
            timer.Interval = 1000;

        }
        //load an image
        private void btnrendor(object sender, MouseEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            //draw image
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picture = new Bitmap(dlg.FileName, true);
            }
            for (int i = 0; i < picture.Width; i++) //width part
            {
                for (int j = 0; j < picture.Height; j++) //height
                {
                    Canvas.SetBBScaledPixel(i, j, picture.GetPixel(i, j));
                }
            }
            Canvas.Render();
            //timer.Start();
        }



        //rendering for image
        private void timer_Tick(object sender, EventArgs e)
        {
            if (statusofmon == tog.alive)
            {
                //render picture
                for (int i = 0; i < picture.Width; i++) //width part
                {
                    for (int j = 0; j < picture.Height; j++) //height
                    {
                        Canvas.SetBBScaledPixel(i, j, picture.GetPixel(i, j));
                    }
                }
                statusofmon = tog.dead;
            }
            else
            {
                for (int i = 0; i < picture2.Width; i++) //width part
                {
                    for (int j = 0; j < picture2.Height; j++) //height
                    {
                        Canvas.SetBBScaledPixel(i, j, picture2.GetPixel(i, j));
                    }
                }
                statusofmon = tog.alive;
            }
            Canvas.Render(); // draw every frame
        }

    }
}
