using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1LINQ
{
    internal class Person
    {
       public string name;
        public string lname;
        public int year;
        public string city;
        public Person(string name, string lname,int year,string city)
        {
            this.name = name;
            this.lname = lname;
            this.year = year;
            this.city = city;
        }
    }
}
