using System;
using System.Collections.Generic;

public class PrimalityTest
{
	public static bool IsPrime(int n)
	{
		for(int i = 2; i < n/2+1; i++)
			if(n % i == 0)
				return false;
		return (n > 1) && true;
	}

	public static bool IsPrimeV2(int n)
	{
		for(int i = 2; i < n; i++)
			if(n % i == 0)
				return false;
		return (n > 1) && true;
	}

	public static bool EratosthenesCheck(int n)
	{
		List<bool> isPrime = new List<bool>{false, false};
		for (int i = 2; i < n+1; i++)
		{
			isPrime.Add(true);
		}
		for (int i = 2; i < n+1; i++)
		{
			for (int j = i*i; j < n+1; j=j+i)
			{
				isPrime[j] = false;
			}
		}
		return isPrime[n];
	}

	public static void Main()
	{
		if(IsPrime(13))
			Console.WriteLine("is a prime");
		else
			Console.WriteLine("not a prime");

		if(IsPrimeV2(121))
			Console.WriteLine("is a prime");
		else
			Console.WriteLine("not a prime");

		if(EratosthenesCheck(37))
			Console.WriteLine("is a prime");
		else
			Console.WriteLine("not a prime");
	}
}
