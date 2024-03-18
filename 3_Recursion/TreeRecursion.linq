<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Tree Recursion");
	calculateTreeRecursion(3);
	Console.WriteLine("------------");
	
}

//methods to calculate all the squares of an input integer
//Recursive method
//https://medium.com/@masaabmushtaq/understanding-recursion-using-c-4aeb93f83e8d

/* TREE Recursion when a recursive method calls itself more than once 
 cal(3)
 cal(2)
 cal(1)
 cal(0) -- only then does control return to cal(1)
 
 in cal(1) the recursive call to cal(0) is completed so statements are executed and k=1 then cal(0) is called no output condition false
 in cal(2) the recursive call to cal(1) is completed so statements are executed and k=4 then cal(1) is called again printing 1 again
 
 --too complex to write out furthe see the png file -- recursive calls form a TREE!! 
 
 its O(2^n)
*/
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

