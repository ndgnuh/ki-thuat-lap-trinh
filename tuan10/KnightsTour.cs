using System;
using System.Collections.Generic;

namespace KnightsTour 
{
 class Program 
  {
    static public int width = 4;
    public static int n = width + 4;
    public static int iMax = n*n;
    public static int startPos = 3*n + 4;
    public static int Count = 0;
    public static int SolutionCount = 0;
    public static List<bool> Free = new List<bool> {};
    public static List<int> Path = new List<int> {};

    public static void Main(){
      Prepare();
      Try(startPos);
    }

    public static void Prepare(){
      for(int i = 0; i < iMax; i++) {
        Free.Add(false);
        Path.Add(-1);
      }
      for(int i = 2; i < n-2; i++) {
        for(int j = 2; j < n-2; j++)
          Free[i*n+j] = true;
      }
      Free[startPos] =false;
    }

    public static void Try(int i) {
        // PrintBoard();
        List<int> moves = new List<int> {
          i - n - 2, 
          i - n + 2,
          i + n - 2,
          i + n + 2,
          i - 2*n - 1,
          i - 2*n + 1,
          i + 2*n - 1,
          i + 2*n + 1
        };
        foreach(int j in moves) {
          if(Free[j]) {
            Count += 1;
            Free[j] = false;
            Path[j] = Count;
            Try(j);
            Free[j] = true;
            Path[j] = -1;
            Count -= 1;
          }
          else if(Count > 2 && j == startPos )
          {
            PrintBoard();
          }
        }

    }
    // public static void PrintBoard() {
    //   for(int i = 0; i < iMax; i ++){
    //     if(Free[i]) Console.Write("|1");
    //     else Console.Write("|0");
    //     if((i + 1) % n == 0) Console.WriteLine("|");
    //   }
    // }

    public static void PrintBoard(bool all = false){
      for(int i = 0; i < n; i++) Console.Write("###");
      Console.WriteLine("");

      int start = all ? 0 : 2;
      int end = all ? n : n -2;

      for(int i = start; i < end; i++) {
        for(int j = start; j < end; j++)
          if (i*n + j == startPos) Console.Write("|  0");
          else if(Path[i*n+j] > 0) Console.Write("|" + Convert.ToString(Path[i*n+j]).PadLeft(3));
          else Console.Write("|   ");
        Console.WriteLine("|");
      }
    }
  }

}
 