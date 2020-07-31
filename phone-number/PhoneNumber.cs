using System;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string cleanNumber = new string(phoneNumber.Where(Char.IsDigit).ToArray());
        if (cleanNumber[0] == '1')
            cleanNumber = cleanNumber.Substring(1);
        if (cleanNumber.Length == 10 && cleanNumber[0] > '1' && cleanNumber[3] > '1')
            return cleanNumber;
        throw new System.ArgumentException("Not a valid number.");
    }
}