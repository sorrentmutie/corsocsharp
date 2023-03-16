namespace MiaLibreria;

public class CustomPrint
{
    private readonly string name = string.Empty;

    public void Print() 
    {
        Console.WriteLine("Printing from Print()");
    }

    public string GetName()
    {
        return name;
    }

    public void PrintName()
    {
        Console.WriteLine($"Name set as {name}");
    }

    public void Print(string name )
    {
        Console.WriteLine($"Name passed: {name}");
    }

    private void PrintPrivate()
    {
        Console.WriteLine($"Printing from Private");
    }

    public string Name => name;
    public static string StaticName => "Static Property Name";
}
