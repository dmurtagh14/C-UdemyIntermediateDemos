using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifierDemo
{
    class Person
    {
        private DateTime birthDay;

        public void SetBirthdate(DateTime birthDate)
        {
            birthDay = birthDate;
        }

        public DateTime GetBirthdate()
        {
            return birthDay;
        }
    }
}
