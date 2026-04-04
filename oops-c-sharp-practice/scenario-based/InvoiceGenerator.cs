using System;
class Freelancer{
    private string invoiceInput;
    private string[] tasks=new string[10];
    public string GetInvoiceInput(){
        return invoiceInput;
    }
    public void SetInvoiceInput(string invoice){
        invoiceInput=invoice;
    }
    public string[] GetInvoiceInputArray(){
        return tasks;
    }
    public void SetInvoiceInputArray(string invoice, int idx){
        tasks[idx]=invoice;
    }
}
class InvoiceGenerator{
    static void ParseInvoice(Freelancer freelancer){
        string input=freelancer.GetInvoiceInput();
        string subInput="";int idx=0;
        for(int i=0;i<input.Length;i++){
            if(input[i]!=','){
                subInput+=input[i];
            }
            else{
                freelancer.SetInvoiceInputArray(subInput,idx);
                idx++;
                subInput="";
            }
        }
        freelancer.SetInvoiceInputArray(subInput,idx);
    }
    static int GetTotalAmount(Freelancer freelancer){
        int sum = 0;
        string[] invoiceArray=freelancer.GetInvoiceInputArray();
        for(int i=0;i<invoiceArray.Length;i++){
            if(invoiceArray[i]!=null&&invoiceArray[i]!=""){
                string[] invoiceParts = invoiceArray[i].Split('-');
                string amountPart = invoiceParts[1].Replace("INR", "").Trim();
                int amount = int.Parse(amountPart);
                sum+=amount;
            }
        }
        return sum;
    }
    static void Main(){
        Freelancer freelancer = new Freelancer();
        int choice = 0;
        Console.WriteLine("Enter Choice : ");
        bool flag=false;
        while (!flag){
            Console.WriteLine("1. Enter Invoice Details");
            Console.WriteLine("2. Calculate Total Amount");
            Console.WriteLine("3. Exit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1){
                Console.WriteLine("Enter invoice details:");
                Console.WriteLine("Example: Logo Design - 3000 INR, Web Page - 4500 INR");
                freelancer.SetInvoiceInput(Console.ReadLine());
                ParseInvoice(freelancer);
            }
            else if (choice == 2){
                if (freelancer.GetInvoiceInput().Equals("")){
                    Console.WriteLine("Please enter invoice details first.");
                }
                else{
                    int total = GetTotalAmount(freelancer);
                    Console.WriteLine("Total Invoice Amount: " + total + " INR");
                }
            }
            else if (choice == 3){
                Console.WriteLine("Exiting program...");
                flag=true;
            }
            else{
                Console.WriteLine("Enter a Valid Choice");
            }
        }
    }
}
