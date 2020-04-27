using System;
using System.Collections.Generic;

class List
{
  public static List<int> DifferentElements(List<int> list1, List<int> list2)
  {
    List<int> newList = new List<int>();
    foreach(int i in list1)
    {
      if (list2.Contains(i))
        continue;
      else
        newList.Add(i);
    }
    foreach(int i in list2)
    {
      if (list1.Contains(i))
        continue;
      else
        newList.Add(i);
    }
    newList.Sort();
    return newList;
  }
}