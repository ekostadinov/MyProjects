using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете име на фирмата: ");
            string company = Console.ReadLine();

            Console.WriteLine("Въведете адрес на фирмата: ");
            string adres = Console.ReadLine();

            Console.WriteLine("Въведете телефонен номер на фирмата: ");
            string tel = Console.ReadLine();
            

            Console.WriteLine("Въведете 'fax' номер на фирмата: ");
            string fax = Console.ReadLine();

            Console.WriteLine("Въведете 'web'-страница номер на фирмата: ");
            string web = Console.ReadLine();

            Console.WriteLine("Въведете име на управителя на фирмата: ");
            string name = Console.ReadLine();

            Console.WriteLine("Въведете фамилия на управителя на фирмата: ");
            string family = Console.ReadLine();

            Console.WriteLine("Въведете телефонен номер на управителя на фирмата: ");
            string number = Console.ReadLine();

            Console.WriteLine(company);
            Console.WriteLine(adres);
            Console.WriteLine("Телефон за контакт:" + tel);
            Console.WriteLine("факс:" + fax);
            Console.WriteLine("Интернет адрес:" + web);
            Console.WriteLine("Управител:"+ name + " " + family + " " + "тел.:" + number);
        
        
        }
    }
}
