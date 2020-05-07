using System;

/// <summary>Base class Shape</summary>
class Shape
{
    /// <summary>method useless</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>derived class from shape</summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>Set and Get width property</summary>
    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    /// <summary>Set and Get height property</summary>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}