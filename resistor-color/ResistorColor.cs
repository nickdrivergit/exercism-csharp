using System;

public static class ResistorColor
{
    private static string[] ResistorColors = new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color) => Array.IndexOf(Colors(), color);

    public static string[] Colors() => ResistorColors;
}