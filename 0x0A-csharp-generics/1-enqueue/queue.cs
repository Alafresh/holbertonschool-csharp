﻿using System;

/// <summary>Class Queue</summary>
public class Queue<T> 
{
    /// <summary>returns the Queue’s type.</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>public class node.</summary>
    public class Node
    {
        /// <summary>Next node</summary>
        public Node next = null;
        private T value = default(T);

        /// <summary>Constructor.</summary>
        public Node(T V)
        {
            this.value = V;
        }
    }
    /// <summary>Properties</summary>
    public Node head;
    public Node tail;
    public int count;
    
    /// <summary>Create a new node and add to the end of the queue</summary>
    public void Enqueue(T type)
    {
        Node newNode = new Node(type);
        if (head == null)
            head = newNode;
        else if (head == tail)
            head.next = newNode;
        else
        tail.next = newNode;
        tail = newNode;
        count++;
    }

    /// <summary>returns the number of nodes in the Queue.</summary>
    public int Count()
    {
        return(count);
    }
}