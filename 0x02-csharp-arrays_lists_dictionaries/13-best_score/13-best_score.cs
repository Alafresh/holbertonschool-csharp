using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
            return "None";
        int max = myList.Values.Max();
        foreach (string key in myList.Keys)
        {
            if (myList[key] == max)
                return key;
        }
        return "None";
    }
}
