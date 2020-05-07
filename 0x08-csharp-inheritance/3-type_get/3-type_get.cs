using System;
using System.Reflection;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>print methods and properties available of a obj</summary>
    public static void Print(object myObj)
    {
        Type t = myObj.GetType();
        MethodInfo[] methods = t.GetMethods();
        PropertyInfo[] properties = t.GetProperties();
        Console.WriteLine("{0} Properties:", t.Name);
        foreach(PropertyInfo property in properties)
        {
            Console.WriteLine(property.Name);
        }
        Console.WriteLine("{0} Methods:", t.Name);
        foreach(MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }   
    }
}