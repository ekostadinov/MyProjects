using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [] { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4};
            int index;

            for (index = 0; index < arr.Length; index++)
            {
                Console.Write(arr[index] + " ");
            }


            int [] len = new int [] {0, arr.Length};
            int x = 0; 
            int prev = 0;  
            int n = 0;                   
            

            for (int i = arr[index]; i < arr[i] && prev < x && len [prev] < x && arr[prev] < arr[x]; i++)
            {
                int max  = (1 + len[prev]);
                len[0] = 1;
                len [x] = max;

                for (x = 0; x < arr.Length - 1; x++)
                {
                    for (n = 0; n < x - 1 && arr[prev] < arr[x]; n++)
                    {
                        prev = len [prev];
                        len [prev] = arr[prev];
                        if (len[x] != 0)
                        {
                            len[x] = 1 + len[prev];
                        }
                        else
                        {
                            len[x] = 1;
                        }
                    }
                    Console.WriteLine(len[i]);
                }
                
                                
                               
            }







        }
    }
}
