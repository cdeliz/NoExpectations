using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDictionary : MonoBehaviour {

    private Dictionary<string, string> TextDict = new Dictionary<string, string>();

    public void Set(string key, string value)
    {
        if (TextDict.ContainsKey(key))
        {
            TextDict[key] = value;
        }
        else
        {
            TextDict.Add(key, value);
        }
    }

    public string Get(string key)
    {
        string result = null;

        if (TextDict.ContainsKey(key))
        {
            result = TextDict[key];
        }

        return result;
    }
}
