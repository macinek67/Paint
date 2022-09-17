using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace rysowanieFigur
{
    abstract class Figura
    {
        public int x1, y1, x2, y2;
        public Graphics g;
        public Color c;
        public int grubosc;
        public Figura(int x1, int y1, int x2, int y2, Graphics gr, Color c, int grubosc)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            g = gr;
            this.c = c;
            this.grubosc = grubosc;
        }
        abstract public void Rysuj();
     
    }
}
