using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Polymorhism
{
    class Rectangle : AbstractClassFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalcSurface()
        {
            return this.Width * this.Height;
        }
    }
}
