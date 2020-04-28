using System;
using System.Collections.Generic;
using System.Linq;
class LList
{
  public static int GetNode(LinkedList<int> myLList, int n)
  {
    int count = 0;
    foreach(int i in myLList)
    {
      if (count == n)
        return i;
      count += 1;
    }
    return 0;
  }
}