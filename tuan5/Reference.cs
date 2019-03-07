using System;

class DemoReference 
{
  public static void Main () {
    int SomeRandomVar = 0;
    Console.WriteLine("Old value: " + SomeRandomVar);
    PassByVal(SomeRandomVar);
    Console.WriteLine("Value after passing by value: " + SomeRandomVar);
    PassByRef(ref SomeRandomVar);
    Console.WriteLine("Value after passing by reference: " + SomeRandomVar);
  }

  private static void PassByRef(ref int MyRef) {
    MyRef += 10;
  }

  private static void PassByVal(int MyVal) {
    MyVal += 10;
  }
}