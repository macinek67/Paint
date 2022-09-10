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
        public Graphics g, g1;
        public Color c;
        public Color shadowColor;
        public int grubosc;
        public Figura(int x1, int y1, int x2, int y2, Graphics gr, Color c, int grubosc, Graphics gr1, Color shadow)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            g = gr;
            this.c = c;
            this.grubosc = grubosc;
            g1 = gr1;
            shadowColor = shadow;
        }
        abstract public void Rysuj();
     
    }
}
