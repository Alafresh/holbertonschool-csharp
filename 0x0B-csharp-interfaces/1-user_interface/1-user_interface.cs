using System;

/// <summary>Abstract thinking</summary>
abstract class Base
{
    /// <summary>Property</summary>
    public string name = "";

    /// <summary>Return the type</summary>
    public override string ToString()
    {
        return name + " is a " + GetType();
    }
}

interface IInteractive
{
    void Interact()
    {

    }
}
interface IBreakable
{
    int durability { get; set;}
    void Break()
    {

    }
}

interface ICollectable
{
    bool isCollected {set; get;}
    void Collect()
    {

    }
}

class TestObject : IInteractive , IBreakable, ICollectable
{
    public int durability {get; set;}
    public bool isCollected {set; get;}
}