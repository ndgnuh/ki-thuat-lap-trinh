using System;
using System.Linq;

class Program {
  public static void Main () {
    // Console.Write("Nhap a: ");
    // double a =Convert.ToDouble( Console.ReadLine());
    Random rnd = new Random();
    double a = rnd.NextDouble();
    TongTP(a);
  }

  private static int TongTP (double a) {
    double atp = a - (int)(a);
    Console.WriteLine("Phan thap phan cua a: " + atp);
    Int32 count  = atp.ToString().Count() - 2;
    int sum = 0;
    for(int i = 0; i < count; i++) {
      atp = atp * 10;
      sum += Convert.ToInt32(atp);
      atp = atp - (int)atp;
    }
    Console.WriteLine("Tong thap phan cua " + a + " la " + sum);
    return sum;
  }
}
