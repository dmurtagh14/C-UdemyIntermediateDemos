using System;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // var number = int.Parse("abc"); //format exception

            int number;

            var result = int.TryParse("abc", out number);

            if (result)
            {
                Console.WriteLine(number);
            }
            else
                Console.WriteLine("Conversion failed");

        }

        static void useParams()
        {
            var calculator = new Calculator();
            //using params, we can pass any number into arguments
            //varieng number of parameters
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6));
        }

        static void usePoints()
        {
            var point = new Point(10, 20);

            //try catch prevents crashing
            try
            {
                point.move(null);

                Console.WriteLine("Point is at ({0}, {1}) ", point.x, point.y);

                point.move(200, 200);

                Console.WriteLine("Point is at ({0}, {1}) ", point.x, point.y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error has occured");
            }
        }
    }
}
