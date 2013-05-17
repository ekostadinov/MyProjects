using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // array of integers to hold values
                private int[] arrA = new int[] {3, 4};
                private int[] arrB = new int[] {55, 79, 141, 189};

            // number of elements in array
                private int x;
        
         }
            // Merge Sort Algorithm
        public void sortArray()
               {
                     m_sort( 0, x-1 );
               }

       public void m_sort( int left, int right )
                {
                    int mid;
                    if( right > left )
                        {
                            mid = ( right + left ) / 2;
                            m_sort( left, mid );
                            m_sort( mid+1, right );
                            merge( left, mid+1, right );
                        }
                }

        public void merge( int left, int mid, int right )
            {
                    int i, left_end, num_elements, tmp_pos;
                    left_end = mid - 1;
                    tmp_pos = left;
                    num_elements = right - left + 1;

            while( (left <= left_end) && (mid <= right) )
                {
                    if( arrA[left] <= arrA[mid] )
                        {
                             arrB[tmp_pos] = arrA[left];
                             tmp_pos = tmp_pos + 1;
                             left = left +1;
                         }
                     else
                         {
                              arrB[tmp_pos] = arrA[mid];
                              tmp_pos = tmp_pos + 1;
                              mid = mid + 1;
                         }
                }

            while( left <= left_end )
                {
                     arrB[tmp_pos] = arrA[left];
                     left = left + 1;
                      tmp_pos = tmp_pos + 1;
                }

            while( mid <= right )
                {
                     arrB[tmp_pos] = arrA[mid];
                     mid = mid + 1;
                     tmp_pos = tmp_pos + 1;
                }

            for( i = 0; i < num_elements; i++ )
                {
                         arrA[right] = arrB[right];
                         right = right - 1;
                }
            }



         }
     }
 }
