﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}
