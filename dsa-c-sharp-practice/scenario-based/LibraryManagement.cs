using System;

class Node
{
    public string[,] bookData; 
    public Node next;

    public Node(string author, string book)
    {
        bookData = new string[1, 2];
        bookData[0, 0] = author;
        bookData[0, 1] = book;
        next = null;
    }
}

class BookList
{
    public Node head;
    public Node tail;

    // Add book at end
    public void AddBook(string author, string book)
    {
        if (Contains(author, book))
        {
            Console.WriteLine("Book already exists: " + book);
            return;
        }

        Node newNode = new Node(author, book);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        Console.WriteLine("Added: " + book + " by " + author);
    }

    // Remove book (borrow)
    public void RemoveBook(string author, string book)
    {
        Node temp = head;
        Node prev = null;

        while (temp != null)
        {
            if (temp.bookData[0, 0] == author && temp.bookData[0, 1] == book)
            {
                if (prev == null)
                    head = temp.next;
                else
                    prev.next = temp.next;

                if (temp == tail)
                    tail = prev;

                Console.WriteLine("Removed: " + book + " by " + author);
                return;
            }
            prev = temp;
            temp = temp.next;
        }

        Console.WriteLine("Book not found: " + book);
    }

    // Check duplication
    public bool Contains(string author, string book)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.bookData[0, 0] == author && temp.bookData[0, 1] == book)
                return true;
            temp = temp.next;
        }
        return false;
    }

    // Print all books
    public void PrintBooks()
    {
        Node temp = head;
        if (temp == null)
        {
            Console.WriteLine("Library is empty");
            return;
        }

        while (temp != null)
        {
            Console.WriteLine("Author: " + temp.bookData[0, 0] + ", Book: " + temp.bookData[0, 1]);
            temp = temp.next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BookList library = new BookList();

        Console.WriteLine("\n--- Library Menu ---");
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. Borrow Book");
        Console.WriteLine("3. Show All Books");
        Console.WriteLine("4. Exit");
        bool flag=false;
        while(!flag){
            Console.Write("Enter your choice: ");
        int choice=int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.Write("Enter Author Name: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Book Name: ");
                    string book = Console.ReadLine();
                    library.AddBook(author, book);
                    break;

                case 2:
                    Console.Write("Enter Author Name to Borrow: ");
                    string bAuthor = Console.ReadLine();
                    Console.Write("Enter Book Name to Borrow: ");
                    string bBook = Console.ReadLine();
                    library.RemoveBook(bAuthor, bBook);
                    break;

                case 3:
                    library.PrintBooks();
                    break;

                case 4:
                    flag=true;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please enter 1-4.");
                    break;
            }
        }

    }
}
