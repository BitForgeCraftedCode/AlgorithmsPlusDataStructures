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

/* TAIL Recursion
 cal(4) k=16 then cal(4-1)
 cal(3) k=9 then cal(3-1)
 cal(2) k=4 then cal(2-1) ect.. 
 
 much easier to follow then HEAD Recursion as the fucntion statements execute 1st then call the function again
*/
public void calculateTailRecursion(int n)
{
   if(n>0)
   {
   		int k = n*n;
		Console.WriteLine(k);
		calculateTailRecursion(n-1);
   }
   
}

/* HEAD Recursion
 cal(4)
 cal(3)
 cal(2)
 cal(1)
 cal(0) -- only then does control return to cal(1) -- thus printing 1 , 4, ect..
 
 in cal(1) the recursive call to cal(0) is completed so statements are executed and k=1
 in cal(2) the recursive call to cal(1) is completed so statements are executed and k=4
 in cal(3) the recursive call to cal(2) is completed so statements are executed and k=9 ect..
 
 basically every function call goes on the stack and is called backwads as compared to Tail
*/
public void calculateHeadRecursion(int n)
{
   if(n>0)
   {
   		calculateHeadRecursion(n-1);
   		int k = n*n;
		Console.WriteLine(k);
   }
   
}
