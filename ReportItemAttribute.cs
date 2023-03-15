namespace DemoCorsoCSharp;

[AttributeUsage(AttributeTargets.Property)]
public class ReportItemAttribute : Attribute
{
    public ReportItemAttribute(int columnOrder)
    {
        ColumnOrder = columnOrder;
    }

    public int ColumnOrder { get; }
    public string? Format { get; set; }
    public string? Units { get; set; }
    public string? Heading { get; set; }
}

