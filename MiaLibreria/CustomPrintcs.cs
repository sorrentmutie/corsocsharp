namespace MiaLibreria;

public class CustomPrints
{
    private readonly string name = string.Empty;

    public void Print()
    {
        Console.WriteLine("Stampa da Print()");
    }

    public string GetName()
    {
        return name;
    }

    public void PrintName()
    {
        Console.WriteLine($"Nome impostato a {name}");
    }

    public void Print( string name )
    {
        Console.WriteLine($"Stampastringa passata {name}");
    }

    private void PrivatePrint()
    {
        Console.WriteLine("Stampa da metodo privato");
    }

    public string Name => name;
    public static string StaticName => "Static Property";


}
