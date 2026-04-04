using System;

class BookBase
{
    // public member
    public string bookCode;

    // protected member
    protected string bookTitle;

    // private member
    private string writer;

    // method to assign author name
    public void setWriter(string name)
    {
        writer = name;
    }

    // method to return author name
    public string getWriter()
    {
        return writer;
    }
}

// derived class
class DigitalBook : BookBase
{
    public void showDetails()
    {
        bookCode = "ISBN123";
        bookTitle = "C# Programming";

        Console.WriteLine("Book Code : " + bookCode);
        Console.WriteLine("Title     : " + bookTitle);
    }

    static void Main(string[] args)
    {
        // creating object
        DigitalBook ebookObj = new DigitalBook();

        // setting private data using methods
        ebookObj.setWriter("Ana");

        // displaying information
        ebookObj.showDetails();
        Console.WriteLine("Author    : " + ebookObj.getWriter());
    }
}
