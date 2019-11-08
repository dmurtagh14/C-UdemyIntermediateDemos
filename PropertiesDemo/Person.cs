using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesDemo
{
    class Person
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDate { get; private set; } //automatically implements getters and setters
        //private set makes set value READONLY

        public Person(DateTime birthdate)
        {
            BirthDate = birthdate;
        }
    

        public int age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
