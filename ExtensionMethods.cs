using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace DemoCorsoCSharp;

public static class ExtensionMethods
{
    public static List<Person> DoSomething (this List<Person> input,
        Func<string, string> f1, Func<string, string> f2, string param)
    {
        var list = new List<Person>();
        foreach (Person person in input)
        {
           if( f1(person.Name).Contains(param)) {

            }
        }
        return list;
    }

    public static List<int> Double(this List<int> listaInput)
    {
        var listaOutput = new List<int>();

        foreach (var numero in listaInput) { 
            listaOutput.Add(numero * 2);
        }
        return listaOutput;
    }


    public static int SommaElementiPari(this List<int> listaInput)
    {
        var somma = 0;
        foreach (var numero in listaInput)
        {
            somma += numero;
        }
        return somma;
    }

    public static int SommaElementiPariConParametro(this List<int> listaInput, int param)
    {
        var somma = 0;
        foreach (var numero in listaInput)
        {
            if(numero >= param)
            {
                somma += numero;
            }
        }
        return somma;
    }
}
