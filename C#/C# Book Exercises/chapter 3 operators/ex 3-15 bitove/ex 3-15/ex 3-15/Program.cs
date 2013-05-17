using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете цяло положително 32-битово число :");
            string line = Console.ReadLine();
            int n;
            int.TryParse(line, out n);
                        
            int a;// represents 24th to 26th bit 
            int b;// represents 1st to 3rd bit 
            a = (n / (1 << 24)) % (1 << 3); 
            b = (n / (1 << 1)) % (1 << 3); 
            for (int i = 1; i <= 3; i++) 
            { 
                n = n & (~(1 << i)); 
                n = n & (~(1 << (i + 23))); 
            } 
            n += a << 1; 
            n += b << 24; 
            Console.WriteLine(n); 
        } 
            
        }
    }

