using System;

class Book {
    public string t, a, g, s;
    public int id;
    public Book prev, next;
    public Book(string T, string A, string G, int I, string S) {
        t = T; a = A; g = G; id = I; s = S;
        prev = next = null;
    }
}

class Program {
    static void Main() {
        Book head = new Book("Harry Potter", "Rowling", "Fantasy", 1, "Yes");
        head.next = new Book("The Alchemist", "Coelho", "Fiction", 2, "No");
        head.next.prev = head;

        // Count books
        int c = 0;
        Book t = head;
        while (t != null) { c++; t = t.next; }
        Console.WriteLine("Total Books: " + c);
    }
}