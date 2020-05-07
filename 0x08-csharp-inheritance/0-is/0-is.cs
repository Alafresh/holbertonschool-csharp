using System;

/// <summary>Class obj</summary>
class Obj
{
    /// <summary>Method that returns true if the object is an int</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        else
            return false;
    }
}
