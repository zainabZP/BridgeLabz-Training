// using System;
// public class Bank{
//     public const int Capacity=10;
//     public const string BankName="IBDI";
//     public static int TotalClientSize=0;
//     public static Client[] arr=new Client[Capacity];
// }
// static class BankManager{   
//     static void DisplayAccount(int account){
//         if(account >= 0 && account < Bank.Capacity && Bank.arr[account]!=null){
//             Client accountObject=Bank.arr[account];
//             Console.WriteLine("Holder Name : "+accountObject.GetName()+" Balance : "+accountObject.GetAmount()+" Account Number : "+accountObject.GetAccountNumber());
//         }
//         else{
//             Console.WriteLine("Account doenst exist");
//         }
//     }
//     static void DeleteAccount(int account){
//         if (account >= 0 && account < Bank.Capacity && Bank.arr[account] != null){
//             Bank.arr[account] = null;
//             for(int i=account+1;i<Bank.TotalClientSize;i++){
//                 Bank.arr[i-1]=Bank.arr[i];
//                 Bank.arr[i - 1].UpdateAccountNumber(i-1);
//             }
//             Bank.arr[Bank.TotalClientSize - 1] = null;
//             Bank.TotalClientSize--;
//             Console.WriteLine("Account deleted successfully");
//         }
//         else{
//             Console.WriteLine("Account doesnt exist");
//         }
//     }
//     static void DisplayTotalAccount(){
//         for(int i=0;i<Bank.TotalClientSize;i++){
//             Client accountObject=Bank.arr[i];
//             Console.WriteLine("Holder Name : "+accountObject.GetName()+" Balance : "+accountObject.GetAmount()+" Account Number : "+accountObject.GetAccountNumber());
//         }
//     }
//     static void DepositeMoney(int account, int money){
//         if(Bank.arr[account]!=null)
//         Bank.arr[account].amount=Bank.arr[account].amount+money;
//         else Console.WriteLine("ACCOUNT DOES NOT EXIST");
//     }
//     static void WithdrawMoney(int account, int money){
//         if(Bank.arr[account]!=null&&Bank.arr[account].CanWithdraw(money))
//         Bank.arr[account].SubtractAmount(money);
//         else Console.WriteLine("ACCOUNT DOES NOT EXIST");
//     }
//     static void Main(){
//         Console.WriteLine("SPECIFY ROLE : ");
//         string role=Console.ReadLine();
//         if(role.Equals("manager")){
//             Console.WriteLine("ENTER CHOICE : ");
//             bool flag=false;
//             while(!flag){
//                 Console.WriteLine("1. Display a Acoount");
//                 Console.WriteLine("2. Delete a Acoount");
//                 Console.WriteLine("3. Display all Acoounts");
//                 Console.WriteLine("4. Exit");
//                 int ch=int.Parse(Console.ReadLine());
//                 switch(ch){
//                     case 1 :    Console.WriteLine("ENTER ACCOUNT NUMBER : ");
//                                 int number1=int.Parse(Console.ReadLine());
//                                 DisplayAccount(number1);
//                                 break;
//                     case 2 :    Console.WriteLine("ENTER ACCOUNT NUMBER : ");
//                                 int number2=int.Parse(Console.ReadLine());
//                                 DeleteAccount(number2);
//                                 break;
//                     case 3 :    DisplayTotalAccount();
//                                 break;
//                     case 4 :    flag=true;break;
//                     default:    Console.WriteLine("ENTER VALID CHOICE ");
//                                 break;
//                 }
//             }
//         }
//         if(role.Equals("user")){
//             Console.WriteLine("SPECIFY STATUS IF EXISTING TYPE 'yes' ELSE TYPE 'no' : ");
//             string status=Console.ReadLine();
//             if(status.Equals("no")){
//                 bool flagNew=false;
//                 Console.WriteLine("ENTER CHOICE : ");
//                 while(!flagNew){
//                     Console.WriteLine("1. Create a new Account");
//                     Console.WriteLine("2. Exit");
//                     int ch=int.Parse(Console.ReadLine());
//                     switch(ch){
//                         case 1 : Client.CreateAccount();break;
//                         case 2 : flagNew=true;break;
//                         default : Console.WriteLine("Enter Valid Choice");break;
//                     }
//                 }
//             }
//             else if(status.Equals("yes")){
//                 Console.WriteLine("ENTER CHOICE : ");
//                 bool flagOld=false;
//                 while(!flagOld){
//                     int accNumber=Client.GetAccountNumber();
//                     Console.WriteLine("1. Display Account");
//                     Console.WriteLine("2. Delete Account");
//                     Console.WriteLine("3. Deposite Money");
//                     Console.WriteLine("4. Withdraw Money");
//                     Console.WriteLine("5. Exit");
//                     int ch=int.Parse(Console.ReadLine());
//                     switch(ch){
//                         case 1 : DisplayAccount(accNumber);break;
//                         case 2 : DeleteAccount(accNumber);break;
//                         case 3 : DepositeMoney(accNumber,Bank.arr[accNumber].Deposit());break;
//                         case 4 : WithdrawMoney(accNumber,Bank.arr[accNumber].Withdraw());break;
//                         case 5 : flagOld=true;break;
//                         default : Console.WriteLine("Enter Valid Choice");
//                     }
//                 }
//             }  
//         }
//     }
// }
// public class Client {
//     private string name;
//     private int amount;
//     private int accountNumber;
//     static void CreateAccount(){
//         Client user=new Client();
//         if(Bank.TotalClientSize<Bank.Capacity){
//             Console.WriteLine("ENTER NAME : ");
//             user.name=Console.ReadLine();
//             Console.WriteLine("ENTER AMOUNT : ");
//             user.amount=int.Parse(Console.ReadLine());
//             user.accountNumber=Bank.TotalClientSize;
//             Bank.arr[Bank.TotalClientSize]=user;
//             Bank.TotalClientSize++;
//         }
//         else Console.WriteLine("Cant Add New User");
//     }
//     public int Deposit(){
//         Console.WriteLine("ENTER AMOUNT : ");
//         int depositAmount=int.Parse(Console.ReadLine());
//         return depositAmount;
//     }
//     public int Withdraw(){
//         Console.WriteLine("ENTER AMOUNT : ");
//         int WithdrawAmount=int.Parse(Console.ReadLine());
//         return WithdrawAmount;
//     }
//     public bool DeleteAccount(){
//         Console.WriteLine("Type 'yes' if you want to delete your account");
//         string permission=Console.ReadLine();
//         if(permission.ToLower().Equals("yes"))
//         return true;
//         else return false;
//     }
//     public int GetAccountNumber(){
//         return accountNumber;
//     }
//     public string GetName(){
//         return name;
//     }
//     public string GetAmount(){
//         return amount;
//     }
//     public void UpdateAccountNumber(int num){
//         accountNumber = num;
//     }

