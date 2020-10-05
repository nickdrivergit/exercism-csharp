using System;

public static class Triangle
{
    public static bool CheckViolation(double side1, double side2, double side3){
        return (side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2 ? true : false);
    }
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (side1 == 0 || side2 == 0 || side3 == 0 || CheckViolation(side1, side2, side3) == false)
            return false;
        return (side1 != side2 && side2 != side3 && side3 != side1 ? true : false);
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if (side1 == 0 || side2 == 0 || side3 == 0 || CheckViolation(side1, side2, side3) == false)
            return false;
        return (side1 == side2 || side1 == side3 || side2 == side3 ? true : false);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if (side1 == 0 || side2 == 0 || side3 == 0 || CheckViolation(side1, side2, side3) == false)
            return false;
        return (side1 == side2 && side1 == side3 ? true : false);
    }
}