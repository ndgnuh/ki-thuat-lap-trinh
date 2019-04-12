using System;

class SqrtOfTwo 
{
  public static void Main () {
    double x = 625;
    const double tol = 10e-6;
    Console.WriteLine("sqrt(2) = " + Sqrt2(tol));
    Console.WriteLine("sqrt(" + x + ") = " + Sqrt(x, tol));
  }

  private static double Sqrt2(double tol) {
    // solve for f(x) = x^2 - 2 = 0
    double x = 1;
    while(Math.Abs(x*x - 2) > tol) {
      // x - f(x) / f'(x) = x - (x^2 - 2) / (2x) = x/2 + 1/x
      x = x/2 + 1/x;
    }
    return x;
  }

  private static double Sqrt(double y, double tol) {
    // solve for f(x) = x^2 - 2 = 0
    double x = y/2;
    while(Math.Abs(x*x - y) > tol) {
      // x - f(x) / f'(x) = x - (x^2 - 2) / (2x) = x/2 + 1/x
      x = x/2 + y/x/2;
    }
    return x;
  }
}
