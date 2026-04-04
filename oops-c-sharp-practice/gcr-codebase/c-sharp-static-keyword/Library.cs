using System;

class BookInfo
{
    // static variable shared by all books
    public static string libraryTitle = "Central Library";

    // readonly ISBN
    public readonly string bookISBN;
    public string bookTitle;
    public string bookAuthor;

    // constructor using 'this' keyword
    public BookInfo(string isbn, string title, string author)
    {
        this.bookISBN = isbn;
        this.bookTitle = title;
        this.bookAuthor = author;
    }

    // static method to show library name
    public static void showLibraryName()
    {
        Console.WriteLine("Library : " + libraryTitle);
    }

    static void Main(string[] args)
    {
        // creating book object
        BookInfo myBook = new BookInfo("ISBN001", "C# Basics", "Ana");

        // using 'is' operator for type checking
        if (myBook is BookInfo)
        {
            Console.WriteLine("Book : " + myBook.bookTitle + " by " + myBook.bookAuthor);
            Console.WriteLine("ISBN : " + myBook.bookISBN);
        }

        // display library name
        BookInfo.showLibraryName();
    }
}
