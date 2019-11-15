using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    private Random _random = new Random();
    private static HashSet<string> UsedNames = new HashSet<string>();
    public string Name { get; private set; } = null;

    public Robot()
    {
        SetName();
    }

    private string GetBeginningName()
    {
        string beginningName;

        beginningName = new StringBuilder()
                    .Append(((char)('A' + _random.Next(0, 25))).ToString())
                    .Append(((char)('A' + _random.Next(0, 25))).ToString())
                    .ToString();

        return beginningName;
    }

    private string GetEndingName()
    {
        string endingName;

        endingName = new StringBuilder()
                    .Append(_random.Next(0, 9).ToString())
                    .Append(_random.Next(0, 9).ToString())
                    .Append(_random.Next(0, 9).ToString())
                    .ToString();

        return endingName;
    }

    public void Reset()
    {
        SetName();
    }

    private void SetName()
    {
        var name = new StringBuilder()
                .Append(GetBeginningName())
                .Append(GetEndingName())
                .ToString();

        while (UsedNames.Contains(name))
        {
            name = new StringBuilder()
                .Append(GetBeginningName())
                .Append(GetEndingName())
                .ToString();
        }

        Name = name;
        UsedNames.Add(Name);
    }
}