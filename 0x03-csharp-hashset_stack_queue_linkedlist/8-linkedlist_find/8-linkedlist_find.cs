using System;
using System.Collections.Generic;

class LList
{
  public static int FindNode(LinkedList<int> myLList, int value)
  {
    int count = 0;
    foreach(int i in myLList)
    {
      count += 1;
      if (value == i)
        return count - 1;
    }
    return -1;
  }
}