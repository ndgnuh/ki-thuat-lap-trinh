using System;
using System.Collections.Generic;
using System.Linq;

public class DuplicateFinder
{
	public static List<int> TheList = new List<int> {1,3,3,4,2,3,3,4,4,2};
	public static void Main()
	{
		Console.Clear();

		Console.WriteLine("List before filtering");
		PrettyPrint(TheList);

		Console.WriteLine("List after filtering");
		PrettyPrint(RemoveDuplicate(TheList));
	}

	public static void PrettyPrint(List<int> TheList, int pad = 4)
	{
		for(int i = 0; i < TheList.Count; i++)
		{
			Console.Write(Convert.ToString(i).PadLeft(pad));
		}
		Console.WriteLine();

		for(int i = 0; i < TheList.Count; i++)
		{
			Console.Write(Convert.ToString(TheList[i]).PadLeft(pad));
		}
		Console.WriteLine();
	}

	public static List<int> RemoveDuplicate(List<int> OldList)
	{
		List<int> NewList = OldList.ToList();
		List<int> DuplicateIndex = new List<int>();
		int count = 0;

		for(int i = 0; i < NewList.Count; i ++)
			for(int j = i+1; j < NewList.Count; j++)
				if(NewList[j] == NewList[i])
				{
					NewList.RemoveAt(j);
					j -= 1;
				}
		
		return NewList;
	}
}
