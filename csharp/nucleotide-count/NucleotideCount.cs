using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    private static char[] Nucleotides =
    {
        'A',
        'C',
        'G',
        'T'
    };

    public static IDictionary<char, int> Count(string sequence)
    {

        Dictionary<char, int> NucCount = new Dictionary<char, int>();

        foreach (char nucleotide in Nucleotides)
        
            NucCount.Add(nucleotide, 0);

        foreach(char nucleotide in sequence)
        {
            if (!NucCount.ContainsKey(nucleotide))
            {
                throw new ArgumentException();
            }
            else
            {
                NucCount[nucleotide] = NucCount[nucleotide] + 1;
            }
        }

            return NucCount;
        

        throw new NotImplementedException("You need to implement this function.");
    }
}