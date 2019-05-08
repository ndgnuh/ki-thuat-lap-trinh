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

	public static void Main()
	{
		int n = 121;

		if(IsPrime(n))
			Console.WriteLine("is a prime");
		else
			Console.WriteLine("not a prime");
	}
}
