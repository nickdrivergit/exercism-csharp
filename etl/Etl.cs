using System;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> TransformedData = new Dictionary<string, int>();
        foreach (KeyValuePair<int, string[]> pair in old)
        {
            foreach (string letter in pair.Value)
            {
                TransformedData.Add(letter.ToLower(), pair.Key);
            }
        }
        return TransformedData;
    }
}