<Query Kind="Program" />

/*
	O(n^2)
	Insertion sort breaks the array into two halves sorted and unsorted
	1. Assume the 1st element is sorted (in the sorted half) and the rest are in the unsorted half 
	2. Select the 1st element from the unsorted half 
	3. if sorted element > seleted unsorted element -- SWAP
			-- after swap keep comparing all elements in sorted half to ensure sorted half remains sorted
	4. Select the next 1st element from the sorted half and repeat #3
	
	In other words
	The Insertion Sort algorithm uses one part of the array to hold the sorted values, and the other part of the array to hold values that are not sorted yet.
	The algorithm takes one value at a time from the unsorted part of the array and puts it into the right place in the sorted part of the array, until the array is sorted.
	
	How it works:
		
		Assume the 1st element is sorted 
		Take the first value from the unsorted part of the array.
		Move the value into the correct place in the sorted part of the array.
		Go through the unsorted part of the array again as many times as there are values.
*/
void Main()
{
	//         0 1 2 3 4 5
	int[] A = {3,5,8,9,5,2};
	
	
	int[] sorted = InsertionSort(A, A.Length);
	for(int i = 0; i < sorted.Length; i++)
	{
		Console.WriteLine(sorted[i]);
	}
}

// You can define other methods, fields, classes and namespaces here

public static int[] InsertionSort(int[] A, int Length)
{
	for(int i = 1; i < Length; i++)
	{
		int Position = i;
		//Temp is 1st value in unsorted half
		int Temp = A[Position];
		//traverses backward to compare each value in the already sorted sub array
		//if last value in sorted half > 1st value in unsorted half  swap
		while(Position > 0 && A[Position - 1] > Temp)
		{
			//swap
			A[Position] = A[Position - 1];
			
			Position = Position - 1;
		}
		A[Position] = Temp;
	}
	return A;
}