using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        var _char = new List<string>();
        int end = numbers.Length - sliceLength;

        if (sliceLength < 0 || sliceLength == 0)
        {
            throw new ArgumentException($"La valeur { sliceLength } doit être positive.");
        }

        if (sliceLength > numbers.Length)
        {
            throw new ArgumentException($"La valeur { sliceLength } est trop grande : elle doit être plus petite que { numbers.Length }");
        }

        for (int i = 0; i <= end; i++)
        {
            _char.Add(numbers.Substring(i, sliceLength));
        }
        return _char.ToArray();

    }
}