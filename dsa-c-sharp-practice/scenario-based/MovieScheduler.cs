using System;

class CinemaTime
{
    public static string[][] movies = new string[20][];
    public static int count = 0;

    // Add a movie
    public void AddMovie(string title, string time)
    {
        movies[count] = new string[] { title, time };
        count++;
    }

    // Search movies by keyword in title
    public void SearchMovie(string keyword)
    {
        bool found = false;
        for (int i = 0; i < count; i++)
        {
            if (movies[i][0].Contains(keyword))
            {
                Console.WriteLine(movies[i][0] + " at " + movies[i][1]);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No movies found with keyword: " + keyword);
        }
    }

    // Display all movies
    public void DisplayAllMovies()
    {
        if (count == 0)
        {
            Console.WriteLine("No movies scheduled");
            return;
        }

        Console.WriteLine("All Movies:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("{0}. {1} at {2}", i + 1, movies[i][0], movies[i][1]);
        }
    }

    // Convert movies to array (for report)
    public string[] GenerateReport()
    {
        string[] report = new string[count];
        for (int i = 0; i < count; i++)
        {
            report[i] = movies[i][0] + " - " + movies[i][1];
        }
        return report;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CinemaTime cinema = new CinemaTime();

        // Add movies
        cinema.AddMovie("Avatar 2", "14:30");
        cinema.AddMovie("Spider-Man", "18:45");
        cinema.AddMovie("Inception", "21:00");

        // Display all movies
        cinema.DisplayAllMovies();

        // Search movies
        Console.WriteLine("\nSearch for 'Spider':");
        cinema.SearchMovie("Spider");

        // Generate report
        string[] report = cinema.GenerateReport();
        Console.WriteLine("\nReport Array:");
        for (int i = 0; i < report.Length; i++)
        {
            Console.WriteLine(report[i]);
        }
    }
}
