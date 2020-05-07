using System;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>check is a subclass of baseType</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if(derivedType.IsSubclassOf(baseType))
            return true;
        else
            return false;
    }
}