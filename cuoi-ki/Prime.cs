using System;

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

	public static bool IsPrimeV3(int n)
	{
		for(int i = 2; i < n; i++)
		{
			for(int j = 1; j < n/i; j++)
			{
				if(n % (i * j) == 0) return false;
			}
		}
		return (n > 1) && true;
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

		if(IsPrimeV3(1))
			Console.WriteLine("is a prime");
		else
			Console.WriteLine("not a prime");
	}
}
