﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
                {
                    new Customer
                        {FirstName = "Sinan"},
                    new Student
                        {FirstName = "BayS"},
                    new Person
                        {FirstName = "Storage" }
                    };

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string City { get; set; }
    }


}
