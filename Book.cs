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
    public string Id { get => id; set => id = value; }
    public string Title { get => title; set => title = value; }
    public string Authorname { get => authorname; set => authorname = value; }
    public DateTime Publisheddate { get => publisheddate; set => publisheddate = value; }
    public string Publisher { get => publisher; set => publisher = value; }
    public int Numofpages { get => numofpages; set => numofpages = value; }
    public uint Price { get => price; set => price = value; }
    public byte Quantity { get => quantity; set => quantity = value; }

    public Book(string id, string title, string authorname, DateTime publisheddate, string publisher, int numofpages, uint price, byte quantity)
    {
        this.Id = id;
        this.Title = title;
        this.Authorname = authorname;
        this.Publisheddate = publisheddate;
        this.Publisher = publisher;
        this.Numofpages = numofpages;
        this.Price = price;
        this.Quantity = quantity;
    }
    public object Clone()
    {
        return new Book(Id, Title, Authorname, Publisheddate,
            Publisher, Numofpages, Price, Quantity);
    }
    public bool find(string keyword)
    {
        return Title.IndexOf(keyword) >= 0 || Authorname.IndexOf(keyword) >= 0 || Id.IndexOf(keyword) >= 0;
    }
    public void update(string title, string authorname, DateTime publisheddate, string publisher, int numofpages, uint price, byte quantity)
    {
        this.Title = title;
        this.Authorname = authorname;
        this.Publisheddate = publisheddate;
        this.Publisher = publisher;
        this.Numofpages = numofpages;
        this.Price = price;
        this.Quantity = quantity;
    }
    public override string ToString()
    {
        return "Book(" + Id + "," + Title + "," + Authorname + "," + Publisheddate + "," + Publisher + "," + Numofpages + "," + Price + "," + Quantity + ")";
    }
    public void BorrowBook(byte amount)
    {
        if (amount <= Quantity)
        {
            Quantity -= amount;
        }
        else
        {
            Console.WriteLine("Out Of Limit");
        }
    }
    public void ReturnBook(byte amount)
    {
        Quantity += amount;
    }
    public bool IsAvailable(byte amount)
    {
        return Quantity >= amount;
    }
}
