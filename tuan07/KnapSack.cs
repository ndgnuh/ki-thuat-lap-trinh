using System;
using System.Collections.Generic;
using System.Linq; 

namespace KnapSackOOP {
  public class KnapSack 
  {
    public static int CurrentCap = 14;
    public static List<Item> ItemList = new List<Item> {};
    public static List<Item> Sack = new List<Item> {};

    public static void Main() {
      List<int> Weight = new List<int> {3,4,2,4,5};
      List<int> Cost = new List<int> {3,2,4,3,1};
      for(int i = 0; i < Weight.Count; i++) {
        ItemList.Add(new Item(i + 1, Weight[i], Cost[i]));
      }

      Console.WriteLine("List of items:");
      ShowItems(ItemList);

      Greedy();
      
      Console.WriteLine("List of items in the sack:");
      ShowItems(Sack);
    }

    public static void Greedy() {
      List<Item> SortedItemList = SortByEval(ItemList);
      for(int i = 0; i < SortedItemList.Count; i++) {
        if(CurrentCap - (SortedItemList[i].GetWeight()) > 0) {
          CurrentCap -= SortedItemList[i].GetWeight();
          Sack.Add(SortedItemList[i]);
        }
      } 
    }

    public static void ShowItems(List<Item> Items) {
      for(int i = 0; i < Items.Count; i++) {
        Console.WriteLine(Items[i].GetInfo());
      }
    }


    public static List<Item> SortByEval(List<Item> OrgItemList) {
      List<Item> ItemList = OrgItemList.ToList();
      for(int i = 0; i < ItemList.Count; i++) {
        int k = i;
        for(int j = i; j < ItemList.Count; j++) 
          if(ItemList[j].Eval() > ItemList[k].Eval()) 
            k = j;
        if(k != i) Swap(ItemList, i, k);
      }
      return ItemList;
    }

    private static void Swap(List<Item> ItemList, int i, int j) {
      Item tmp = ItemList[i];
      ItemList[i] = ItemList[j];
      ItemList[j] = tmp;
    }
  }

  public class Item
  { 
    private int Id; 
    private int Weight;
    private int Cost; 

    public Item(int Id, int Weight, int Cost) {
      this.Id = Id; this.Weight = Weight; this.Cost = Cost;
    }

    public string GetInfo() {
      return "Id: " + this.Id + ", Weight: " + this.Weight + ", Cost: " + this.Cost;
    }

    public int GetWeight() {
      return this.Weight;
    }

    public double Eval() { 
      return 1.0 * this.Weight / this.Cost; 
    }
  }
}