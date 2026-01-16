using System;

class BookBuddy
{
    // Simple array to store books
    public static string[][] books = new string[10][];
    public static int count = 0;

    // Add a book
    public void AddBook(string title, string author)
    {
        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
        {
            throw new Exception("Invalid book format");
        }

        books[count] = new string[]{title, author};
        count++;
    }

    // Sort books alphabetically
    public void SortBooksAlphabetically()
    {
        try
        {
            if (count == 0)
            {
                throw new Exception("Book list is empty");
            }
            Array.Sort(books,(a,b)=>a[0].CompareTo(b[0]));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    // Search books by author
    public void SearchByAuthor(string author)
    {
        try
        {
            if (count == 0)
            {
                throw new Exception("Book list is empty");
            }

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if(books[i][1]==author){
                    Console.WriteLine(books[i][0]);
                    found=true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found for author: " + author);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        BookBuddy buddy = new BookBuddy();

        buddy.AddBook("Atomic Habits", "James Clear");
        buddy.AddBook("The Alchemist", "Paulo Coelho");
        buddy.AddBook("Clean Code", "Robert Martin");

        for (int i = 0; i < BookBuddy.count; i++)
        {
            Console.WriteLine(BookBuddy.books[i][0]+" "+BookBuddy.books[i][1]);
        }

        buddy.SortBooksAlphabetically();

        Console.WriteLine("Books by Paulo Coelho:");
        buddy.SearchByAuthor("Paulo Coelho");

        for (int i = 0; i < BookBuddy.count; i++)
        {
            Console.WriteLine(BookBuddy.books[i][0]+" "+BookBuddy.books[i][1]);
        }
    }
}
