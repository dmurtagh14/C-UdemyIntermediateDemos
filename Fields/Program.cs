using System;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var cutomer = new Customer(1);

            cutomer.orders.Add(new Order());
            cutomer.orders.Add(new Order());
            cutomer.orders.Add(new Order());

            cutomer.Promote();

            Console.WriteLine(cutomer.orders.Count);
        }
    }
}
