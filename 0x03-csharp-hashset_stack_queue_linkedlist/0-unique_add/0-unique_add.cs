using System;
using System.Collections.Generic;
using System.Linq;

class List
{
  public static int Sum(List<int> myList)
  {
    List<int> uniqueValues = myList.Distinct().ToList();
    int sum = 0;
    foreach (int value in uniqueValues)
    {
      sum += value;
    }
    return sum;
  }
}