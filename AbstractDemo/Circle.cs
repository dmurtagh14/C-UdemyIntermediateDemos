using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}
