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

/// <summary>Interface Interactive</summary>
interface IInteractive
{
    void Interact();
}
/// <summary>Interface Breakable</summary>
interface IBreakable
{
    int durability { get; set;}
    void Break();
}
/// <summary>Interface Collectable</summary>
interface ICollectable
{
    bool isCollected {set; get;}
    void Collect();
}
/// <summary>New class Test</summary>
class TestObject : Base, IInteractive , IBreakable, ICollectable
{
    /// <summary>New class Test</summary>
    public int durability {get; set;}
    /// <summary>New class Test</summary>
    public bool isCollected {set; get;}
    /// <summary>New class Test</summary>
    public void Interact()
    {

    }
    /// <summary>New class Test</summary>
    public void Break()
    {

    }
    /// <summary>New class Test</summary>
    public void Collect()
    {

    }
}