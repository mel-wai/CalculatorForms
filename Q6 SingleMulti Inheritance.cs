using System;

public class BCA
{
    public void Identify()
    {
        Console.WriteLine("I am a Student.");
    }
}

// Class MyFriend inherits from Person (Single Inheritance)
public class Subject : BCA
{
    public void SubA()
    {
        Console.WriteLine("This is .Net programming");
    }

    public void SubB()
    {
        Console.WriteLine("This is Visual Studio");
    }
}

// Class Me inherits from MyFriend (Single Inheritance) and implements multiple interfaces
public class MainSub : Subject
{
    public void SubA()
    {
        Console.WriteLine("Hello Everyone!");
    }

    public void SubB()
    {
        Console.WriteLine("Let's do our Assignment.");
    }

    public void SubC()
    {
        Console.WriteLine("Assignment Start.");
    }
}

class Program
{
    public static void Main()
    {
        Subject obj1 = new Subject();
        obj1.Identify();
        obj1.SubA();
        obj1.SubB();

        MainSub obj2 = new MainSub();
        obj2.Identify();
        obj2.SubA();
        obj2.SubB();
        obj2.SubC();

        Console.ReadLine();
    }
}
