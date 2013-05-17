using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_12_8_ReadNumber
{

    class NumberReading
    {
        static byte[] Array;
        static byte index;
        static int userInput;
        static byte arrSize;
        static int startNumber;
        static int endNumber;

        static void Main(string[] args)
        {
            Console.Write("Enter start number: ");
            startNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter end number: ");
            endNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter positive number between {0} and {1}: ", startNumber, endNumber);

            if (startNumber < endNumber)
            {
                ReadNumber();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Incorrect input! Start number must be greater then end number!");
            }

        }

        static void ReadNumber()
        {
            try
            {
                userInput = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException nonNumber)
            {
                Console.WriteLine("Message = {0}", nonNumber.Message);
                Console.WriteLine("Source = {0}", nonNumber.Source);
                Console.WriteLine("StackTrace = {0}", nonNumber.StackTrace);
                Console.WriteLine("TargetSite = {0}", nonNumber.TargetSite);
            }

            if (userInput < startNumber || userInput > endNumber)
            {
                throw new Exception("You've entered an invalid number!");
            }

            GetArray();
        }


        static void GetArray()
        {
            Console.WriteLine("We need to create an array of 10 numbers!");
            arrSize = 10;
            Console.WriteLine("Now enter 10 numbers between 1 and 100: ");

            Array = new byte[arrSize];

            for (index = 0; index <= Array.Length - 1; index++)
            {
                Console.Write("Enter value for [{0}]: ", index);

                ReadArrayNumbers();
            }

            PrintArray();
            Console.WriteLine();
        }

        static void ReadArrayNumbers()
        {
            try
            {
                Array[index] = byte.Parse(Console.ReadLine());
            }
            catch (System.FormatException nonNumber)
            {
                Console.WriteLine("Message = {0}", nonNumber.Message);
                Console.WriteLine("Source = {0}", nonNumber.Source);
                Console.WriteLine("StackTrace = {0}", nonNumber.StackTrace);
                Console.WriteLine("TargetSite = {0}", nonNumber.TargetSite);
            }

            if (Array[index] < 1 || Array[index] > 100)
            {
                throw new Exception("You've entered an invalid number!");
            }
        }

        static void PrintArray()
        {
            Console.WriteLine("Your array of numbers is: ");

            for (int index2 = 0; index2 < Array.Length - 1; index2++)
            {
                Console.Write(Array[index2] + " ");
            }
        }


    }
}
