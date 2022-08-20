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
            kontur
        }

        Graphics g, g1;
        Bitmap bitmap = new Bitmap(805, 384);
        Bitmap bitmap1 = new Bitmap(805, 384);
        Punkt punktStart = new Punkt(0,0);
        stany stan = stany.nieokreslony;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = (Image)bitmap;
            g = pictureBox1.CreateGraphics();
            pictureBox1.Controls.Add(pictureBox2);
            g1 = pictureBox2.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void buttonLinia_Click(object sender, EventArgs e)
        {
            stan = stany.liniaStart;
            f = "linia";
        }

        private void uchwytClick(object sender, EventArgs e)
        {

        }

        string f;
        Figura[] figury = new Figura[99999];
        int nrFigury = 0;
        int gruboscPedzla = 2;

        private void DodajFigure(MouseEventArgs me, Pen pen)
        {
            if (f == "linia")
            {
                g.DrawLine(pen, punktStart.x, punktStart.y, me.Location.X, me.Location.Y);
                figury[nrFigury] = new Linia(punktStart.x, punktStart.y, me.Location.X, me.Location.Y, g, kolor.BackColor, gruboscPedzla);
            }
            else if (f == "prostokat")
            {
                g.DrawRectangle(pen, punktStart.x, punktStart.y, me.Location.X - punktStart.x, me.Location.Y - punktStart.y);
                figury[nrFigury] = new Prostokat(punktStart.x, punktStart.y, me.Location.X, me.Location.Y, g, kolor.BackColor, gruboscPedzla);
            }
            else if (f == "kolo")
            {
                g.DrawEllipse(pen, punktStart.x, punktStart.y, me.Location.X - punktStart.x, me.Location.Y - punktStart.y);
                figury[nrFigury] = new Kolo(punktStart.x, punktStart.y, me.Location.X, me.Location.Y, g, kolor.BackColor, gruboscPedzla);
            }
            nrFigury++;
        }

        Color GetPixel(Point p)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(p, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Controls.Clear();
            MouseEventArgs me = (MouseEventArgs)e;
            if (stan == stany.kontur)
            {
                Color color = GetPixel(new Point(Cursor.Position.X, Cursor.Position.Y));
                Uchwyt u = new Uchwyt(new Point(figury[0].x1, figury[0].y1), new Point(figury[0].x2, figury[0].y2), pictureBox1, g);
            }
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
                DodajFigure(me, pen);
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
                DodajFigure(me, pen);
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
                kolor.BackColor = colorDialog1.Color;
        }

        private void grubosc_Click(object sender, EventArgs e)
        {
            gruboscPedzla = Convert.ToInt32(Math.Round(grubosc.Value, 0));
        }

        private void buttonKontur_Click(object sender, EventArgs e)
        {
            stan = stany.kontur;
        }
    }
}
