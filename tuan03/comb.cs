using System; 

public class Combinator {
    public static void Main () {
        int n = 14, k = 3;
        Console.WriteLine(n + "C" + k + " = " + Comb(k,n));
    }

    private static long Fact(int n) {
        return n <= 1 ? 1 : Fact(n-1)*n;
    }

    private static int Comb(int k, int n)  {
        return Convert.ToInt32(Fact(n)) / 
            Convert.ToInt32(Fact(n-k)) / 
            Convert.ToInt32(Fact(k));
    }
}