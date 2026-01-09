using System;
using System.Collections.Generic;

class StackSorter
{
    // Helper method: insert a number into the stack in sorted order
    static void PushInOrder(Stack<int> stack, int num)
    {
        // If stack is empty or top element <= num, just push
        if (stack.Count == 0 || stack.Peek() <= num)
        {
            stack.Push(num);
            return;
        }

        // Otherwise, pop top and recurse
        int temp = stack.Pop();
        PushInOrder(stack, num);

        // Put the popped element back
        stack.Push(temp);
    }

    // Sorts the stack recursively
    static void SortStackRecursively(Stack<int> stack)
    {
        // Base case: empty stack
        if (stack.Count == 0) return;

        // Pop top element
        int top = stack.Pop();

        // Sort the remaining stack
        SortStackRecursively(stack);

        // Insert the popped element in sorted order
        PushInOrder(stack, top);
    }

    static void Main()
    {
        Stack<int> myStack = new Stack<int>(new int[] { 3, 1, 4, 2 });

        SortStackRecursively(myStack);

        Console.WriteLine("Sorted stack (top to bottom):");
        foreach (int n in myStack)
        {
            Console.Write(n + " ");
        }
    }
}
