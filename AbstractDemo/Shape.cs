using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
   public abstract class Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public abstract void Draw(); //abstract method HAS to be in abstract class, NO implementation

        public void Copy()
        {
            Console.WriteLine("Shape copied to clipboard");
        }


    }
}
