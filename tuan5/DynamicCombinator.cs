using System;
using System.Collections.Generic;

class DynamicCombinator 
{
  private static List<double> FactorialList = new List<double> {1};

  public static void Main () {
 
    Console.Write("[input] n: "); 
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("[input] k: "); 
    int k = Convert.ToInt32(Console.ReadLine());

    if (n > 170) Console.WriteLine("[warning] " + n + "! is very large, C# may not handle it");

    Console.WriteLine("[output] " + n + "C" + k + ": " + Combinator(k,n));
 
  }

  private static double Combinator (int k, int n)  {

    for(int i = FactorialList.Count; i <= n; i++) {
      FactorialList.Add(FactorialList[i-1]*i);
    }

    return FactorialList[n]
      / FactorialList[k]
      / FactorialList[n-k];
  
  }
}