using System;

/// <summary>Abstract thinking</summary>
abstract class Base
{
    public string name;

    /// <summary>Return the type</summary>
    public override string ToString()
    {
        return name + " is a " + GetType();
    }
}