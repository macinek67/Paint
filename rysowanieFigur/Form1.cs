using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rysowanieFigur
{

    public partial class Form1 : Form
    {
        enum stany
        {
            nieokreslony,
            liniaStart,
            pierwszyPunktLini,
            
        }

        Graphics g;
        Bitmap bitmap = new Bitmap(200, 200);
        Punkt punktStart = new Punkt(0,0);
        stany stan = stany.nieokreslony;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = (Image)bitmap;
            g = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void buttonLinia_Click(object sender, EventArgs e)
        {
            stan = stany.liniaStart;
            f = "linia";
        }

        string f;
        Figura[] figury = new Figura[99999];
        int nrFigury = 0;
        int gruboscPedzla = 2;

        private void DodajFigure(MouseEventArgs me, int numerF, Pen pen)
        {
            if (f == "linia")
            {
                g.DrawLine(pen, punktStart.x, punktStart.y, me.Location.X, me.Location.Y);
                figury[nrFigury] = new Linia(punktStart.x, punktStart.y, me.Location.X, me.Location.Y, g, kolor.BackColor, gruboscPedzla);
            }
            else if (f == "prostokat")
            {
                g.DrawRectangle(pen, punktStart.x, punktStart.y, me.Location.X, me.Location.Y);
                figury[nrFigury] = new Prostokat(punktStart.x, punktStart.y, me.Location.X, me.Location.Y, g, kolor.BackColor, gruboscPedzla);
            }
            else if (f == "kolo")
            {
                g.DrawEllipse(pen, punktStart.x, punktStart.y, me.Location.X, me.Location.Y);
                figury[nrFigury] = new Kolo(punktStart.x, punktStart.y, me.Location.X, me.Location.Y, g, kolor.BackColor, gruboscPedzla);
            }
            nrFigury++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (stan==stany.liniaStart)
            {
                punktStart.x = me.Location.X;
                punktStart.y = me.Location.Y;
                stan = stany.pierwszyPunktLini;
                return;
            }
            if (stan == stany.pierwszyPunktLini)
            {
                Pen pen = new Pen(kolor.BackColor, gruboscPedzla);
                stan = stany.liniaStart;
                DodajFigure(me, nrFigury, pen);
                return;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (stan == stany.pierwszyPunktLini)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                g.Clear(Color.White);
                for(int i=0; i<nrFigury; i++)
                    figury[i].Rysuj();
                Pen pen = new Pen(kolor.BackColor, gruboscPedzla);
                if(nrFigury!=0)
                    nrFigury--;
                DodajFigure(me, nrFigury, pen);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stan = stany.liniaStart;
            f = "prostokat";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stan = stany.liniaStart;
            f = "kolo";
        }

        private void kolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                kolor.BackColor = colorDialog1.Color;
            }
        }

        private void grubosc_Click(object sender, EventArgs e)
        {
            gruboscPedzla = Convert.ToInt32(Math.Round(grubosc.Value, 0));
        }
    }
}
