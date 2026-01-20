using System;
class PhoneBook{
    string Number;
    string Name;
    static PhoneBook[] array=new PhoneBook[10];
    static int size=0;
    static void AddNumber(string number, string name){
        PhoneBook user=new PhoneBook();
        user.Number=number;
        user.Name=name;
        array[size]=user;
        size++;
    }
    static void DeleteNumber(string number){
        bool flag=false;
        for(int i=0;i<size;i++){
            if(array[i]!=null){
                if(array[i].Number == number){
                    array[i]=null;
                    flag=true;
                    Console.WriteLine("Contact Deleted");
                }
            }
            if(flag) break;
        }
        if(flag==false) Console.WriteLine("Contact Doesnt exist");
    }
    private static void UpdateNumber(string old, string newNumber){
        for(int i=0;i<size;i++){
            if(array[i]!=null){
                if(array[i].Number==old){
                    array[i].Number=newNumber;
                    Console.WriteLine("Contact Udated");
                }
            }
        }
    }
    private static void SearchNumber(string number){
        bool flag=false;
        for(int i=0;i<size;i++){
            if(array[i]!=null){
                string s=array[i].Number;
                if(s.Contains(number)) {
                    Console.WriteLine(s);
                    flag=true;
                }
            }
        }
        if(flag==false) Console.WriteLine("Number Doesnt Exist");
    }
    public static void Main(){
        Console.WriteLine("Enter Choice : ");
        bool flag=false;
        while(!flag){
            Console.WriteLine("1. Add Number ");
            Console.WriteLine("2. Delete Number ");
            Console.WriteLine("3. Update Number ");
            Console.WriteLine("4. Search Number ");
            Console.WriteLine("5. Exit ");
            int ch=int.Parse(Console.ReadLine());
            switch(ch){
                case 1: Console.WriteLine("Enter Number and Name : ");
                        string number1=Console.ReadLine();
                        string name1=Console.ReadLine();
                        AddNumber(number1,name1);break;
                case 2: Console.WriteLine("Enter Number : ");
                        string number2=Console.ReadLine();
                        DeleteNumber(number2);break;
                case 3: Console.WriteLine("Enter Old Number and New Number : ");
                        string Oldnumber=Console.ReadLine();
                        string Newnumber=Console.ReadLine();
                        UpdateNumber(Oldnumber,Newnumber);break;
                case 4: Console.WriteLine("Enter Number : ");
                        string number4=Console.ReadLine();
                        SearchNumber(number4);break;
                case 5: flag=true;break;
                default: Console.WriteLine("Enter Valid Choice");break;
            }
        }
    }
}