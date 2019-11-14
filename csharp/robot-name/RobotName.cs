using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{

    // Possibilité de random sur une regex ?

    public Random random = new Random();
    public HashSet<string> usedNames = new HashSet<string>();
    public string Name { get; private set; } = null;

    public Robot()
    {
        UpdateName();
    }

    public string BeginningName()
    {
        string beginningName = new StringBuilder()
                            .Append(((char)('A' + random.Next(0, 25))).ToString())
                            .Append(((char)('A' + random.Next(0, 25))).ToString())
                            .ToString();

        return beginningName;
    }

    public string EndingName()
    {
        string endingName = new StringBuilder()
                            .Append(random.Next(0, 9).ToString())
                            .Append(random.Next(0, 9).ToString())
                            .Append(random.Next(0, 9).ToString())
                            .ToString();

        return endingName;
    }

    public void UpdateName()
    {
        var name = new StringBuilder().Append(BeginningName()).Append(EndingName()).ToString();

        while (usedNames.Contains(name))
        {
            name = new StringBuilder()
                .Append(BeginningName())
                .Append(EndingName())
                .ToString();
        }

        Name = name;
        usedNames.Add(Name);
    }

    public void Reset()
    {
        UpdateName();
    }
}