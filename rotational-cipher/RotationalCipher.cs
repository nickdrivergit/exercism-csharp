using System;
using System.Text;


public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder encryptedString = new StringBuilder("");
        foreach (char c in text){
            int asciiValue = (int)c;
            if (asciiValue >= 'A' && asciiValue <= 'Z')
                asciiValue = 'A' + (((asciiValue - 'A') + shiftKey) % 26);
            if (asciiValue >= 'a' && asciiValue <= 'z')
                asciiValue = 'a' + (((asciiValue - 'a') + shiftKey) % 26);
            encryptedString.Append((char)asciiValue);
        }
        return encryptedString.ToString();
    }
}