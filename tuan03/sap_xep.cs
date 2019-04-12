using System;
using System.Collections.Generic;

public class TinhDiem {
    public static void Main () {
        var u = new List<double> {};
        int len;
        double swap;

        Console.Write("Nhap do dai: ");
        len = int.Parse(Console.ReadLine());

        for(int i = 0; i < len; i ++) {
            Console.Write("Nhap u[" + (i) + "]: ");
            u.Add(double.Parse(Console.ReadLine()));
        }

        Console.Clear();
        Console.WriteLine("Day u:");
        Console.WriteLine(String.Join(", ", u.ToArray()));

        for(int i = 0; i < len; i ++){
            int cur_i = i;
            for(int j = i; j < len; j++) 
                if (u[j] < u[cur_i])
                    cur_i = j;
            if(cur_i != i) {
                swap = u[i];
                u[i] = u[cur_i];
                u[cur_i] = swap;
            }
        }
        Console.WriteLine("Day u sau khi sap xep: ");
        Console.WriteLine(String.Join(", ", u.ToArray()));
    }
}