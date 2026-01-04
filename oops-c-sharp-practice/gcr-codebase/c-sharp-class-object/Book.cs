using System;

class BookInfo
{
    // data members
    public string bookName;
    public string writerName;
    public double bookCost;

    // function to show details
    public void showDetails()
    {
        Console.WriteLine("Book Name : " + bookName);
        Console.WriteLine("Writer    : " + writerName);
        Console.WriteLine("Cost      : " + bookCost);
    }

    static void Main(string[] args)
    {
        // object creation
        BookInfo myBook = new BookInfo();

        // assigning values
        myBook.bookName = "C# Fundamentals";
        myBook.writerName = "John";
        myBook.bookCost = 350.0;

        // calling method
        myBook.showDetails();
    }
}
