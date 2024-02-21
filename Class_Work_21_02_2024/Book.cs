using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_21_02_2024
{
    internal class Book
    {

        public string name;
        public string author;

        public Book()
        {
            Console.WriteLine("PB101");
        }        
        public Book(string name)
        {
            Console.WriteLine("Xacker bey");
        }
        public Book(string name, string author)
        {
            //Console.WriteLine(name);

            this.name = name;

            this.author = author;
        }
    }
     
}




