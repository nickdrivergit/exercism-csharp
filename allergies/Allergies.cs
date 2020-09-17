using System;
using System.Collections.Generic;

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
    private int allergyScore;
    public Allergies(int mask)
    {
        allergyScore = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (allergyScore & (int)allergen) > 0;
    }

    public Allergen[] List()
    {
        var list = new List<Allergen>();
        for (int i = 0; i < 8; i++){
            int val = 1 << i;
            if ((allergyScore & val) > 0)
                list.Add((Allergen)val);
        }
        return list.ToArray();
    }
}