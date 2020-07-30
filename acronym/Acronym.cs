using System;
using System.Collections.Generic;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        List<char> TLA = new List<char>();
        char[] upperPhrase = phrase.ToUpper().ToCharArray();
        for (int i = 0; i < upperPhrase.Length; i++){
            if (i == 0 && (int)upperPhrase[i] >= 'A' && (int)upperPhrase[i] <= 'Z'){
                TLA.Add(upperPhrase[0]);
            }
            else if ((int)upperPhrase[i] >= 'A' && (int)upperPhrase[i] <= 'Z' && ((int)upperPhrase[i-1] == ' ' || (int)upperPhrase[i-1] == '-' || (int)upperPhrase[i-1] == '_')){
                TLA.Add(upperPhrase[i]);
            }
        }
        return new string(TLA.ToArray());
    }
}