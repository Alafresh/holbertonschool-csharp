﻿using System;

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
    bool isCollected {get; set;}
    void Collect();
}
/// <summary>New class Test</summary>
class TestObject : Base, IInteractive , IBreakable, ICollectable
{
    public int durability {get; set;}
    public bool isCollected {get; set;}
    public void Interact()
    {

    }
    public void Break()
    {

    }
    public void Collect()
    {

    }
}