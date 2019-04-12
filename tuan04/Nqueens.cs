using System;
using System.Collections.Generic;

public class Program 
{
  static private List<bool> R = new List<bool> {};
  static private Dictionary<int, bool> D1 = new Dictionary<int, bool>();
  static private Dictionary<int, bool> D2 = new Dictionary<int, bool>();

  private static int BoardSize;
  private static List<int> ColPos = new List<int> {};

  public static void Main () {
    Console.Write("BoardSize: ");
    BoardSize = Convert.ToInt32(Console.ReadLine());
    PrepareBoard();
    Try(0);
  }

  public static void PrepareBoard() {
    for(int i = 0; i < BoardSize; i++) {
      R.Add(true);
      ColPos.Add(0);
    }
    for(int i = -2*BoardSize; i < 2*BoardSize; i++) {
      D1.Add(i, true); 
      D2.Add(i, true);
    }
  }

  public static void Try(int Col) {
    for(int Row = 0; Row < BoardSize; Row++) {
      if(IsSafe(Row, Col)) {
        Place(Row, Col);
        if (Col < BoardSize - 1) Try(Col+1); else DrawBoard();
        Free(Row, Col);
      }
    }
  }

  private static bool IsSafe(int Row, int Col) {
    return R[Row] && D1[Row+Col] && D2[Row-Col];
  }

  private static void Place(int Row, int Col) {
    ColPos[Row] = Col;
    R[Row] = false;
    D1[Row+Col] = false;
    D2[Row-Col] = false;
  }
  
  private static void Free(int Row, int Col) {
    R[Row] = true;
    D1[Row+Col] = true;
    D2[Row-Col] = true;
  }

  private static void DrawBoard() {
    for(int Row = 0; Row < (2*BoardSize-8)/2; Row ++) Console.Write(" ");
    Console.WriteLine("Solution: ");
    for(int Row = 0; Row < BoardSize; Row ++){
      Console.Write("|");
      for(int Col = 0; Col < BoardSize; Col++) 
        if(Col == ColPos[Row]) Console.Write("x|"); else Console.Write(" |");
      Console.WriteLine();
    }
  }
}