using System;

public class Expx
{

  public static void Main() {
    Console.Write("x: ");
    double x = Double.Parse(Console.ReadLine());

    // default tolerance
    Console.Write("tolerance (default 10e-12): ");
    string tol_s = Console.ReadLine();
    double tol;
    if(String.IsNullOrEmpty(tol_s)) 
      tol = 10e-12; 
    else 
      tol = Double.Parse(tol_s);

    // calculate the result, compare with built-in method
    Console.WriteLine("Exp(x) = " + Exp(x, tol));
    Console.WriteLine("Math.Exp(x) = " + Math.Exp(x));
  }

  private static double Exp(double x, double tol = 10e-4) {
    double term = 1;
    double sum = 0;
    int n = 0;
    while (true) {
      sum = sum + term;

      // term is sufficently small
      if(term < tol) {
        return sum;
      }
      /* 
       * a_n = x^n / n! 
       * --> a_{n+1} = a_n * x / (n+1)
       */ 
      n = n + 1;
      term = term * x / n;
    }
  }



}