using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_21_02_2024
{
    internal class Student
    {
        public string name;
        public string surname;
        public int age;
        public string adress;
        public string phone;


        public string GetFullName()
        {
            return name + " " + surname;
        }
        public string GetFullDatas()
        {
            string fullData = $"Name: {name}, Surname: {surname}, Age: {age}, Adress: {adress}, Phone: {phone}";
            
            return fullData ;
        }
        
        
    }
}
