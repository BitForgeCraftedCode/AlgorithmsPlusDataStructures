<Query Kind="Program" />

void Main(string[] args)
{
	
	 int[] A = { 84, 21, 47, 96, 15 };
	 Console.WriteLine("is 100 in A " + LinearSearch(A, A.Length, 100));
	 Console.WriteLine("is 47 in A " + LinearSearch(A, A.Length, 47));
	
	
}

// You can define other methods, fields, classes and namespaces here
static int LinearSearch(int[] A, int n , int key)
{
	int index = 0;
	while(index < n)
	{
		if(A[index] == key)
		{
			return key;
		}
		index++;
	}
	return -1;
}