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
    delegate float CalculateHealth(float h);

    /// <summary>Damage status</summary>
    public void TakeDamage(float damage)
    {
        Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        if (damage < 0)
            damage = 0f;
      
        this.hp -= damage;
    }

    /// <summary>Heal status</summary>
    public void HealDamage(float heal)
    {
        Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        if (heal < 0)
            heal = 0f;
       
        this.hp += heal;
    }
}