//     public void AddAmount(int money){
//         amount = amount + money;
//     }

//     public void SubtractAmount(int money){
//         amount = amount - money;
//     }

//     public bool CanWithdraw(int money){
//         if (amount - money >= 0) return true;
//         else return false;
//     }

// }


using System;

public class Bank {
    public const int Capacity = 10;
    public const string BankName = "IBDI";
    public static int TotalClientSize = 0;
    public static Client[] arr = new Client[Capacity];

    // Static default user always at index 0
    public static Client DefaultUser = new Client {
        name = "StaticUser",
        amount = 1000,
        accountNumber = 0
    };

    // Initialize static user in array
    static Bank() {
        arr[0] = DefaultUser;
        TotalClientSize = 1;
    }
}

static class BankManager {   
    static void DisplayAccount(int account){
        if(account >= 0 && account < Bank.Capacity && Bank.arr[account] != null){
            Client accountObject = Bank.arr[account];
            Console.WriteLine("Holder Name : " + accountObject.GetName() +
                              " Balance : " + accountObject.GetAmount() +
                              " Account Number : " + accountObject.GetAccountNumber());
        }
        else{
            Console.WriteLine("Account doesn't exist");
        }
    }

    static void DeleteAccount(int account){
        if(account > 0 && account < Bank.Capacity && Bank.arr[account] != null){ 
            // account 0 is static, cannot delete
            Bank.arr[account] = null;
            Console.WriteLine("Account deleted successfully");
        }
        else if(account == 0){
            Console.WriteLine("Cannot delete the static default user!");
        }
        else{
            Console.WriteLine("Account doesn't exist");
        }
    }

    static void DisplayTotalAccount(){
        for(int i = 0; i < Bank.Capacity; i++){
            if(Bank.arr[i] != null){
                Client accountObject = Bank.arr[i];
                Console.WriteLine("Holder Name : " + accountObject.GetName() +
                                  " Balance : " + accountObject.GetAmount() +
                                  " Account Number : " + accountObject.GetAccountNumber());
            }
        }
    }

    static void DepositeMoney(int account, int money){
        if(Bank.arr[account] != null)
            Bank.arr[account].AddAmount(money);
        else
            Console.WriteLine("Account does not exist");
    }

    static void WithdrawMoney(int account, int money){
        if(Bank.arr[account] != null && Bank.arr[account].CanWithdraw(money))
            Bank.arr[account].SubtractAmount(money);
        else
            Console.WriteLine("Insufficient balance or account does not exist");
    }

