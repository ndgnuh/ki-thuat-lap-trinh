using System;

namespace Solver {

  class NewtonRaphson
  {
    private static double h = 10e-6;

    private static double df(Func<double, double> f, double x){
      double nume = f(x+h) - f(x-h);
      double eps = h;
      while(nume == 0)
      {
        eps *= 2;
        nume = f(x+eps) - f(x-eps);
      }
      return nume / eps / 2;
    }

    public static double Solve(Func<double, double> f, double x0, double tol = 10e-6, int max_iterations = 50)  {
      double x = x0;
      int iterate = 0;
      while(Math.Abs(f(x)) > tol && iterate < max_iterations){
        iterate += 1;
        x = x - f(x) / df(f, x);
      }
      return x;
    }
  }

  public class Program {
    public static void Main() {
      Func<double, double> f1 = (double x) => {
        return Math.Sin(x);
      };
      Func<double, double> f2 = (double x) => {
        return x*x - 2;
      };

      // pi
      Console.WriteLine("x = " + NewtonRaphson.Solve(f1, 3));
      // sqrt(2)
      Console.WriteLine("x = " + NewtonRaphson.Solve(f2, 1));

    }
  }
}