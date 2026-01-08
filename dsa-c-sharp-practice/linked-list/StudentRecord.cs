using System;

class Node {
    public int roll, age;
    public string name, grade;
    public Node next;
    public Node(int r, string n, int a, string g) {
        roll = r; name = n; age = a; grade = g;
        next = null;
    }
}

class Program {
    static void Main() {
        Node head = null;

        // Add at beginning
        head = new Node(101, "Rohan", 20, "A");
        head.next = new Node(102, "Priya", 19, "B");

        // Print list
        Node temp = head;
        while (temp != null) {
            Console.WriteLine(temp.roll + " " + temp.name + " " + temp.grade);
            temp = temp.next;
        }
    }
}