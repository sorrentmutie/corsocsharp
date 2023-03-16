// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Reflection;

Console.WriteLine("Hello, World!");

var assembly = Assembly.LoadFrom("E:\\corsi\\csharp\\corsocsharp\\MiaLibreria\\bin\\Debug\\net7.0\\MiaLibreria.dll");

foreach( var type in assembly.GetExportedTypes())
{
    Console.WriteLine($"Type: {type.Name}");

    var instance = Activator.CreateInstance(type);  


    Console.WriteLine("============");
    foreach(var field in  type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
    {
        Console.WriteLine($"Field: {field.Name}");
        field.SetValue(instance, "Mario Rossi");
    }
    Console.WriteLine("Methods ==========");

    foreach( var method in 
        type.GetMethods()
        .Where(m => !m.IsSpecialName && !m.IsVirtual))
    {
        Console.WriteLine($"Method: {method.Name}");

        if (method.GetParameters().Length > 0)
        {
            method.Invoke(instance, new[] { "Luigi Bianchi" });
        }
        else if(method.ReturnType.Name != "Void" && method.ReturnType.Name != "Type") 
        {
            var returnedValue = method.Invoke(instance, null);
            Console.WriteLine( $"Returned Value: {returnedValue}");
        }
        
        else
        {
            method.Invoke(instance, null);
        } 

    }
    Console.WriteLine("Properties ============");
    foreach ( var property in type.GetProperties())
    {
        Console.WriteLine($"{property.Name}");
        var propertyValue = property.GetValue(instance);
        Console.WriteLine($"Property Value: {propertyValue}");
    }

}