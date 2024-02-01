<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Tree Recursion");
	calculateTreeRecursion(4);
	Console.WriteLine("------------");
	
}

//methods to calculate all the squares of an input integer
//Recursive method
//https://medium.com/@masaabmushtaq/understanding-recursion-using-c-4aeb93f83e8d
public void calculateTreeRecursion(int n)
{
   if(n>0)
   {
   		calculateTreeRecursion(n-1);
   		int k = n*n;
		Console.WriteLine(k);
		calculateTreeRecursion(n-1);
   }
   
}

