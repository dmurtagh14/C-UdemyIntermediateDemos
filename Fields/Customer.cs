using System;
using System.Collections.Generic;
using System.Text;

namespace Fields
{
    class Customer
    {
        public int Id;
        public string name;

        public readonly List<Order> orders = new List<Order>(); //initilize orders list as empty in class vs constructor
        //BE CONSISTENT WITH APPROACH
        //readonly --> inititilzes field ONLY ONCE



        public Customer(int id)
        {
            this.Id = id;
        }

        //calls first constructor
        public Customer(int id, string name)
            : this(id)
        {
            this.name = name;
        }

        //read-only variable
        public void Promote()
        {
            
        }

    }
}
