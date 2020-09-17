using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {

        Dictionary<char,int> nucleotides = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach(Char c in sequence)
        {
            if (!nucleotides.ContainsKey(c))
                throw new System.ArgumentException("Not a nucleotide symbol.");
            nucleotides[c]++;
        }
        return nucleotides;
    }
}