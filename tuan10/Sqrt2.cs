using System;

class SqrtOfTwo 
{
  public static void Main () {
    const double tol = 10e-9;
    const int digit = 6;
    double sqrt2 = Math.Round(Sqrt2(tol), digit);
    double sqrt2BuiltIn = Math.Round(Math.Sqrt(2), digit);
    Console.WriteLine("Sqrt(2) = " + sqrt2);
    Console.WriteLine("Math.Sqrt(2) = " + sqrt2BuiltIn);
    Console.WriteLine("Diff = " + (sqrt2 - sqrt2BuiltIn));
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
}
