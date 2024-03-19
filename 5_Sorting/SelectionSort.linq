<Query Kind="Program" />

/*
 O(n^2)
 Selection sort is unstable if A=[3,5,8,9,5,2]
 the original order of duplicates will not be preserved
 Doesnt matter if this array is just numbers 
 but if however the array is a set of objects with values name and salary
 and is already sorted by salary then a second sort on name will NOT preserver the salary sort.
*/
void Main()
{
	
	int[] A = {3,5,8,9,5,2};
	
	
	int[] sorted = SelectionSort(A, A.Length);
	for(int i = 0; i < sorted.Length; i++)
	{
		Console.WriteLine(sorted[i]);
	}
}

// You can define other methods, fields, classes and namespaces here

public static int[] SelectionSort(int[] A, int Length)
{
	for(int i = 0; i < Length - 1; i++)
	{
		int position = i;
		/*
		 for each position check all positions after it
		 store index of biggest one
		 then swap
		*/
		for(int j = i + 1; j < Length; j++)
		{
			if(A[j] < A[position])
			{
				position = j;
			}
		}
		//swap positions
		int temp = A[i];
		A[i] = A[position];
		A[position] = temp;
	}
	return A;
}