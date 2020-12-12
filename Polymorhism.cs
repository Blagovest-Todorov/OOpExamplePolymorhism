using _05.Polymorhism;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.Polymorhism
{
    class Polymorhism 
    {
        static void Main()
        {
            // Polymorhism --ability to take more than one form 
            // Onject can have more than one type.
            // a class can be used through its parent interface
            // a Child class may override  some of the behavior of the parent class

            //{Polymorhism allows abstract operations to be defined and used !
            // Abstract operations are defined in the base class interface and implements in the child class;
            // virtural methods--when it is declared with keyword "virtual". in Base class,  In the child class the virtual method is overriden.
            //virtual methods in the child class can be overriden, when using the keyword overridde  in the child class !
            // we create a new version of this method with  override keywprd ! 
            // using override we modify a mthod or a property
            // We can override only virstual method, and we can not override -non-virtual methods and static methods !
            // static methds are on the class level and can not be overriden  !

            AbstractClassFigure[] figures = new AbstractClassFigure[]  //We call the Constructor  to create new objexsts of diff types Classes !
            {
                new Square() {Size = 3},
                new Circle() { Radius = 2 }, 
                new Rectangle() {Width = 2, Height = 3 }, 
                new Circle() {Radius = 3.5 }, 
                new Square() {Size = 2.5 }, 
                new Square() { Size = 3}
                            
            };
            foreach ( AbstractClassFigure figure in figures)
            {
                Console.WriteLine( "Figure = {0}, surface = {1:F2}",
                    figure.GetType().Name.PadRight(9, ' '), 
                    figure.CalcSurface());
            }


        }
        
    }
    


}
