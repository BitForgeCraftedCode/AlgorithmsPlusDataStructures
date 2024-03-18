<Query Kind="Program" />

void Main(string[] args)
{
	 // array must be in order for binary search
	 int[] A = { 15, 21, 47, 84, 96 };
	 Console.WriteLine("is 100 in A " + BinarySearchRecursive(A, 100, 0, A.Length - 1));
	 Console.WriteLine("is 47 in A " + BinarySearchRecursive(A, 47, 0, A.Length - 1));
	 Console.WriteLine("is 84 in A " + BinarySearchRecursive(A, 84, 0, A.Length - 1));
	 Console.WriteLine("is 13 in A " + BinarySearchRecursive(A, 13, 0, A.Length - 1));
	
	
}

// You can define other methods, fields, classes and namespaces here
/*
 Idea is to:
 1. sort the array 1st -- here we assume it is
 2. check middle element 
 	if matches return index
	if key < middle search lower half
	if key > middle seachr uppper half
	
 repeat until done. 
 int[] A = { 15, 21, 47, 84, 96 };
*/
static int BinarySearchRecursive(int[] A, int key, int start, int end)
{
    // interger divison truncates the remainder (3+4)/2 = 3 not 3.5
	int middle = (start + end)/2;
	//Console.WriteLine("start " + start);
	//Console.WriteLine("end " + end);
	//Console.WriteLine("middle " + middle);
	//start > end -- means all values were checked and key was greater than largest value or less than smallest value
	if(start > end)
	{
		return -1;
	}
	else 
	{
		if(A[middle] == key)
		{
			return middle;
		}
		else if(key < A[middle])
		{
			end = middle - 1;
			return BinarySearchRecursive(A, key, start, end);
		}
		else if(key > A[middle])
		{
			start = middle + 1;
			return BinarySearchRecursive(A, key, start, end);
		}
	}
	
	return -1;
}