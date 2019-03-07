using System; 
using System.Collections.Generic;
using System.Linq;

class QSDNC 
{
  public static void Main () {
    List<int> ListToSort = new List<int> {3,4,1,5,1,35,3,12,2412,3};
    List<int> SortedList = Sort(ListToSort.ToList(), 0, ListToSort.Count-1);
    Console.WriteLine("List before sorted:");
    PrettyPrint(ListToSort);
    Console.WriteLine("Sorted List");
    PrettyPrint(SortedList);
  }

  private static  List<int> Sort(List<int> MyList, int FirstIndex, int LastIndex) {
    if(FirstIndex < LastIndex) {
      int PartIndex = Part(MyList, FirstIndex, LastIndex);
      Sort(MyList, FirstIndex, PartIndex-1);
      Sort(MyList, PartIndex+1, LastIndex);
    }
    return MyList;
  }

  private static int Part(List<int> MyList, int FirstIndex, int LastIndex) {
    int Pivot = MyList[LastIndex];
    int i = FirstIndex - 1;
    for(int j = FirstIndex; j < LastIndex; j++) {
      if(MyList[j] <= Pivot) 
        { i ++;  Swap(MyList, i, j); }
    }
    Swap(MyList, i+1, LastIndex);
    return i + 1;
  }

  private static void Swap(List<int> MyList, int Index1, int Index2) {
    int Swap = MyList[Index1];
    MyList[Index1] = MyList[Index2];
    MyList[Index2] = Swap;
  }

  private static void PrettyPrint(List<int> MyList) {
    Console.Write("{");
    for(int i = 0; i < MyList.Count - 1; i++) {
      Console.Write(MyList[i] + ", ");
    }
    Console.WriteLine(MyList[MyList.Count-1] + "}");
  }
}