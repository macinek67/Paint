using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace rysowanieFigur
{
    class Linia : Figura
    {
        public Linia(int x1, int y1, int x2, int y2, Graphics gr, Color c, int grubosc, Graphics gr1, Color shadow) : base(x1, y1, x2, y2, gr, c, grubosc, gr1, shadow)
        {

        } 
        public override void Rysuj()
        {
            Pen pen = new Pen(base.c, base.grubosc);
            base.g.DrawLine(pen, x1, y1, x2, y2);
            pen = new Pen(base.shadowColor, base.grubosc);
            base.g1.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
