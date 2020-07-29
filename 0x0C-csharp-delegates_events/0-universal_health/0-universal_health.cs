using System;

/// <summary>Abstract thinking</summary>
public class Player
{
    /// <summary>Constructor</summary>
    protected string name;
    /// <summary>Constructor</summary>
    protected float maxHp;
    /// <summary>Constructor</summary>
    protected float hp;

    /// <summary>Constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp < 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }
    /// <summary>HP status</summary>
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }
}