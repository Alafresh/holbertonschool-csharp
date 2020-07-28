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
    bool isCollected {get; set;}
    void Collect();
}
/// <summary>New class Door</summary>
class Door : Base, IInteractive
{
    public Door(string value = "Door")
    {
        name = value;
    }
    public void Interact()
    {
        Console.WriteLine("You try to open the " + name + ". It's locked.");
    }
}

/// <summary>New class Decoration</summary>
class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;

    public int durability { get; set; }
    public Decoration(string n = "Decoration", int d = 1, bool isQ = false)
    {
        if (d < 0)
            throw new Exception("Durability must be greater than 0");
        name = n;
        durability = d;
        isQuestItem = isQ;
    }
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The " + name + " has been broken.");
        else if( isQuestItem == true)
            Console.WriteLine("You look at the " + name + ". There's a key inside.");
        else
            Console.WriteLine("You look at the " + name + ". Not much to see here.");
    }

    public void Break()
    {
        durability--;
        if ( durability > 0)
            Console.WriteLine("You hit the " + name + ". It cracks.");
        else if (durability == 0)
            Console.WriteLine("You smash the " + name + ". What a mess.");
        else
            Console.WriteLine("The " + name + " is already broken.");
    }
}