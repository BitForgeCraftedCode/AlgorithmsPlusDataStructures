using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 O(n^2)
 Selection sort is unstable if A=[3,5,8,9,5,2]
 the original order of duplicates will not be preserved
 Doesnt matter if this array is just numbers 
 but if however the array is a set of objects with values name and salary
 and is already sorted by salary then a second sort on name will NOT preserver the salary sort.
*/
namespace LearnDSAlgorithms
{
    class Sort
    {
        public void selectionsort(int[] A, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int position = i;
                for (int j = i + 1; j < n; j++)
                    if (A[j] < A[position])
                        position = j;
                int temp = A[i];
                A[i] = A[position];
                A[position] = temp;
            }
        }

        public void display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Sort s = new Sort();
            int[] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            s.display(A, 6);
            s.selectionsort(A, 6);
            Console.WriteLine("Sorted Array");
            s.display(A, 6);
            Console.ReadKey();
        }
    }
}
