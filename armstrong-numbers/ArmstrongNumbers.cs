using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string numString = number.ToString();
        int numLength = numString.Length;
        int digit = 0;
        double armstongNum = 0;
        if (number == 0)
            return true;
        for (int i = 0; i < numLength; i++){
            digit = (int)numString[i] - '0';
            armstongNum += Math.Pow(digit, numLength);
        }
        return (number == armstongNum ? true : false);
    }
}