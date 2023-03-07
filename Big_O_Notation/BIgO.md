# Big O Definition

We say that an algorithm is **O(f(n))** if the number of simple operations the computer has to do is
eventually less than a constant times **f(n)**, as **n** increases.

It is a way of measuring how complex the algortihm is or how many operations must be done for the given algorithm.
Count the operations. The more complex the algorthim the longer it will take to run. 

* f(n) could be linear f(n) = n
* f(n) could be quadratic f(n) = n^2
* f(n) could be constant f(n) = 1
* f(n) could be something entirely different.

For example the two functions below to find the sum of the first n natural numbers.

## 1st function 
	function addUpTo(n) {
		let total = 0; //1 assignment 
		for (let i = 1; i <= n; i++) {
			total += i; //n additions and n assignments
		}
		return total;
	}

	var t1 = performance.now();
	addUpTo(1000000000);
	var t2 = performance.now();
	console.log(`Time Elapsed: ${(t2 - t1) / 1000} seconds.`);

This function has 5n + 2 operations 
Thus a Big O of n O(n) -- f(n) = 5n + 2 is linear

## 2nd function
	function addUpTo(n) {
	  return n * (n + 1) / 2;
	}

	var time1 = performance.now();
	addUpTo(1000000000);
	var time2 = performance.now();
	console.log(`Time Elapsed: ${(time2 - time1) / 1000} seconds.`);

This function has 3 simple operations no matter how big n is. (multiply, add, and divide) always 3 operations
Thus a Big O of 1 O(1) -- f(n) = 3 is constant

## Another example nested loops

	function printAllPairs(n) {
		for(var i = 0; i < n; i++){		
			for(var j = 0; j < n; j++){
				console.log(i, j);
			}
		}
	}

console log will run n^2 times (or n*n times). If n=5 there will be 25 write lines
Big O of n^2 O(n^2) -- f(n) is quadratic