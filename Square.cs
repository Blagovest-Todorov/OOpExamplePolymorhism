using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Polymorhism
{
    class Square : AbstractClassFigure
    {
        public double Size { get; set; }  //Declaring a property

        public override double CalcSurface()  //developing and replacing and modifing the Base Class method to work here for concrete Object
        {
            return this.Size * this.Size;
        }
    }
}
