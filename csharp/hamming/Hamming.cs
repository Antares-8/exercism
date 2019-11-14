using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException();

        return Enumerable.Range(0, firstStrand.Length)
            .Aggregate(0, (account, position) =>
                firstStrand[position].Equals(secondStrand[position]) ? account : (account + 1)
            );
    }
}