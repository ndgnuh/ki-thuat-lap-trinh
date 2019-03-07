using System;
using System.Collections.Generic;

class DemoReference 
{
  public static void Main () {
    int SomeRandomVar = 0;
    List<int> RandomList = new List<int> {1,2,3};

    Console.WriteLine("Old value: " + SomeRandomVar);
    PassByVal(SomeRandomVar);
    Console.WriteLine("Value after passing by value: " + SomeRandomVar);
    PassByRef(ref SomeRandomVar);
    Console.WriteLine("Value after passing by reference: " + SomeRandomVar);

    Console.WriteLine("\nList are passed as reference: \n\tOld List:");
    RandomList.ForEach(Console.WriteLine);
    Console.WriteLine("\tNew List:");
    PassList(RandomList);
    RandomList.ForEach(Console.WriteLine);


  }

  private static void PassByRef(ref int MyRef) {
    MyRef += 10;
  }

  private static void PassByVal(int MyVal) {
    MyVal += 10;
  }

  private static void PassList(List<int> MyList) {
    MyList.Add(4);
  }
}