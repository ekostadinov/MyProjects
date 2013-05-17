using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortQuick
{
    class quickSort
    {
        // this is our array to sort
        private int[] arr = new int[20];

        // this holds a number of elements in array
        private int len;

        // Quick Sort Algorithm
        public void QuickSort()
        {
            sort(0, len - 1);
        }

        public void sort(int left, int right)
        {
            int pivot, l_holder, r_holder;

            l_holder = left;
            r_holder = right;
            pivot = arr[left];

            while (left < right)
            {
                while ((arr[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    arr[left] = arr[right];
                    left++;
                }

                while ((arr[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    arr[right] = arr[left];
                    right--;
                }
            }

            arr[left] = pivot;
            pivot = left;
            left = l_holder;
            right = r_holder;

            if (left < pivot)
            {
                sort(left, pivot - 1);
            }

            if (right > pivot)
            {
                sort(pivot + 1, right);
            }
        }

        public static void Main()
        {
            quickSort q_Sort = new quickSort();

            int[] arr = { 4, 3, 1, 4, 6, 7, 5, 4, 3, 5, 6, 87, 8 };
            q_Sort.arr = arr;
            q_Sort.len = q_Sort.arr.Length;

            // Sort the array
            q_Sort.QuickSort();

            for (int j = 0; j < q_Sort.len; j++)
            {
                Console.WriteLine(q_Sort.arr[j]);
            }
            Console.ReadKey();
        }
    }
}
