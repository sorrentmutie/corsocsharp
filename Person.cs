namespace DemoCorsoCSharp;

public class Person
{
    private int age;

    internal Person(int age)
    {
        this.age = age;
    }

    private int GetAge()
    {
        return age;
    }

    private void SetAge(int age)
    {
        this.age = age;
    }

}
