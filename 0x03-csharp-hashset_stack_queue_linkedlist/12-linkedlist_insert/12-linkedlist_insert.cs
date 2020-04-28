using System;
using System.Collections.Generic;

class LList
{
  public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
  {
    LinkedListNode<int> current = myLList.First;
    LinkedListNode<int> newNode;
    while (current != null)
    {
      if (current.Value > n)
      {
        newNode = myLList.AddBefore(current, n);
        return newNode;
      }
      current = current.Next;
    }
    newNode = myLList.AddLast(n);
    return newNode;
  }
}