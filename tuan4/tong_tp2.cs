using System;

class Program {
  public static void Main () {
    Console.Write("Nhap a: ");
    double a =Convert.ToDouble( Console.ReadLine());
    // Random rnd = new Random();
    // double a = 123.3232;
    TongTP(a);
  }

  private static int TongTP (double a) {
    string astr = a.ToString();
    int sum = 0;
    for( int i = astr.Length - 1; i > 0; i --) {
      sum += Convert.ToInt32(Char.GetNumericValue(astr[i]));
      if(astr[i] == '.') {
        Console.WriteLine("Tong thap phan cua " + a + " la " + sum);
        return sum;
      };
    }
    return sum;

  }
}