using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2._12_company
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Евгени";
            string lastName = "Костадинов";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Имена на служителя:" + fullName);
            short age = 27;
            Console.WriteLine("Възраст:" + age + " години");
            char sex = 'M';
            Console.WriteLine("Пол:" + sex);
            decimal value1  = 27560000;
            decimal value2 = 27569999;
            Console.WriteLine("Номера на служителя:" +" oт " + value1 + " до " + value2);
        }
    }
}
