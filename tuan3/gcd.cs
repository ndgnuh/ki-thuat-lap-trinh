using System;
using System.Collections.Generic;

public static class Program {
    public static int Main () {
        int a = 16*8; int b = 24332;
        Console.WriteLine("Gcd(" + a + "," + b + ") = " + Gcd(a,b));
        return 0;
    }

    private static int Gcd(int a, int b) {
        return GcdLoop(a, b);
    }

    private static int GcdRcs(int a, int b) {
        return b % a == 0 ? a : GcdRcs(b % a, a);
    }

    private static int GcdLoop(int a, int b) {
        while (true){
            if ( b % a == 0 ) return a;
            if ( a % b == 0 ) return b;
            if ( b > a )
                b = b % a;
            else
                a = a % b;
        }
    }

    private static int GcdDyn(int a, int b) {
        var u = new List<int> {a, b};
        int len = u.Count;
        int c, d;
        while(true) {
            if ( u[len - 2] % u[len - 1] == 0) {
                return u[len-1];
            }
            if ( u[len-1] % u[len-2] == 0) {
                return u[len-2];
            }
            len = u.Count;
            c = u[len-2];
            d = u[len-1];
            if ( d > c )
                u.Add(d % c);
            else
                u.Add(c % d);
        }
    }
}