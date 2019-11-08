using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverRidingDemo
{
   public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
       // public Position Position { get; set; }


        public virtual void Draw() //make it virtual so we can override the value
        {

        }


    }
}
