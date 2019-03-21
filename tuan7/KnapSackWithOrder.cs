using System;
using System.Collections.Generic;

public class NormalSack
{
  private static int Cap = 10;
  private static int CurrentCap = 10;
  private static List<int> Cost = new List<int> {4,5,3,2,4};
  private static List<int> Weight = new List<int> {4,6,9,2,3};

  public static void Main () {
    Greedy();
  }

  public static void Greedy() {
      for(int i = 0; i < ItemList.Count; i++) {
        if(CurrentCap - Weight[i] > 0) {
          CurrentCap -= Weight[i];
          Sack.Add(ItemList[i]);
        }
      } 
    }

  private static void Sort() {
    for(int i = 0; i < Cost.Count; i ++) {
      int k = i;
      for(int j = i; j < Cost.Count; j ++) {
        if(EvalAt(j) < EvalAt(k)) k = j;
      }
      if (k != i) Swap(i,k);
    }
  }

  private static double EvalAt(int i) {
    return 1.0*Weight[i] / Cost[i];
  }

  private static void Swap(int j, int i) {
    int tmp;
    tmp = Cost[i]; Cost[i] = Cost[j]; Cost[j] = tmp;
    tmp = Weight[i]; Weight[i] = Weight[j]; Weight[j] = tmp;
  }
}

