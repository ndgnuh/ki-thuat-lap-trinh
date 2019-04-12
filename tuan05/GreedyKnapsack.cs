using System;
using System.Collections.Generic;
using System.Linq;

class KnapsackGreedySolver 
{
  private static List<int> Weight = new List<int> {9,1,3,4,5,6,2,7,10,12};
  private static int MaxWeight = 15;

  public static void Main() {
    Weight.Sort();
    BestIn();
    WorstOut();
  }

  private static void BestIn() {
    List<int> Obj = new List<int> {};
    int CurrentWeight = 0, CurrentIndex = 0;
    while(CurrentWeight + Weight[CurrentIndex] <= MaxWeight){
      Obj.Add(Weight[CurrentIndex]);
      CurrentWeight += Weight[CurrentIndex];
      CurrentIndex ++;
    }
    Console.WriteLine("Objects (by weight) to put in the bag using Best-in greedy alg:");
    Obj.ForEach(w => {
      Console.Write(w+",");
    });
    Console.WriteLine("\nTotal Weight = " + CurrentWeight);
  }

  private static void WorstOut() {
    List<int> Obj = Weight.ToList();
    int CurrentWeight = 0, CurrentIndex = Weight.Count - 1;
    Obj.ForEach(w => CurrentWeight+=w);
    while(CurrentWeight > MaxWeight){
      CurrentWeight -= Weight[CurrentIndex];
      Obj.RemoveAt(CurrentIndex);
      CurrentIndex --;
    }
    Console.WriteLine("Objects (by weight) to put in the bag using Worst-out greedy alg:");
    Obj.ForEach(w => {
      Console.Write(w+",");
    });
    Console.WriteLine("\nTotal Weight = " + CurrentWeight);
  }
}