using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Polymorhism
{
    class Circle : AbstractClassFigure
    {

        public double Radius { get; set; }

        public override double CalcSurface()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
