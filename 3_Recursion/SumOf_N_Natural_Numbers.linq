<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Recursive");
	Console.WriteLine(SumNumbersRec(5));
	
	Console.WriteLine("Formula");
	Console.WriteLine(sumN(5));
	
	Console.WriteLine("Iteration");
	Console.WriteLine(sumNIteration(5));
}

// recursive function to return the sum of N natural numbers if n == 3 return 3+2+1=6 --- O(n) linear run time
// sum(3) 3 + sum(2)
// sum(2) 2 + sum(1)
// sum(1) 1
public int SumNumbersRec(int n)
{
	if(n == 1)
	{
		//ends recursive calls 
		return 1;
	}
	else 
	{
		return n + SumNumbersRec(n-1);
	}
}

//just a mathematical proof somewhere for this O(1) -- constant run time best solution
public int sumN(int n)
{
    return n * (n + 1) / 2;
}

//O(n) -- linear run time
public int sumNIteration(int n)
{
	int total = 0;
	for(int i = 1; i<=n; i++)
	{
		total = total + i;
	}
	return total;
}