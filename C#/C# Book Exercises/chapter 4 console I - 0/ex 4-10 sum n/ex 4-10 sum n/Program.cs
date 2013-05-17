using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число!");
            int a = int.Parse(Console.ReadLine());                       
                           
            
            
            while (true)
            {                                              
               Console.WriteLine("Въведете следващо число!");
               int b = int.Parse(Console.ReadLine());
               int c = a + b;

               for (c = 0; c < 100; c+=b)
               {
                   Console.ReadLine();

                   Console.WriteLine("Сумата от въведените числа е: {0}", c);
               }
               
                                                
             }
                

            }          
        }
    }

