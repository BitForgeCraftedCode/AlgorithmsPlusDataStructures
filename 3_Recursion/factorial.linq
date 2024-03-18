<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Recursive");
	Console.WriteLine(FactRec(5));
	
	Console.WriteLine("Iteration");
	Console.WriteLine(FactIteration(5));
}

// recursive function to return the factorial of numbers if n == 3 return 3*2*1=6 --- O(n) linear run time
// fact(3) 3 * fact(2)
// fact(2) 2 * fact(1)
// fact(1) 1
// fact(0) 1
public int FactRec(int n)
{
	if(n == 0)
	{
		//ends recursive calls 
		return 1;
	}
	else 
	{
		return n * FactRec(n-1);
	}
}



//O(n) -- linear run time
// fact(3) = 3*2*1 = 6
// total = 1*1
// total = 1*2
// total = 2*3
public int FactIteration(int n)
{
	int total = 1;
	for(int i = 1; i<=n; i++)
	{
		total = total * i;
	}
	return total;
}