using System;

public static class ResistorColor
{
    public static int ColorCode(string color) => Array.IndexOf(Colors(), color);
    // {
    //     string[] resistorColors = new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    //     for (int i = 0; i < resistorColors.Length; i++){
    //         if (resistorColors[i] == color)
    //             return i;
    //     }
    //     return 9999;
    // }

    public static string[] Colors()
    {
        return new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    }
}