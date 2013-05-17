using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {-1, 5, 6, 18, 19, 25, 46, 78, 102, 114};
            Console.WriteLine("The array numbres are: ");

            for (int indexArr = 0; indexArr < arr.Length - 1; indexArr++)
            {
                Console.Write(arr[indexArr] + " ");
                
            }
                Console.WriteLine();

           
                Console.WriteLine("Please enter an array number!");
                int number = int.Parse(Console.ReadLine());

                int index = Array.BinarySearch(arr, number);
                Console.WriteLine("You number index array position is: " + index);                  
            
            

        }
    }
}
