using System;
using System.Collections.Generic;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new System.ArgumentOutOfRangeException("Please enter a positive integer value.");
        HashSet<int> factors = new HashSet<int>();
        int factorSum = 0;
        for (int i = 1; i <= number/2; i++){
            if (number % i == 0)
                factors.Add(i);
        }
        foreach (int x in factors){
            factorSum += x;
        }
        if (factorSum < number)
            return Classification.Deficient;
        else if (factorSum == number)
            return Classification.Perfect;
        return Classification.Abundant; 
    }
}
