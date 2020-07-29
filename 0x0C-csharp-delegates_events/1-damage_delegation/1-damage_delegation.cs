using System;

delegate float CalculateHealth(float h);

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
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }
    /// <summary>HP status</summary>
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }

    /// <summary>Damage status</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine(this.name + " takes 0 damage!");
            damage = 0f;
        }
        else 
        {  
            Console.WriteLine(this.name + " takes " + damage + " damage!");
            this.hp -= damage;
        }
    }

    /// <summary>Heal status</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine(this.name + " heals 0 damage!");
            heal = 0f;
        }
        else
        {
            Console.WriteLine(this.name + " heals " + heal + " HP!");
            this.hp += heal;
        }
    }
}