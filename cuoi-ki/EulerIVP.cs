using System;

public class EulerIVP
{
	public static void Main()
	{
		Func<double, double, double> f = (double x, double y) => { return 1 - y; };
		Euler(f, 0, 0, 0.5, 10);
	}

	public static double Euler(Func<double, double, double> f, double x0, double y0, double x, double stepnum)
	{
		double step = (x - x0) / stepnum;
		for(int i = 0; i < stepnum; i++){
			y0 = y0 + step*f(x0, y0);
			x0 = x0 + step;
			Console.WriteLine("x = " + Pad(x0) + " | y = " + Pad(y0));
		}
		return y0;
	}

	public static string Pad(double a)
	{
		return Convert.ToString(a).PadRight(20, ' ');
	}
}
