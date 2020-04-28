using System;
using System.Collections.Generic;

class LList
{
  public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
  {
    LinkedListNode<int> current = myLList.First;
    LinkedListNode<int> newNode = new LinkedListNode<int>(n);
    while (current != null)
    {
      if (current.Value <= n)
        current = current.Next;
      else
      {
        newNode = myLList.Find(current.Value);
        myLList.AddBefore(newNode, n);
        break;
      }
    }
    return newNode;
  }
}