using System;

class BookData
{
    public string bookTitle;
    public string authorName;
    public double bookPrice;

    // default constructor
    public BookData()
    {
        bookTitle = "Not Assigned";
        authorName = "Not Assigned";
        bookPrice = 0.0;
    }

    // parameterized constructor
    public BookData(string title, string author, double price)
    {
        bookTitle = title;
        authorName = author;
        bookPrice = price;
    }

    // method to show details
    public void showBook()
    {
        Console.WriteLine("Title  : " + bookTitle);
        Console.WriteLine("Author : " + authorName);
        Console.WriteLine("Price  : " + bookPrice);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // object using default constructor
        BookData firstBook = new BookData();

        // object using parameterized constructor
        BookData secondBook = new BookData("AI", "Ana", 500);

        firstBook.showBook();
        secondBook.showBook();
    }
}
