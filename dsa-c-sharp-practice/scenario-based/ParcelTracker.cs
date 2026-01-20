using System;

class OrderNode
{
    public string ProductName;
    public int ProductId;
    public string CustomerName;
    public int CustomerId;
    public string OrderDate;
    public string Status;
    public OrderNode next;

    public OrderNode(string productName, int productId, string customerName, int customerId, string orderDate, string status)
    {
        ProductName = productName;
        ProductId = productId;
        CustomerName = customerName;
        CustomerId = customerId;
        OrderDate = orderDate;
        Status = status;
        next = null;
    }
}

class Tracker
{
    private OrderNode head;

    // Add stage at end
    public void AddStage(string status)
    {
        if (head == null)
        {
            head = new OrderNode("Mobile", 101, "Rohan", 1, "20-01-2026", status);
            return;
        }

        OrderNode temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = new OrderNode(head.ProductName, head.ProductId,
                                  head.CustomerName, head.CustomerId,
                                  head.OrderDate, status);
    }

    // Add intermediate checkpoint
    public void AddAfter(string existingStatus, string newStatus)
    {
        OrderNode temp = head;

        while (temp != null)
        {
            if (temp.Status == existingStatus)
            {
                OrderNode newNode = new OrderNode(
                    head.ProductName, head.ProductId,
                    head.CustomerName, head.CustomerId,
                    head.OrderDate, newStatus);

                newNode.next = temp.next;
                temp.next = newNode;
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Checkpoint not found!");
    }

    // Display tracking
    public void TrackParcel()
    {
        if (head == null)
        {
            Console.WriteLine("Parcel Lost / No Tracking Available");
            return;
        }

        OrderNode temp = head;
        while (temp != null)
        {
            Console.Write(temp.Status);
            if (temp.next != null)
                Console.Write(" -> ");
            temp = temp.next;
        }
        Console.WriteLine();
    }
}

class Program
{
    public static void Main()
    {
        Tracker tracker = new Tracker();
        bool flag = false;

        Console.WriteLine("1. Add Stage");
        Console.WriteLine("2. Add Intermediate Checkpoint");
        Console.WriteLine("3. Track Parcel");
        Console.WriteLine("4. Exit");

        while (!flag)
        {
            Console.Write("\nEnter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter stage name: ");
                    tracker.AddStage(Console.ReadLine());
                    break;

                case 2:
                    Console.Write("Enter existing stage: ");
                    string existing = Console.ReadLine();
                    Console.Write("Enter new checkpoint: ");
                    string checkpoint = Console.ReadLine();
                    tracker.AddAfter(existing, checkpoint);
                    break;

                case 3:
                    tracker.TrackParcel();
                    break;

                case 4:
                    flag = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
