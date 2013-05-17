using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_10_4
{
    class Program
    {
        static int targetSum;

        static void Main()
        {
            Console.WriteLine("If your array of number is:");
            Console.WriteLine("2, 3, 1, -1");
            Console.WriteLine("All combinations are:");

            int[] numbers = new[]
            {
                2, 3, 1, -1
            };

            Permute(numbers, Output);
            Console.WriteLine();

            Console.WriteLine("Enter target sum:");
            targetSum = int.Parse(Console.ReadLine());
            // missing logic to compare combinations with target sum
            
        }

        private static void Output<T>(T[] permutation)
        {
            foreach (T item in permutation)
            {
                Console.Write(item);
                Console.Write(" ");                               
            }

            Console.WriteLine();
        }

        public static void Permute<T>(T[] items, Action<T[]> output)
        {
            Permute(items, 0, new T[items.Length], new bool[items.Length], output);
        }

        private static void Permute<T>(T[] items, int item, T[] permutation, bool[] used, Action<T[]> output)
        {
            for (int i = 0; i < items.Length; ++i)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutation[item] = items[i];

                    if (item < (items.Length - 1))
                    {
                        Permute(items, item + 1, permutation, used, output);
                    }
                    else
                    {
                        output(permutation);
                    }

                    used[i] = false;
                }
            }
        }


    }
}
