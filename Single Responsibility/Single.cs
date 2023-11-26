using System.Xml.Linq;

namespace Scratching;
public class Invoice
{
    public int InvoiceNo {get;set;}
    public DateOnly IssuedDate {get;set;}
    public string? Customer {get;set;}
    public decimal Amount {get;set;}
    public string? Description {get;set;}

    public void Save()
    {
        Console.WriteLine($"Save{InvoiceNo}");
    }
    
}
class Program
{
    public static void Main (string[]args)
    {
        var invoice = new Invoice
        {
        InvoiceNo= 1, 
        Customer = "John Doe", IssuedDate = new DateOnly(2023,4,1), Description = "Website Design", 
        Amount = 1000 
        };
        invoice.Save()
        ;
    }
    
}
