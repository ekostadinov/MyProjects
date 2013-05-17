using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_6a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            List<int> maxList = new List<int>();
            for (int mask = 1; mask < (1 << array.Length); mask++)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (((mask >> i) & 1) == 1)
                    {
                        if (list.Count == 0 || list[list.Count - 1] < array[i])
                            list.Add(array[i]);
                    }
                    if (list.Count > maxList.Count)
                    {
                        maxList = list;
                    }

                }
            }
            foreach (int element in maxList)
            {
                Console.Write(element + " ");
            }
        }
    }
}
