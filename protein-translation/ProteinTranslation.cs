using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    private static Dictionary<string, string[]> InitializeDictionary(){
        Dictionary<string,string[]> CodonDictionary = new Dictionary<string, string[]>{
            ["Methionine"] = new[]{"AUG"},
            ["Phenylalanine"] = new[]{"UUU", "UUC"},
            ["Leucine"] = new[]{"UUA", "UUG"},
            ["Serine"] = new[]{"UCU", "UCC", "UCA", "UCG"},
            ["Tyrosine"] = new[]{"UAU", "UAC"},
            ["Cysteine"] = new[]{"UGU", "UGC"},
            ["Tryptophan"] = new[]{"UGG"},
            ["STOP"] = new[]{"UAA", "UAG", "UGA"}
        };
        return CodonDictionary;
    }
    public static string[] Proteins(string strand)
    {
        List<string> PolypeptideChain = new List<string>();
        Dictionary<string, string[]> CodonDictionary = ProteinTranslation.InitializeDictionary();
        for (int i = 0; i < strand.Length; i += 3){
            string codon = strand[i..(i+3)];
            if (CodonDictionary["STOP"].Contains(codon))
                return PolypeptideChain.ToArray();
            foreach (KeyValuePair<string,string[]> pair in CodonDictionary){
                if (CodonDictionary[pair.Key].Contains(codon))
                    PolypeptideChain.Add(pair.Key);
            }
        }
        return PolypeptideChain.ToArray();
    }
}