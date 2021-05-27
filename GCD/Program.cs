// C# program to find GCD of
// two or more numbers
using System;

public class GCD {
	
	// Function to return gcd of a and b
	static int gcd(int a, int b)
	{
		if (a == 0)
			return b;
		return gcd(b % a, a);
	}

	// Function to find gcd of
	// array of numbers
	static int findGCD(int[] arr, int n)
	{
		int result = arr[0];
		for (int i = 1; i < n; i++){
			result = gcd(arr[i], result);

			if(result == 1)
			{
			return 1;
			}
		}

		return result;
	}
	
	// Driver Code
	public static void Main()
	{
		int[] arr = { 2, 4, 6, 8, 16 };
		int n = arr.Length;
		Console.Write(findGCD(arr, n));
	}
}

// This code is contributed by nitin mittal
