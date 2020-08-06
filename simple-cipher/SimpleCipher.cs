using System;

public class SimpleCipher
{
    public SimpleCipher()
    {
        string key = "";
        Random rand = new Random();
        for(int i = 0;i<100;++i)
            key += (char)rand.Next('a', 'z');
        Key = key;
    }

    public SimpleCipher(string key)
    {
        Key = key;
    }
    
    public string Key { get; }

    public string Encode(string plaintext)
    {
        string output = "";
        int cipherIndex = 0;
        int textIndex = 0;
        foreach (char c in plaintext){
            output += EncodeRotate(plaintext[textIndex], Key[cipherIndex]);
            textIndex++;
            cipherIndex++;
            if (cipherIndex == Key.Length)
                cipherIndex = 0;
        }
        return output;
    }

    public string Decode(string ciphertext)
    {
        string output = "";
        int cipherIndex = 0;
        int textIndex = 0;
        foreach (char c in ciphertext){
            output += DecodeRotate(ciphertext[textIndex], Key[cipherIndex]);
            textIndex++;
            cipherIndex++;
            if (cipherIndex == Key.Length)
                cipherIndex = 0;
        }
        return output;
    }

    public static char EncodeRotate(char c, char n)
    {
        int rotate = (int)n - 'a';
        int cAscii = (int)c;
        cAscii = 'a' + (((cAscii - 'a') + rotate) % 26);
        return (char)cAscii;
    }

    public static char DecodeRotate(char c, char n)
    {
        int rotate = (int)n - 'a';
        int cAscii = (int)c;
        cAscii = 'a' + (((cAscii - 'a') - rotate) % 26);
        if (cAscii < 'a')
            cAscii += 26;
        return (char)cAscii;
    }
}