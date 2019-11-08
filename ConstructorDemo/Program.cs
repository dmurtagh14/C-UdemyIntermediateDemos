using System;
using System.Collections.Generic;

namespace ConstructorDemo
{
    public class Order
    {

    }

    public class Customer { 
    
        public int Id;
        public string name;

        public List<Order> Orders; //generic list

    public Customer(int id, string name)
            :this() //calls default constructor first
    {
        Id = id;
        this.name = name;
    }

    public Customer()
    {
            Orders = new List<Order>();
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(0, "Daniel");

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.name);

            var customer2 = new Customer();

            customer2.name = "John";
        }
    }
}
