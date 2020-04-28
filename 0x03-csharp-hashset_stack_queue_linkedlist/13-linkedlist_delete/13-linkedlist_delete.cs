using System;
using System.Collections.Generic;

class LList
{
  public static void Delete(LinkedList<int> myLList, int index)
  {
    int count = 0;
    LinkedListNode<int> current = myLList.First;
    while (current != null)
    {
      if (count == index)
      {
        myLList.Remove(current);
        break;
      }
      count++;
      current = current.Next;
    }
  }
}