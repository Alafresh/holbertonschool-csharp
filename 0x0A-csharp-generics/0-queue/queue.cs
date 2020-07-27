using System;

/// <summary>Class Queue</summary>
class Queue<T> 
{
    /// <summary>returns the Queue’s type.</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}