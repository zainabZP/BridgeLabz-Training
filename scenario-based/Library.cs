using System;
// making admin class
static class LibraryAdmin{
    // author array
    private static string[] Author={"William Shakespeare", "Jane Austen", "Charles Dickens", "George Orwell", "Mark Twain",
    "Leo Tolstoy", "J.K. Rowling", "Agatha Christie", "Ernest Hemingway", "Rabindranath Tagore"};
    private static string[,] Books={
        {"Hamlet", "Romeo and Juliet"},
        {"Pride and Prejudice", "Sense and Sensibility"},
        {"Oliver Twist", "A Christmas Carol"},
        {"1984", "Animal Farm"},
        {"The Adventures of Tom Sawyer", "Adventures of Huckleberry Finn"},
        {"War and Peace", "Anna Karenina"},
        {"Harry Potter and the Philosopher’s Stone", "Harry Potter and the Chamber of Secrets"},
        {"Murder on the Orient Express", "And Then There Were None"},
        {"The Old Man and the Sea", "A Farewell to Arms"},
        {"Gitanjali", "The Home and the World"}
    };
    // book status
    private static bool[,] Status = {
        { true, true },
        { true, true },
        { true, true },
        { true, true },
        { true, true },
        { true, true },
        { true, true },
        { true, true },
        { true, true },
        { true, true }
    };
    // display author book and status of book
    public static void Display(){
        Console.WriteLine("Books and their Status : ");
        for (int i = 0; i < Books.GetLength(0); i++){
            for (int j = 0; j < Books.GetLength(1); j++){
                Console.WriteLine("Author Name : " +Author[i] +"    Book Name : "+Books[i, j] + "    Status : "+(Status[i, j] ? "Available" : "Unavailable"));
                Console.WriteLine();
            }
        }
    }
    // toggle status
    public static void ChangeStatus(string book){
        bool flag=false;
        for(int i=0;i<Status.GetLength(0);i++){
            for(int j=0;j<Status.GetLength(1);j++){
                if(book.Equals(Books[i,j])){
                    Status[i,j]=!Status[i,j];
                    flag=true;
                    break;
                }
            }
            if(flag) break;
        }
        if(flag) Console.WriteLine("STATUS CHANGED");
        else Console.WriteLine("ENTER VALID BOOK");
    }
    // search book
    public static void SearchBook(string book){
        bool flag=false;
        for(int i=0;i<Books.GetLength(0);i++){
            for(int j=0;j<Books.GetLength(1);j++){
                bool found = Books[i,j].Contains(book);
                if(found){
                    flag=true;
                    Console.Write(Books[i,j]+" ");
                }
            }
        }
        Console.WriteLine();
        if(flag==false) Console.WriteLine("Book not found");
    }
    // issue book method
    public static void Issue(string book){
        bool flag=false;
        for(int i=0;i<Books.GetLength(0);i++){
            for(int j=0;j<Books.GetLength(1);j++){
                bool found = Books[i,j].Contains(book);
                if(found){
                    Status[i,j]=!Status[i,j];
                    Console.WriteLine("Book issued");
                    flag=true;
                    break;
                }
            }
            if(flag) break;
        }
        if(flag==false) Console.WriteLine("Book not found");
    }
    // return book method
    public static void Return(string book){
        bool flag=false;
        for(int i=0;i<Books.GetLength(0);i++){
            for(int j=0;j<Books.GetLength(1);j++){
                bool found = Books[i,j].Contains(book);
                if(found){
                    Status[i,j]=!Status[i,j];
                    flag=true;
                    Console.WriteLine("Book returned");
                    break;
                }
            }
            if(flag) break;
        }
        if(flag==false) Console.WriteLine("Not valid book");
    }

    public static void Main(){
        Console.WriteLine("Enter Identity");
        string identity=Console.ReadLine();
        // admin choices
        if(identity.Equals("admin")){
            Console.WriteLine("Enter Choice : ");
            bool flag=false;
            while(!flag){
                Console.WriteLine("1 : Display");
                Console.WriteLine("2 : Change Status");
                Console.WriteLine("3 : EXIT");
                int choice=int.Parse(Console.ReadLine());
                switch(choice){
                    case 1: Display();break;
                    case 2: Console.WriteLine("ENTER NAME OF BOOK YOU WANT TO CHANGE :");
                            string bookName=Console.ReadLine();
                            ChangeStatus(bookName);
                            break;
                    case 3: flag=true;break;
                    default: Console.WriteLine("ENTER VALID CHOICE");break;
                }
            }
        }
        // user choices
        if(identity.Equals("user")){
            Customer user1=new Customer();
            Console.WriteLine("Enter Choice : ");
            bool flag=false;
            while(!flag){
                Console.WriteLine("1 : Display");
                Console.WriteLine("2 : Search");
                Console.WriteLine("3 : Issue Book");
                Console.WriteLine("4 : Return Book");
                Console.WriteLine("5 : EXIT");
                int choice=int.Parse(Console.ReadLine());
                switch(choice){
                    case 1: Display();break;
                    case 2: string userBook1=user1.GetBook();
                            SearchBook(userBook1);break;
                    case 3: string userBook2=user1.GetBook();
                            Issue(userBook2);break;
                    case 4: string userBook3=user1.GetBook();
                            Return(userBook3);break;
                    case 5: flag=true;break;
                    default: Console.WriteLine("ENTER VALID CHOICE");break;
                }
            }
        }
    }
}
//user class to provide users answer to admin class
class Customer{
    public string GetBook(){
        Console.WriteLine("Enter book name:");
        return Console.ReadLine();
    }
}