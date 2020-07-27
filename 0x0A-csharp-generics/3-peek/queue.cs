using System;

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
        /// <summary>data type</summary>
        public T value = default(T);

        /// <summary>Constructor.</summary>
        public Node(T V)
        {
            this.value = V;
        }
    }
    /// <summary>First Node</summary>
    public Node head;
    /// <summary>Last Node</summary>
    public Node tail;
    /// <summary>Number of Nodes</summary>
    public int count;
    
    /// <summary>Create a new node and add to the end of the queue</summary>
    public void Enqueue(T node)
    {
        Node newNode = new Node(node);
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

    /// <summary>removes the first node in the queue and returns its value</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }
        T tmpValue = head.value;
        Node tmpNode = head.next;
        head = tmpNode;
        count--;
        return (tmpValue);
    }

    /// <summary>returns the value of the first node of the queue</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }
         return(head.value);
    }
}