    static void Main(){
        Console.WriteLine("Static default user created with Account Number: 0");

        Console.WriteLine("SPECIFY ROLE : ");
        string role = Console.ReadLine();

        if(role.Equals("manager")){
            bool flag = false;
            while(!flag){
                Console.WriteLine("1. Display a Account");
                Console.WriteLine("2. Delete a Account");
                Console.WriteLine("3. Display all Accounts");
                Console.WriteLine("4. Exit");
                int ch = int.Parse(Console.ReadLine());

                switch(ch){
                    case 1:
                        Console.WriteLine("ENTER ACCOUNT NUMBER : ");
                        int number1 = int.Parse(Console.ReadLine());
                        DisplayAccount(number1);
                        break;
                    case 2:
                        Console.WriteLine("ENTER ACCOUNT NUMBER : ");
                        int number2 = int.Parse(Console.ReadLine());
                        DeleteAccount(number2);
                        break;
                    case 3:
                        DisplayTotalAccount();
                        break;
                    case 4:
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("ENTER VALID CHOICE ");
                        break;
                }
            }
        }

        if(role.Equals("user")){
            Console.WriteLine("SPECIFY STATUS IF EXISTING TYPE 'yes' ELSE TYPE 'no' : ");
            string status = Console.ReadLine();

            if(status.Equals("no")){
                bool flagNew = false;
                while(!flagNew){
                    Console.WriteLine("1. Create a new Account");
                    Console.WriteLine("2. Exit");
                    int ch = int.Parse(Console.ReadLine());

                    switch(ch){
                        case 1:
                            Client.CreateAccount();
                            break;
                        case 2:
                            flagNew = true;
                            break;
                        default:
                            Console.WriteLine("Enter Valid Choice");
                            break;
                    }
                }
            }
            else if(status.Equals("yes")){
                Console.WriteLine("ENTER ACCOUNT NUMBER : ");
                int accNumber = int.Parse(Console.ReadLine());
                bool flagOld = false;
                while(!flagOld){
                    Console.WriteLine("1. Display Account");
                    Console.WriteLine("2. Delete Account");
                    Console.WriteLine("3. Deposite Money");
                    Console.WriteLine("4. Withdraw Money");
                    Console.WriteLine("5. Exit");
                    int ch = int.Parse(Console.ReadLine());

                    switch(ch){
                        case 1:
                            DisplayAccount(accNumber);
                            break;
                        case 2:
                            DeleteAccount(accNumber);
                            break;
                        case 3:
                            DepositeMoney(accNumber, Bank.arr[accNumber].Deposit());
                            break;
                        case 4:
                            WithdrawMoney(accNumber, Bank.arr[accNumber].Withdraw());
                            break;
                        case 5:
                            flagOld = true;
                            break;
                        default:
                            Console.WriteLine("Enter Valid Choice");
                            break;
                    }
                }
            }
        }
    }
}

public class Client {
    public string name;
    public int amount;
    public int accountNumber;

    public static void CreateAccount(){
        if(Bank.TotalClientSize < Bank.Capacity){
            Client user = new Client();
            Console.WriteLine("ENTER NAME : ");
            user.name = Console.ReadLine();
            Console.WriteLine("ENTER AMOUNT : ");
            user.amount = int.Parse(Console.ReadLine());

            // Assign next available slot (skip 0, static user)
            int accNum = Bank.TotalClientSize;
            user.accountNumber = accNum;
            Bank.arr[accNum] = user;
            Bank.TotalClientSize++;

            Console.WriteLine("Account created with Account Number: " + accNum);
        }
        else{
            Console.WriteLine("Cannot add new user, bank full");
        }
    }

    public int Deposit(){
        Console.WriteLine("ENTER AMOUNT : ");
        int depositAmount = int.Parse(Console.ReadLine());
        return depositAmount;
    }

    public int Withdraw(){
        Console.WriteLine("ENTER AMOUNT : ");
        int withdrawAmount = int.Parse(Console.ReadLine());
        return withdrawAmount;
    }

    public bool DeleteAccount(){
        Console.WriteLine("Type 'yes' if you want to delete your account");
        string permission = Console.ReadLine();
        if(permission.ToLower().Equals("yes"))
            return true;
        else
            return false;
    }

    public int GetAccountNumber(){ return accountNumber; }
    public string GetName(){ return name; }
    public int GetAmount(){ return amount; }

    public void UpdateAccountNumber(int num){ accountNumber = num; }
    public void AddAmount(int money){ amount += money; }
    public void SubtractAmount(int money){ amount -= money; }
    public bool CanWithdraw(int money){ return amount - money >= 0; }
}





