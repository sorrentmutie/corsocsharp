using System.Net.Sockets;

namespace DemoCorsoCSharp;

public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public Address Address { get; set; } = new Address();
}

public class PersonDTO
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? FullAddress { get; set; }

    public override string ToString()
    {
        return $"{FullName}: {FullAddress}";
    }
}
