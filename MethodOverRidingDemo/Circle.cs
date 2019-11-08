using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverRidingDemo
{
    class Circle : Shape
    {

        public override void Draw()
        {

            Console.WriteLine("draw a Circle");

           // base.Draw(); //references the parent class
        }
    }
}
