﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace rysowanieFigur
{
    class Kolo : Figura
    {
        public Kolo(int x1, int y1, int x2, int y2, Graphics gr, Color c) : base(x1, y1, x2, y2, gr, c)
        {

        }
        public override void Rysuj()
        {
            Pen pen = new Pen(base.c, 2);
            base.g.DrawEllipse(pen, x1, y1, x2, y2);
        }
    }
}