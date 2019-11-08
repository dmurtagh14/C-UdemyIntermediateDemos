using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            //boxing
            list.Add("dan");
            //no boxing
            list.Add(DateTime.Today);
            //boxing

            var number = (int)list[1]; //gets invalid cast exception
            //Add arguments takes in object 

            //lets create a generic list
            var anotherList = new List<int>();

            //creates type safety, no boxing will occur
            var names = new List<string>();

            //better to use generic implementation if it exists

        }
    }
}
