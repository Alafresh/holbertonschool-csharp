using System;
using System.Collections.Generic;
class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        bool flag = true;
        foreach(KeyValuePair<string, string> entry in myDict)
        {
            if(key == entry.Key)
            {
                myDict[key] = value;
                flag = false;
                break;
            }
        }
        if(flag)
            myDict.Add(key, value);

        return myDict;
    }
}
