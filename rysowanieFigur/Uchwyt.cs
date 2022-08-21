using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace rysowanieFigur
{
    class Uchwyt
    {
        enum stany
        {
            nieokreslony,
            pierwszyKlik
        }
        stany stan = stany.nieokreslony;
        String ktoryUchwyt;
        private void uchwytClick(object sender, EventArgs e)
        {
            if (stan == stany.nieokreslony)
            {
                parent.MouseMove += uchwytMove;
                stan = stany.pierwszyKlik;
                ktoryUchwyt = UchwytName(sender);
                //child.Visible = true;
            }
            else { stan = stany.nieokreslony; parent.MouseMove -= uchwytMove; child.Visible = false; }
        }

        private String UchwytName(object sender)
        {
            return ((Button)sender).Name;
        }

        private void uchwytMove(object sender, MouseEventArgs e)
        {
            if(ktoryUchwyt.Equals("UchwytLT"))
            {
                p1.X = e.X;
                p1.Y = e.Y;
            }
            else if (ktoryUchwyt.Equals("UchwytLB"))
            {
                p1.X = e.X;
                p2.Y = e.Y;
            }
            else if (ktoryUchwyt.Equals("UchwytRT"))
            {
                p2.X = e.X;
                p1.Y = e.Y;
            }
            else if (ktoryUchwyt.Equals("UchwytRB"))
            {
                p2.X = e.X;
                p2.Y = e.Y;
            }
            dodajGuzikiRamki(p1, p2, parent, g);
            rysujRamke(g);
        }

        private void rysujRamke(Graphics g)
        {
            g.Clear(Color.White);
            int i = p1.X;
            int i1 = p1.Y;
            Pen pen = new Pen(Color.Black, 0.5f);
            while (true)
            {
                if (p1.X < p2.X && i < p2.X)
                {
                    g.DrawLine(pen, new Point(i, p1.Y), new Point(i + 3, p1.Y)); i += 3;
                    g.DrawLine(pen, new Point(i, p2.Y), new Point(i + 3, p2.Y)); i += 3;
                }
                else if (p1.X > p2.X && i > p2.X)
                {
                    g.DrawLine(pen, new Point(i, p1.Y), new Point(i - 3, p1.Y)); i -= 3;
                    g.DrawLine(pen, new Point(i, p2.Y), new Point(i - 3, p2.Y)); i -= 3;
                }
                else break;
            }
            while (true)
            {
                if (p1.Y < p2.Y && i1 < p2.Y)
                {
                    g.DrawLine(pen, new Point(p1.X, i1), new Point(p1.X, i1 - 3)); i1 += 3;
                    g.DrawLine(pen, new Point(p2.X, i1), new Point(p2.X, i1 - 3)); i1 += 3;
                }
                else if (p1.Y > p2.Y && i1 > p2.Y)
                {
                    g.DrawLine(pen, new Point(p1.X, i1), new Point(p1.X, i1 + 3)); i1 -= 3;
                    g.DrawLine(pen, new Point(p2.X, i1), new Point(p2.X, i1 + 3)); i1 -= 3;
                }
                else break;
            }
        }

        private void dodajGuzikiRamki(Point p1, Point p2, Control parent, Graphics g)
        {
            parent.Controls.Clear();
            Button LT = new Button();
            LT.Width = 10;
            LT.Height = 10;
            LT.Name = "UchwytLT";
            LT.Left = p1.X - LT.Width / 2;
            LT.Top = p1.Y - LT.Width / 2;
            LT.Click += uchwytClick;
            Button RT = new Button();
            RT.Width = 10;
            RT.Height = 10;
            RT.Name = "UchwytRT";
            RT.Left = p2.X - RT.Width / 2;
            RT.Top = p1.Y - RT.Width / 2;
            RT.Click += uchwytClick;
            Button LB = new Button();
            LB.Width = 10;
            LB.Height = 10;
            LB.Name = "UchwytLB";
            LB.Left = p1.X - LB.Width / 2;
            LB.Top = p2.Y - LB.Width / 2;
            LB.Click += uchwytClick;
            Button RB = new Button();
            RB.Width = 10;
            RB.Height = 10;
            RB.Name = "UchwytRB";
            RB.Left = p2.X - RB.Width / 2;
            RB.Top = p2.Y - RB.Width / 2;
            RB.Click += uchwytClick;
            parent.Controls.Add(LT);
            parent.Controls.Add(RT);
            parent.Controls.Add(LB);
            parent.Controls.Add(RB);
        }

        Point p1, p2;
        Control parent, child;
        Graphics g;
        public Uchwyt(Point p1, Point p2, Control parent, Graphics g, Control child)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.parent = parent;
            this.g = g;
            this.child = child;
            dodajGuzikiRamki(p1, p2, parent, g);
            rysujRamke(g);
        }
    }
}
