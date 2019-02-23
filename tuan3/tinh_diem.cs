using System;
using System.Collections.Generic;

public class TinhDiem {
    public static void Main () {
        var thang_diem = new List<double> {3.5, 5, 6.5, 8};
        var thang_diem_chu = new List<String> {"D", "C", "B", "A"};
        String diem_chu = "F";

        Console.Write("Nhap diem: ");
        float diem = float.Parse(Console.ReadLine());
        for(int i = 0; i < thang_diem.Count; i++) 
            if(diem >= thang_diem[i]) 
                diem_chu = thang_diem_chu[i];
        Console.WriteLine("Diem chu: " + diem_chu);
    }
}