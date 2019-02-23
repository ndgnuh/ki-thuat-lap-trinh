using System;

public class Program {
    public static int Main() {
        int n = 1234, sum = 0;
        int i = (int)Math.Pow(10, n.ToString().Length - 1);
        int m = n;
        while(i != 0) {
            sum += m / i;
            m = m - (m/i) * i;
            Console.WriteLine("sum = " + sum);
            i /= 10;
        }
        Console.WriteLine("Tong chu so cua " + n + " la " + sum);
        return 0;
    }
}