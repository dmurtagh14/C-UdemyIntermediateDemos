using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            var rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();

           // var shape = new Shape(); //cannot create instance of abstract classes

            //Stream
            //Stream is an ABSTRACT class
        }
    }
}
