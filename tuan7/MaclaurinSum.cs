using System;

namespace Maclaurin {

  public class Sum
  {
    public static void Main() {
      Sin.EvalAt(Math.PI/3);
      Sqrt.EvalAt(2);
      Pi.Eval();
    }
  }


  internal class Sin 
  {
    private static int n = 1;
    private static double Term;
    public static double Tol = 10e-8;

    private static double NextTerm(double x) {
      /*
       * a_{n+1} = - a_n * x^2 / [(n+1)*(n+2)]
       */
      n += 2;
      return - Term * x * x / n / (n-1);
    }

    public static double EvalAt(double x) {
      double Sum = 0;
      Term = x;
      while(Math.Abs(Term) > Tol) {
        Sum += Term;
        Term = NextTerm(x);
      }
      Console.WriteLine("Sin(" + x + ") = " + Sum);
      return Sum;
    }
  }


  internal class Pi
  {
    private static int n = 1;
    private static int Sign = 1;
    private static double Term;
    public static double Tol = 10e-8;

    private static double NextTerm() {
      /*
       * a_n = (-1)^n / (2n+1)
       */
      n += 2; Sign = -Sign;
      return Sign * 1.0 / n;
    }

    public static double Eval() {
      double Sum = 0;
      Term = 1.0;
      while(Math.Abs(Term) > Tol) {
        Sum += Term;
        Term = NextTerm();
      }
      Sum = Sum*4;
      Console.WriteLine("Pi = " + Sum);
      return Sum;
    }
  }


  internal class Sqrt {
    private static int n = 3;
    private static double Term;
    public static double Tol = 10e-4;

    private static double NextTerm(double x) {
      /*
       * a_{n+1} = a_{n} * (2n-1)(2n-1)/[4(n^2-1)]
       * |a_{n+1} / a_n| ---> 1, that's why x < 2;
       */
      double NextTerm = - Term * x * (2*n-1) * (2*n - 2) / (n*n-1)/4;
      n += 1;
      return NextTerm ;
    }

    public static double EvalAt(double RealX) {
      if(RealX > 2) {
        Console.WriteLine("This method doesn't work for x > 2");
        return -1;
      }
      double x = RealX - 1;
      double Sum = 1 + x/2 - x*x/8;
      Term = x*x*x/16;
      while(Math.Abs(Term) > Tol) {
        Sum += Term;
        Term = NextTerm(x);
      }
      Console.WriteLine("Sqrt(" + RealX + ") = " + Sum);
      return Sum;
    }
  }

}