using System;

class SqrtOfTwo 
{
  public static void Main () {
    Console.WriteLine("sqrt(2) = " + Sqrt2(10e-4));
  }

  private static double Sqrt2(double tol) {
    // solve for x^2 - 2 = 0
    double x = 1;
    while(Math.Abs(f(x)) > tol) {
      x = x - f(x)/df(x);
    }
    return x;
  }

  private static double f(double x) {
    return x*x - 2;
  }

  private static double df(double x) {
    return 2*x;
  }
}