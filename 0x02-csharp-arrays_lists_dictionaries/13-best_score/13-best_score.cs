using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = myList.Values.Max();
        foreach (string key in myList.Keys)
        {
            if (myList[key] == max)
                return key;
        }
        return "None";
    }
}
