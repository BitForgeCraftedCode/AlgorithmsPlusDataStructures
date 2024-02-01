<Query Kind="Program" />

void Main()
{
	calculateiterative(5);
	Console.WriteLine("---------");
	calculaterecursive(5);
}

//methods to calculate all the squares of an input integer
//an iterative method VS a Recursive method

public void calculateiterative(int n)
{
    while (n > 0) //n+1 comparisons
    {
        int k = n * n; //n multiplication n assignments
        Console.WriteLine(k); //n write lines
        n = n - 1; //n subtractions n assignment 
		//6n + 1 -- Linear O(n)
    }
}
/*
recursive call 
calcRec(2)
	--k=4
	--calcRec(2-1)
	 ect..
	 
	 no need to decrement n-- 
	 the method recursivly calls itself until condition false thus terminating the recursive call
	 
You can use the Recurrence relation to prove recursive function/methods are O(n) - Linear
*/
public void calculaterecursive(int n)
{
    if (n > 0)
    {
        int k = n * n;
        Console.WriteLine(k);
        calculaterecursive(n - 1);
    }
}

