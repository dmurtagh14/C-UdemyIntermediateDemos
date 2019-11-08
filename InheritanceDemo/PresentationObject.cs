using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    //parent class
    class PresentationObject
    {
        public int width { get; set; }
        public int height { get; set; }

        public void copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }

        public void duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}
