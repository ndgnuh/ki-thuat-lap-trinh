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

	public static bool IsPrimeV3(int n)
	{
		List<int> P = new List<int>{};
		for(int i = 2; i < n; i++) P.Add(i);
		for(int i = 2; i < P.Count; i++)
		{
			for(int j = 2; j < n/P[i]; j++)
			{
				/* vì mục đích là kiểm tra số n có nguyên tố hay không, nên nếu tìm ra được một bội số là n thì thoát luôn */
				if(P[i]*j == n) return false;

				/* xóa bớt các bội số */
				P.Remove(P[i]*j);
				i = i - 1;
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

		if(IsPrimeV3(7))
			Console.WriteLine("is a prime");
		else
			Console.WriteLine("not a prime");
	}
}
