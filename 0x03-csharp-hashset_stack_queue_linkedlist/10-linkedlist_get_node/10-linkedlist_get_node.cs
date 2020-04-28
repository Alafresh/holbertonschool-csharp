using System;
using System.Collections.Generic;
using System.Linq;
class LList
{
  public static int GetNode(LinkedList<int> myLList, int n)
  {
    if (myLList.Count - 1 > n || myLList.Count <= 0)
      return 0;
    return myLList.ElementAt(n);
  }
}