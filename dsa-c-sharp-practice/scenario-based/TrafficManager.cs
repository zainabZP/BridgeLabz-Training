using System;
using System.Collections.Generic;

class Node
{
    public string Number;
    public Node Next;

    public Node(string number)
    {
        Number = number;
        Next = null;
    }
}

class Roundabout
{
    private Node tail;
    private int count;
    private int capacity;

    Queue<string> waitingQueue = new Queue<string>();

    public Roundabout(int capacity)
    {
        this.capacity = capacity;
        tail = null;
        count = 0;
    }

    public void EnterVehicle(string number)
    {
        if (count == capacity)
        {
            waitingQueue.Enqueue(number);
            Console.WriteLine("Roundabout full, wait in queue " + number);
            return;
        }

        Node newNode = new Node(number);

        if (tail == null)
        {
            tail = newNode;
            tail.Next = tail;
        }
        else
        {
            newNode.Next = tail.Next;
            tail.Next = newNode;
            tail = newNode;
        }

        count++;
        Console.WriteLine("Vehicle entered: " + number);
    }

    public void ExitVehicle()
    {
        if (tail == null)
        {
            Console.WriteLine("No vehicles to exit");
            return;
        }

        Node head = tail.Next;

        if (head == tail)
        {
            tail = null;
        }
        else
        {
            tail.Next = head.Next;
        }

        count--;
        Console.WriteLine("Vehicle exited: " + head.Number);

        if (waitingQueue.Count > 0)
        {
            EnterVehicle(waitingQueue.Dequeue());
        }
    }

    public void PrintRoundabout()
    {
        if (tail == null)
        {
            Console.WriteLine("Roundabout is empty");
            return;
        }

        Node temp = tail.Next;
        Console.Write("Roundabout: ");
        while(temp!=null){
            Console.WriteLine(temp.Number);
            temp=temp.Next;
            if(temp==tail.Next) break;
        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        Roundabout roundabout = new Roundabout(3);
        roundabout.EnterVehicle("CAR-101");
        roundabout.EnterVehicle("CAR-102");
        roundabout.EnterVehicle("CAR-103");
        roundabout.EnterVehicle("CAR-104");
        roundabout.PrintRoundabout();
        roundabout.ExitVehicle();
        roundabout.PrintRoundabout();
        roundabout.ExitVehicle();
        roundabout.PrintRoundabout();
    }
}
