<Query Kind="Program" />

void Main(string[] args)
{
	 // array must be in order for binary search
	 int[] A = { 15, 21, 47, 84, 96 };
	 //Console.WriteLine("is 100 in A " + BinarySearch(A, A.Length, 100));
	 //Console.WriteLine("is 47 in A " + BinarySearch(A, A.Length, 47));
	 Console.WriteLine("is 84 in A " + BinarySearch(A, A.Length, 84));
	
	
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
 
 Binary search is O(logn) -- https://stackoverflow.com/questions/2307283/what-does-olog-n-mean-exactly
*/
static int BinarySearch(int[] A, int n , int key)
{
    
	int start = 0;
	int end = n - 1;
	while(start <= end)
	{
		// interger divison truncates the remainder (3+4)/2 = 3 not 3.5
		int middle = (start + end)/2;
		//Console.WriteLine("start " + start);
		//Console.WriteLine("end " + end);
		//Console.WriteLine("middle " + middle);
		if(A[middle] == key)
		{
			return middle;
		}
		else if(key < A[middle])
		{
			end = middle - 1;
		}
		else if(key > A[middle])
		{
			start = middle + 1;
		}
	}
	//exit loop without return -- nothing found so return -1
	return -1;
	
}