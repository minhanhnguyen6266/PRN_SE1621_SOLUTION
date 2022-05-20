
namespace PRN.SE1621.DEFAULT_INTERFACE;

using static System.Console;
using System.Collections;
/*default interface*/
public interface ISample
{
    static void Print()
    {
        Console.WriteLine($"Hello .NET C# 10");    
    }

    string  GetString(string s)
    {
        return "Welcome " + s;
    }

    void Display(); 
}

public interface ISecond
{
    string GetString(string s)
    {
        return "Goodmorning " + s;
    }
}

public class MySecond : ISecond
{

}

public class MySample : ISample
{
    public void Display()
    {
        WriteLine($"Hi !");
    }
}

public class MyClass
{
    public static int x = 1;
    static MyClass()
    {
        x = 2;
        Console.WriteLine($"Static constructor {x}");
    }

    public MyClass()
    {
        x++;
        Console.WriteLine($"Public constructor {x}");
    }
}


public class Program
{
    public static void Main()
    {
        /*
        MySample obj = new MySample(); //instance
        obj.Display();

        ISample.Print();
        // polymorphism
        ISample s = obj;
        String str = s.GetString("Dong");

        WriteLine(str); 
        s.Display();
        */

        MyClass m1 = new MyClass();
        MyClass.x = 4;
        MyClass m2 = new MyClass();
        
        
        ReadLine();
    }
}
