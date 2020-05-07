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
    /// <summary>Return the area of a Rectangle</summary>
    public new int Area()
    {
        return height * width;
    }
    /// <summary>Return the measurement of a rectangle</summary>
    public override string ToString()
    {
        return "[Rectangle] " + width + " / " + height;
    }
}
/// <summary>derived class from Rectangle</summary>
class Square : Rectangle
{
    private int size;
    private int height;
    private int width;
    /// <summary>Set and Get size property</summary>
    public int Size
    {
        get => size;
        set
        {
             if (value < 0)
                throw new ArgumentException("size must be greater than or equal to 0");
            else
            {
                this.size = value;
                this.width = value;
                this.height = value;
            }
        }
    }
}