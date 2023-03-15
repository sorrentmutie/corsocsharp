using System.ComponentModel.DataAnnotations;

namespace DemoCorsoCSharp;

public enum BookRating
{
    Poor,
    Average,
    Good,
    Excellent
}

public class Book
{
    [ReportItem(2)]
    public string? Title { get; set; }
    [ReportItem(1)]
    public string? Author { get; set; }
    [ReportItem(4, Heading = "Date of publication", Format = "dd-MM-yyyy")]
    public DateTime DateOfPublication { get; set; }
    [ReportItem(3)]
    public BookRating Rating { get; set; }
}

public static class BookData
{
    public static IEnumerable<Book> Books = new Book[]
        {
           new () {Title="Goldfinger", Author="Ian Fleming", DateOfPublication=new DateTime(1959, 3, 23), Rating= BookRating.Excellent},
           new () {Title="Dr No", Author="Ian Fleming", DateOfPublication=new DateTime(1958, 3, 31), Rating=BookRating.Good},
        };

}
