using BenchmarkDotNet.Attributes;

namespace DemoCorsoCSharp;

[MemoryDiagnoser(false)]
public  class ReflectionPerformancecs
{
    private readonly Person person = new Person(35);


    [Benchmark]
    public Person? Ctor()
    {
        var type = typeof(Person);

        var c = type.GetConstructor(BindingFlags.NonPublic, new[] { typeof(int?) });

        var p =  c?.Invoke(new object?[] { 37 });

        if(p != null)
        {
            return (Person)p;
        }
        return null;
    }

    [Benchmark]
    public Person? CtorCached()
    {
        var p = ctor?.Invoke(new object?[] { 37 });

        if (p != null)
        {
            return (Person)p;
        }
        return null;
    }


    private readonly MethodInfo? getAgeMethod =
        typeof(Person).GetMethod("GetAge", BindingFlags.NonPublic | BindingFlags.Instance);
    private readonly object?[] ageParams = { 36 };

    private readonly MethodInfo? setAgeMethod =
        typeof(Person).GetMethod("SetAge", BindingFlags.NonPublic | BindingFlags.Instance);

    private ConstructorInfo? ctor = typeof(Person)

        .GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, new[] { typeof(int?) });


    [Benchmark]
    public int GetAge()
    {
        var age = typeof(Person).GetMethod("GetAge", BindingFlags.NonPublic | BindingFlags.Instance)
             ?.Invoke(person, Array.Empty<object?>());

        if(age != null)
        {
            return (int)age;
        }
        return 0;
    }


    [Benchmark]
    public void SetAge()
    {
        typeof(Person).GetMethod("SetAge", BindingFlags.NonPublic | BindingFlags.Instance)
             ?.Invoke(person, new object?[] {36});
    }



    [Benchmark]
    public int GetAgeCached()
    {
        var age = getAgeMethod?.Invoke(person, Array.Empty<object?>());
        if (age != null)
        {
            return (int)age;
        }
        return 0;
    }

    [Benchmark]
    public void SetAgeCached()
    {
        setAgeMethod?.Invoke(person, ageParams);
    }
}
