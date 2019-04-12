using System;
using System.Numerics;
using System.IO;

namespace PIDigits 
{
  public class BigDecimal 
  {
    // tạo trường thực 
    private static int Precision = 300;
    public static int Slop = 2;
    private static BigInteger A = BigInteger.Pow(10, Precision + Slop);
    public BigInteger Deno;
    public BigInteger Nume;

    public BigDecimal(BigInteger Nume, BigInteger Deno) {
      this.Deno = Deno;
      this.Nume = Nume;
    }

    public static void UpdatePrecision(int P) {
      Precision = P;
      A = BigInteger.Pow(10, P + Slop);
    }

    // vô hướng
    public static BigDecimal operator *(BigDecimal Left, int Right) {
      return new BigDecimal(Left.Nume*Right, Left.Deno);
    }
    public static BigDecimal operator /(BigDecimal Left, int Right) {
      return new BigDecimal(Left.Nume, Left.Deno * Right);
    }
    // trong tập số.
    public static BigDecimal operator *(BigDecimal Left, BigDecimal Right) {
      return new BigDecimal(Left.Nume * Right.Nume, Left.Deno * Right.Deno);
    }
    public static BigDecimal operator +(BigDecimal Left, BigDecimal Right) {
      return new BigDecimal(Left.Nume * Right.Deno + Left.Deno*Right.Nume, Left.Deno * Right.Deno);
    }

    public static BigDecimal operator -(BigDecimal Left, BigDecimal Right) {
      return new BigDecimal(Left.Nume * Right.Deno - Left.Deno*Right.Nume, Left.Deno * Right.Deno);
    }

    public BigInteger Val() {
      return this.Nume*A/this.Deno;
    }

    public override string ToString() {
      string S = Convert.ToString(this.Val()).PadLeft(Precision + Slop, '0');
      S = S.Insert(S.Length - Precision - Slop, ".");
      S = S.Remove(S.Length - Slop);
      return S;
    }
  }

  public class Program 
  {
    public static void Main () {
      // Console.Write("Precision: ");
      // BigDecimal.UpdatePrecision(Convert.ToInt32(Console.ReadLine()));

      string S = Convert.ToString(PI());
      Console.WriteLine(S);
      Console.WriteLine("Number of digits: " + (S.Length - 2));
      using(StreamWriter sw = File.CreateText(Directory.GetCurrentDirectory() + "/PI")) {
        sw.WriteLine(S);
        sw.Close();
      }
    }

    private static BigDecimal PI(){
      int count = 0;
      // arctan(1) = 12*arctan(1/18) + 8*arctan(1/57) - 5*arctan(1/239)
      BigDecimal Term1 = new BigDecimal(1,57);
      BigDecimal Term2 = new BigDecimal(1,239);
      BigDecimal Term3 = new BigDecimal(1,682);
      BigDecimal Term4 = new BigDecimal(1,12943);
      int n = 1; int sgn = 1;
      BigDecimal Sum = new BigDecimal(0,1);
      while((Term1).Val() > 0) {
        // chưa được tối ưu
        Sum = Sum + ((Term1*44 + Term2*7-Term3*12 + Term4*24) * sgn);
        Term1.Nume = Term1.Nume * n;
        Term2.Nume = Term2.Nume * n;
        Term3.Nume = Term3.Nume * n;
        Term4.Nume = Term4.Nume * n;
        n = n + 2; sgn = -sgn;
        Term1.Deno = Term1.Deno * n * 3249;
        Term2.Deno = Term2.Deno * n * 57121;
        Term3.Deno = Term3.Deno * n * 465124;
        Term4.Deno = Term4.Deno * n * 167521249;
        count ++;
      }
      Sum = Sum * 4;
      Console.WriteLine("Loop Count: " + count);
      return Sum;
    }
  }
}

