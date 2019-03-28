using System;
using System.Numerics;
using System.IO;

namespace PIDigits 
{
  public class BigDecimal 
  {
    public static int Precision = 200;
    public static BigInteger A = BigInteger.Pow(10, Precision);
    public BigInteger Deno;
    public BigInteger Nume;

    public BigDecimal(BigInteger Nume, BigInteger Deno) {
      this.Deno = Deno;
      this.Nume = Nume;
    }

    // vô hướng
    public static BigDecimal operator *(BigDecimal Left, int Right) {
      return new BigDecimal(Left.Nume*Right, Left.Deno);
    }
    // trong tập số.
    public static BigDecimal operator *(BigDecimal Left, BigDecimal Right) {
      return new BigDecimal(Left.Nume * Right.Nume, Left.Deno * Right.Deno);
    }
    public static BigDecimal operator +(BigDecimal Left, BigDecimal Right) {
      return new BigDecimal(Left.Nume * Right.Deno + Left.Deno*Right.Nume, Left.Deno * Right.Deno);
    }

    public BigInteger Val() {
      return this.Nume*A/this.Deno;
    }

    public override string ToString() {
      string S = Convert.ToString(this.Val()).PadLeft(Precision, '0');
      S = S.Insert(S.Length - Precision, ".");
      return S;
    }
  }

  public class Program 
  {
    public static void Main () {
   
      string S = Convert.ToString(PI());
   
      Console.WriteLine("Number of digits: " + (S.Length - 2));
   
      using(StreamWriter sw = File.CreateText(Directory.GetCurrentDirectory() + "/PI")) {
        sw.WriteLine(S);
        sw.Close();
      }
    }

    private static BigDecimal PI(){
      // arctan(1) = arctan(1/2) + arctan(1/3)
      BigDecimal Term1 = new BigDecimal(1,2);
      BigDecimal Term2 = new BigDecimal(1,3);
      int n = 1; int sgn = 1;
      BigDecimal Sum = new BigDecimal(0,1);
      while(Term1.Val() > 0) {
        Sum = Sum + ((Term1 + Term2) * sgn);
        Term1.Nume = Term1.Nume * n;
        Term2.Nume = Term2.Nume * n;
        n = n + 2; sgn = -sgn;
        Term1.Deno = Term1.Deno * n * 4;
        Term2.Deno = Term2.Deno * n * 9;
      }
      Sum = Sum*4;
      Console.WriteLine(Sum);
      return Sum;
    }
  }
}

