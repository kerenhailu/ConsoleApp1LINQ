using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1LINQ
{
    internal class Book
    {
        public string name;
        public string writer;
        public int numOfPage;
        public Book(string name, string writer,int numOfPage)
        {
            this.name = name;
            this.writer = writer;
            this.numOfPage = numOfPage;
        }
    }
}
