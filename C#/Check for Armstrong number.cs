using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsArmstrong(153));
    }

    static bool IsArmstrong(int num)
    {
        int originalNum, remainder, result = 0;
        originalNum = num;

        while (originalNum != 0)
        {
            remainder = originalNum % 10;
            result += remainder * remainder * remainder;
            originalNum /= 10;
        }

        if(result == num)
            return true;
        else
            return false;
    }
}
