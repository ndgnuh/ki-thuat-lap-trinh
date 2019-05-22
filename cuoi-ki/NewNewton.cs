using System;

public class NewtonSolver
{
	public static double tol = 10e-6;

	public static void Main()
	{
		Func<double, double> f = (double x) => {
			return x*x - 2;
		};
		Func<double, double> df = (double x) => {
			return 2*x;
		};

		SolveV1(f, df, 1, 1);
		SolveV2(f, df, 1, 4, 1);
		SolveV3(f, df, 1);

	}

	public static double SolveV1(Func<double, double> f, Func<double, double> df, double mindf, double x)
	{
		while(Math.Abs(f(x))>= tol*mindf )
		{
			if(df(x) == 0)
			{
				Console.WriteLine("Error, df/dx == 0 where x = " + x);
				return -1;
			}
			x = x - f(x)/df(x);
		}
		Console.WriteLine("x = " + x);
		return x;
	}

	public static double SolveV2(Func<double, double> f, Func<double, double> df, double mindf, double maxdf, double x)
	{
		if(df(x) == 0)
		{
			Console.WriteLine("Error, df/dx == 0 where x = " + x);
			return -1;
		}
		double diff = f(x) / df(x);

		while(mindf*Math.Abs(diff) > maxdf*tol)
		{
			if(df(x) == 0)
			{
				Console.WriteLine("Error, df/dx == 0 where x = " + x);
				return -1;
			}
			x = x - diff;
			diff = f(x) / df(x);
		}
		Console.WriteLine("x = " + x);
		return x;
	}

	public static double SolveV3(Func<double, double> f, Func<double, double> df, double x)
	{
		double prevx;
		while(true)
		{
			if(df(x) == 0)
			{
				Console.WriteLine("Error, df/dx == 0 where x = " + x);
				return -1;
			}
			prevx = x;
			x = x - f(x)/df(x);
			if(Math.Abs(f(prevx) - f(x)) < tol) 
			{
				Console.WriteLine("x = " + x);
				return x;
			}
		}
	}

}
