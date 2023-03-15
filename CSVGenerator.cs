using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DemoCorsoCSharp;

public class CSVGenerator<T>
{
    private readonly IEnumerable<T> data;
    private readonly string fileName;
    private Type type;

    public CSVGenerator(IEnumerable<T> data, string fileName)
    {
        this.data = data;
        this.fileName = fileName;
        type = typeof(T);
    }

    public void Generate()
    {
        var rows = new List<string>
        {
            CreateHeader()
        };

        foreach (var item in data)
        {
           rows.Add(CreateRow(item));
        }

        File.WriteAllLines($"{fileName}.csv", rows, System.Text.Encoding.UTF8);
    }

    private string CreateHeader()
    {
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        var orderedProperties = properties.OrderBy(p => p.GetCustomAttribute<ReportItemAttribute>()?.ColumnOrder);


        var header = new StringBuilder();
        foreach (var property in orderedProperties)
        {
            var attr = property.GetCustomAttribute<ReportItemAttribute>();
            header.Append( attr?.Heading ?? property.Name).Append(";");
        }


        return header.ToString()[..^1];
    }

    private string CreateRow(T item)
    {
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        var orderedProperties = properties.OrderBy(p => p.GetCustomAttribute<ReportItemAttribute>()?.ColumnOrder);


        var book = new StringBuilder();

        foreach (var prop in properties)
        {
           var x = (dynamic?)prop.GetValue(item);

            // book.Append(
            //    CreateItem((dynamic?)prop.GetValue(item))).Append(";");
            book.Append(CreateItem(prop, item)).Append(";");
        }


        return book.ToString()[..^1];
    }


   // private string? CreateItem(object item) => item.ToString();
   // private string CreateItem(DateTime item) => item.ToShortDateString();

    private string CreateItem(PropertyInfo prop, T item)
    {
        var attr = prop.GetCustomAttribute<ReportItemAttribute>();

        return string.Format($"{{0:{attr?.Format}}} {attr?.Units}", prop.GetValue(item));


    }


}
