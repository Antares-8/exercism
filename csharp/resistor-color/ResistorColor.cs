using System;

public static class ResistorColor
{
    private static readonly string[] colors =
    {
        "black", 
        "brown",
        "red",
        "orange",
        "yellow",
        "green",
        "blue",
        "violet",
        "grey",
        "white"
    };

    public static int ColorCode(string color)
    {
        int index = Array.IndexOf(colors, color);
        return index;

        // throw new NotImplementedException("You need to implement this function.");
    }

    public static string[] Colors()
    {
        return (string[])colors.Clone();
        throw new NotImplementedException("You need to implement this function.");
    }
}