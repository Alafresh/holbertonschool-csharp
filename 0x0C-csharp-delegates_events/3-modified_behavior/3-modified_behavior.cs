using System;


/// <summary>Public enum</summary>
public enum Modifier
{
    /// <summary>return half of the base value</summary>
    Weak,
    /// <summary> return the base value</summary>
    Base,
    /// <summary> return 1.5 times the base value</summary>
    Strong
}

/// <summary>delegate CalculateModifier</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
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
        float newHp;
        if (damage < 0)
        {
            Console.WriteLine(this.name + " takes 0 damage!");
            damage = 0f;
        }
        else
            Console.WriteLine(this.name + " takes " + damage + " damage!");
        newHp = this.hp - damage;
        ValidateHP(newHp);
    }

    /// <summary>Heal status</summary>
    public void HealDamage(float heal)
    {
        float newHp;
        if (heal < 0)
        {
            Console.WriteLine(this.name + " heals 0 HP!");
            heal = 0f;
        }
        else
            Console.WriteLine(this.name + " heals " + heal + " HP!");
        newHp = this.hp + heal;
        ValidateHP(newHp);
    }
    /// <summary> sets the new value of the Player’s hp</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
            this.hp = 0f;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }
    /// <summary> CalculateModifier</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier ==  Modifier.Weak)
            return baseValue / 2;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }
}