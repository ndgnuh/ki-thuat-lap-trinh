using System;
using System.Numerics;

// need to make reference to System.Numerics.dll when compiling
// mcs /reference:System.Numerics.dll %f

public class Program 
{

  public static void Main() {
    BigInteger a = new BigInteger(1234444);
    BigInteger b = new BigInteger(9018273645);
    
    Console.WriteLine(b*b*b*b*b*b);
    Console.WriteLine(b > a);
    Console.WriteLine(b % a);
    Console.WriteLine("100! = " + Fact(100));
  }

  private static BigInteger Fact(int n) {
    if(n == 1) return 1;
    else return Fact(n-1)*n;
  }
}