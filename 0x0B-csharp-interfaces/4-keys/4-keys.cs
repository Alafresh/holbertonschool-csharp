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
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
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
/// <summary>New class Key</summary>
class Key : Base, ICollectable
{
    public bool isCollected {get; set;}

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    public void Collect()
    {
        if (this.isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the " + name+ ".");
        }
        else if (this.isCollected == true)
            Console.WriteLine("You have already picked up the " + name + ".");
    }
}