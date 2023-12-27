using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchlorrOClock
{
    public partial class form1 : Form
    {
        int Zonedif = 0;

        public form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(Brushes.CadetBlue, 0, 0, 449, 449);
            g.FillEllipse(Brushes.White, 5, 5, 439, 439);

            DateTime now = DateTime.Now;
            double m = (now.Minute * 6) * Math.PI / 180;
            double s = (now.Second * 6) * Math.PI / 180;
            double h = ((((now.Hour + Zonedif) % 12) * 30) + ((m / (Math.PI / 180)) / 12)) * Math.PI / 180;
            
            double da = now.Day;
            string day = Convert.ToString(da).PadLeft(2, '0');
            double mo = now.Month;
            string month = Convert.ToString(mo).PadLeft(2, '0');
            double ye = now.Year;
            string year = Convert.ToString(ye).Substring(2);

            g.DrawRectangle(Pens.DeepSkyBlue, 180, 250, 25, 15);
            g.DrawString(day, new Font("Serif", 11.0f), Brushes.CornflowerBlue, 183, 249);
            g.DrawRectangle(Pens.DeepSkyBlue, 210, 250, 25, 15);
            g.DrawString(month, new Font("Serif", 11.0f), Brushes.CornflowerBlue, 213, 249);
            g.DrawRectangle(Pens.DeepSkyBlue, 240, 250, 25, 15);
            g.DrawString(year, new Font("Serif", 11.0f), Brushes.CornflowerBlue, 243, 249);

            g.DrawLine(Pens.Red, 225, 225, (int)(225 + 140 * Math.Sin(s)), (int)(225 - 140 * Math.Cos(s)));
            g.DrawLine(Pens.Blue, 225, 225, (int)(225 + 140 * Math.Sin(m)), (int)(225 - 140 * Math.Cos(m)));
            g.DrawLine(Pens.Blue, 225, 225, (int)(225 + 100 * Math.Sin(h)), (int)(225 - 100 * Math.Cos(h)));

            g.FillEllipse(Brushes.Blue, 220, 220, 10, 10);

            int hour = 0;
            for(int i = 0; i < 61; i++)
            {
                double iangle = ((i * 6) * (Math.PI / 180));
                if(i%5 == 0)
                {
                    g.DrawLine(Pens.PaleVioletRed, (float)(225 + Math.Sin(iangle) * 100), (float)(225 - Math.Cos(iangle) * 100), (float)((225 + Math.Sin(iangle) * 100) + Math.Sin(iangle) * 15), (float)((225 - Math.Cos(iangle) * 100) - Math.Cos(iangle) * 15));
                    g.DrawLine(Pens.Red, (float)(225 + Math.Sin(iangle) * 200), (float)(225 - Math.Cos(iangle) * 200), (float)((225 + Math.Sin(iangle) * 200) + Math.Sin(iangle) * 20), (float)((225 - Math.Cos(iangle) * 200) - Math.Cos(iangle) * 20));
                    if(hour > 0)
                    {
                        g.DrawString(Convert.ToString(hour), new Font("Serif", 11.0f), Brushes.IndianRed, (float)(225 + Math.Sin(iangle) * 190 - 5), (float)(225 - Math.Cos(iangle) * 180 - 8));
                    }
                    hour++;
                }
                g.DrawLine(Pens.PaleVioletRed, (float)(225 + Math.Sin(iangle) * 100), (float)(225 - Math.Cos(iangle) * 100), (float)((225 + Math.Sin(iangle) * 100) + Math.Sin(iangle) * 10), (float)((225 - Math.Cos(iangle) * 100) - Math.Cos(iangle) * 10));
                g.DrawLine(Pens.Red, (float)(225 + Math.Sin(iangle) * 200), (float)(225 - Math.Cos(iangle) * 200), (float)((225 + Math.Sin(iangle) * 200) + Math.Sin(iangle) * 10), (float)((225 - Math.Cos(iangle) * 200) - Math.Cos(iangle) * 10));

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picBOX.Refresh();
        }

        private void eDTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Zonedif = -5;
            if (!DateTime.Now.IsDaylightSavingTime())
            {
                Zonedif++;
            }
            bSTToolStripMenuItem.Checked = false;
            gMTToolStripMenuItem.Checked = false;
            cSTToolStripMenuItem.Checked = false;
            cESTToolStripMenuItem.Checked = false;
            pDTToolStripMenuItem.Checked = false;
            eDTToolStripMenuItem1.Checked = true;
        }

        private void gMTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Zonedif = -1;
            if (!DateTime.Now.IsDaylightSavingTime())
            {
                Zonedif++;
            }
            bSTToolStripMenuItem.Checked = false;
            gMTToolStripMenuItem.Checked = true;
            cSTToolStripMenuItem.Checked = false;
            cESTToolStripMenuItem.Checked = false;
            pDTToolStripMenuItem.Checked = false;
            eDTToolStripMenuItem1.Checked = false;
        }

        private void bSTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Zonedif = 0;
            if (!DateTime.Now.IsDaylightSavingTime())
            {
                Zonedif++;
            }
            bSTToolStripMenuItem.Checked = true;
            gMTToolStripMenuItem.Checked = false;
            cSTToolStripMenuItem.Checked = false;
            cESTToolStripMenuItem.Checked = false;
            pDTToolStripMenuItem.Checked = false;
            eDTToolStripMenuItem1.Checked = false;
        }

        private void pDTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Zonedif = -8;
            if (!DateTime.Now.IsDaylightSavingTime())
            {
                Zonedif++;
            }
            bSTToolStripMenuItem.Checked = false;
            gMTToolStripMenuItem.Checked = false;
            cSTToolStripMenuItem.Checked = false;
            cESTToolStripMenuItem.Checked = false;
            pDTToolStripMenuItem.Checked = true;
            eDTToolStripMenuItem1.Checked = false;
        }

        private void cESTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Zonedif = 1;
            if (!DateTime.Now.IsDaylightSavingTime())
            {
                Zonedif++;
            }
            bSTToolStripMenuItem.Checked = false;
            gMTToolStripMenuItem.Checked = false;
            cSTToolStripMenuItem.Checked = false;
            cESTToolStripMenuItem.Checked = true;
            pDTToolStripMenuItem.Checked = false;
            eDTToolStripMenuItem1.Checked = false;
        }

        private void cSTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Zonedif = 7;
            if (!DateTime.Now.IsDaylightSavingTime())
            {
                Zonedif++;
            }
            bSTToolStripMenuItem.Checked = false;
            gMTToolStripMenuItem.Checked = false;
            cSTToolStripMenuItem.Checked = true;
            cESTToolStripMenuItem.Checked = false;
            pDTToolStripMenuItem.Checked = false;
            eDTToolStripMenuItem1.Checked = false;
        }

/*      This was going to be an implementation of Martian Coordinated Time and it does calculate MSD accurately but is slightly too innacurate to get the exact time.
        private void martianStandardTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double dt = (DateTime.Now.Year - 1970) * 31556952000;
            for (int i = 0; i < DateTime.Now.Month; i++)
            {
                dt += DateTime.DaysInMonth(DateTime.Now.Year, i) * 86400000;
            }
            dt += (DateTime.Now.Day-1) * 86400000;
            dt += DateTime.Now.Hour * 3600000;
            dt += DateTime.Now.Minute * 600000;
            dt += DateTime.Now.Second * 100000;

            dt = 2440587.5 + (dt / 86400000);
            dt += (69.184) / 86400;

            dt = dt - 2451545;

            dt = ((dt - 4.5) / 1.027491252) + 44796 - 0.00096;
        }*/
    }
}
