using System;
using System.Collections.Generic;
using System.Text;

namespace MethodDemo
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }



        public void move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //overload move method

        //takes in a new Point parameter
        //to make this better, call other move method in this method
        //but we need a way to handle null values
        public void move(Point newLocation)
        {
            if(newLocation == null)
            {
                throw new ArgumentNullException("newLocation"); //report errors to caller
                //defensive programming
            }

            move(newLocation.x, newLocation.y);
            //this.x = newLocation.x;
            //this.y = newLocation.y;
        }

        
    }
}
