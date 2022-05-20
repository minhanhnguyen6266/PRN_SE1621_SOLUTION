using System;
namespace Fptedu.Prn1621;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"========================");
        int a = 10, b = 20; //arguments
        //Console.WriteLine("Total of a = {0} and b = {1} is {2}", a, b, Sum(a, b)");
        Console.WriteLine($"Total of a = {a} and b = {b} is: {Sum(a,b)}"); // String Interpolation
        Console.ReadLine();
    }

    // manual method: parameters
    public static int Sum(int x, int y)
    {
        return x + y;
    }
}



