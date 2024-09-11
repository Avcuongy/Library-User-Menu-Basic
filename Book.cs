using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Book : ICloneable
{
    private string id;
    private string title;
    private string authorname;
    private DateTime publisheddate;
    private string publisher;
    private int numofpages;
    private uint price;
    private byte quantity;
    public Book(string id, string title, string authorname, DateTime publisheddate, string publisher, int numofpages, uint price, byte quantity)
    {
        this.id = id;
        this.title = title;
        this.authorname = authorname;
        this.publisheddate = publisheddate;
        this.publisher = publisher;
        this.numofpages = numofpages;
        this.price = price;
        this.quantity = quantity;
    }
    public object Clone()
    {
        return new Book(id, title, authorname, publisheddate,
            publisher, numofpages, price, quantity);
    }
    public bool find(string keyword)
    {
        return title.IndexOf(keyword) >= 0 || authorname.IndexOf(keyword) >= 0 || id.IndexOf(keyword) >= 0;
    }
    public void update(string title, string authorname, DateTime publisheddate, string publisher, int numofpages, uint price, byte quantity)
    {
        this.title = title;
        this.authorname = authorname;
        this.publisheddate = publisheddate;
        this.publisher = publisher;
        this.numofpages = numofpages;
        this.price = price;
        this.quantity = quantity;
    }
    public override string ToString()
    {
        return "Book(" + id + "," + title + "," + authorname + "," + publisheddate + "," + publisher + "," + numofpages + "," + price + "," + quantity + ")";
    }
    public void BorrowBook(byte amount)
    {
        if (amount <= quantity)
        {
            quantity -= amount;
        }
        else
        {
            Console.WriteLine("Out Of Limit");
        }
    }
    public void ReturnBook(byte amount)
    {
        quantity += amount;
    }
    public bool IsAvailable(byte amount)
    {
        return quantity >= amount;
    }
}
