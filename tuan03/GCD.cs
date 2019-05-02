using System;

public class GcdFinder
{
	public static int Main() 
	{
		Console.Write("a = ");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b = ");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("UCLN(a,b) = " + Gcd(a,b));
		return 0;
	}

	public static int Gcd(int a, int b) 
	{
		if (a == 0) return b;
		if (b == 0) return a;
		if (a == b) return a;
		if (a > b) return Gcd(a % b, b);
		return Gcd(b % a, a);
	}
}
