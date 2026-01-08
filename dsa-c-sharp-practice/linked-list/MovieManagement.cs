using System;

class Movie {
    public string title, director;
    public int year;
    public double rating;
    public Movie prev, next;
    public Movie(string t, string d, int y, double r) {
        title = t; director = d; year = y; rating = r;
        prev = next = null;
    }
}

class Program {
    static void Main() {
        Movie head = null;

        // Add movies
        head = new Movie("Interstellar", "Nolan", 2014, 8.9);
        head.next = new Movie("Titanic", "Cameron", 1997, 8.2);
        head.next.prev = head;

        // Display forward
        Movie t = head;
        while (t != null) {
            Console.WriteLine(t.title + " (" + t.rating + ")");
            t = t.next;
        }
    }
}