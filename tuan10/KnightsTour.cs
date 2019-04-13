using System;
using System.Collections.Generic;

namespace KnightsTour 
{
 class Program 
  {
    static public int width = 5;
    public static int height = 4;
    public static int n = height + 4; /* 2 border sentinel values */
    public static int m = width + 4;
    public static int iMax = n*m;
    public static int startPos = 3*m + 4;
    public static int Count = 0;
    public static int SolutionCount = 0;
    public static List<bool> Free = new List<bool> {};
    public static List<int> Path = new List<int> {};

    public static void Main(){
      Prepare();
      Try(startPos);
      Console.WriteLine("Total numer of solutions: " + SolutionCount);
    }

    public static void Prepare(){
      for(int i = 0; i < iMax; i++) {
        Free.Add(false);
        Path.Add(-1);
      }
      for(int i = 2; i < n-2; i++) {
        for(int j = 2; j < m-2; j++)
          /* 2x2 border sentinel values, inside are free */
          Free[i*m+j] = true;
      }
      Free[startPos] =false;
    }

    public static void Try(int i) {
        List<int> moves = new List<int> {
          i - m - 2, 
          i - m + 2,
          i + m - 2,
          i + m + 2,
          i - 2*m - 1,
          i - 2*m + 1,
          i + 2*m - 1,
          i + 2*m + 1
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
          if(Count > 2 && j == startPos ){
            SolutionCount+=1;
            PrintBoard();
          }
        }
    }

    public static void PrintBoard(bool all = false){
      for(int i = 0; i < m; i++) Console.Write("###");
      Console.WriteLine("");

      int start = all ? 0 : 2;
      int end = all ? n : n -2;
      int cend = all ? m : m -2;

      for(int i = start; i < end; i++) {
        for(int j = start; j < cend; j++)
          if (i*m + j == startPos) Console.Write("|  0");
          else if(Path[i*m+j] > 0) Console.Write("|" + Convert.ToString(Path[i*m+j]).PadLeft(3));
          else if(!Free[i*m+j]) Console.Write("|@@@");
          else Console.Write("|   ");
        Console.WriteLine("|");
      }
    }
  }

}
 