using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace UpcastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            //upcasting
            Shape shape = text; //no conversion is requred
            //does so implicitly
            //pointing to same object in memory (pointing to same reference)

            //two different views however
            text.width = 200;
            shape.width = 100;
            //the value will be 100
            //references same object
            Console.WriteLine(text.width);

            // StreamReader reader = new StreamReader();

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Dan");
            list.Add(new Text());

            //use generic list

            var anotherList = new List<Shape>();



            //downcasting

            Shape shape2 = new Text();
            //at runtime, shape2 will become a text object
            Text text2 = (Text)shape;
            //explicitely cast Text

        }
    }
}
