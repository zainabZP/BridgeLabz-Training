using System;
using System.Collections.Generic;

class MyQueue
{
    // Stack for adding elements
    Stack<int> inputStack = new Stack<int>();

    // Stack for removing elements
    Stack<int> outputStack = new Stack<int>();

    // Add an element to the queue
    public void Enqueue(int item)
    {
        // Push into input stack
        inputStack.Push(item);
    }

    // Remove an element from the queue
    public int Dequeue()
    {
        // If output stack is empty, transfer all items from input stack
        if (outputStack.Count == 0)
        {
            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }

        // Pop from output stack (front of queue)
        return outputStack.Pop();
    }

    static void Main()
    {
        MyQueue queue = new MyQueue();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Dequeued: " + queue.Dequeue()); // 10
        Console.WriteLine("Dequeued: " + queue.Dequeue()); // 20
        queue.Enqueue(40);
        Console.WriteLine("Dequeued: " + queue.Dequeue()); // 30
    }
}
