using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InheritanceStackChallenge
{
   public class Stack
    {
        private List<object> _objects = new List<object>();


        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("You cannot add a null object to the stack. ");
            }

            _objects.Add(obj);            
        }

        public object Pop()
        {
           if(_objects.Count == 0)
            {
                throw new InvalidOperationException("There are no elements in the stack yet.");
            }

            var index = _objects.Count - 1;

            object toReturn = _objects[index];
           
            _objects.RemoveAt(index);

            return (toReturn);
        }

        public void Clear()
        {
            _objects.Clear();
        }


    }
}
