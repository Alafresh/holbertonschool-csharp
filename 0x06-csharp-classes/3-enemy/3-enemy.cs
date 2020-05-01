using System;

namespace Enemies
{
  
/// <summary>Create an empty public class Zombie wit </summary>
  public class Zombie
  {
    /// <summary>Represent the Health of enemie</summary>
    public int health;
    /// <summary>Constructor</summary>
    public Zombie()
    {
      health = 0;
    }
    /// <summary>Constructor the set the value to Health property</summary>
    public Zombie(int value)
    {
      if (value >= 0)
        health = value;
      else
        throw new ArgumentException("Health must be greater than or equal to 0");
    }
    /// <summary>returns the value of health zombie object</summary>
    public int GetHealth()
    {
      return health;
    }
  }
}