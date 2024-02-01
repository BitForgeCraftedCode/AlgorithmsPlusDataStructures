<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Tail Recursion");
	calculateTailRecursion(4);
	Console.WriteLine("------------");
	Console.WriteLine("Head Recursion");
	calculateHeadRecursion(4);
}

//methods to calculate all the squares of an input integer
//Recursive method
//https://medium.com/@masaabmushtaq/understanding-recursion-using-c-4aeb93f83e8d
public void calculateTailRecursion(int n)
{
   if(n>0)
   {
   		int k = n*n;
		Console.WriteLine(k);
		calculateTailRecursion(n-1);
   }
   
}

public void calculateHeadRecursion(int n)
{
   if(n>0)
   {
   		calculateHeadRecursion(n-1);
   		int k = n*n;
		Console.WriteLine(k);
		
   }
   
}
