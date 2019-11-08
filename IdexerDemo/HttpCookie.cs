using System;
using System.Collections.Generic;
using System.Text;

namespace IdexerDemo
{
    class HttpCookie
    {
        //using dictionary dataType
        //uses hashTable
        private readonly Dictionary<string, string> dictionary;



        public HttpCookie()
        {
            dictionary = new Dictionary<string, string>();
        }

        //create indexor
        //indexor does NOT have a name
        //use this keyword instead
        public string this[string key] 
        {
            get
            {
                return dictionary[key];
            }
            set
            {
                dictionary[key] = value; //value is keyword thats used to represent value on RIGHT side
            }
        }
    }
}
