using System;
using System.Collections.Generic;

namespace Helpers 
{
  public class List 
  {

    public static void PPrint(List<int> MyList){
      private static void PrettyPrint(List<int> MyList) {
        Console.Write("{");
        for(int i = 0; i < MyList.Count - 1; i++) {
          Console.Write(MyList[i] + ", ");
        }
        Console.WriteLine(MyList[MyList.Count-1] + "}");
      }
    }








  }
}