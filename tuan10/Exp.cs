using System;

class SqrtOfTwo 
{
  public static void Main () {
    const double x = 1;
    const int digit = 6;
    double exp = Math.Round(Exp(x), digit);
    double expBuiltIn = Math.Round(Math.Exp(x), digit);
    Console.WriteLine("Exp(" + x + ") = " + exp);
    Console.WriteLine("Math.Exp(" + x + ") = " + expBuiltIn);
    Console.WriteLine("Diff = " + (exp - expBuiltIn));
  }

  private static double Exp(double x, double tol = 10e-9) {
    double e = 1;
    double numerator = x;
    int denominator = 1;
    int n = 1;

    while(Math.Abs(numerator / denominator) > tol) {
      e += numerator / denominator;
      n += 1;
      denominator *= n;
      numerator *= x;
    }
    return e;
  }
}
