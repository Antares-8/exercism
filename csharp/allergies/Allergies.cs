using System;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private int allergy { get; }

    public Allergies(int mask)
    {
        allergy = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (allergy & (int)allergen) > 0;
    }

    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen))
            .Cast<Allergen>()
            .Where(x => ((int)x & allergy) > 0)
            .ToArray();
    }
}