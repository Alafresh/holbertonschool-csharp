using System;

/// <summary>Abstract thinking</summary>
public class Player
{
    private string name;

    private float maxHp;
    private float hp;

    /// <summary>Constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            this.maxHp = 0f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.name = name;
        this.hp = this.maxHp;
    }
    /// <summary>HP status</summary>
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health.");
    }
}