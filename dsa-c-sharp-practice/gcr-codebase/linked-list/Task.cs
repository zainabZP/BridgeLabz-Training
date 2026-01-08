using System;

class Task {
    public int id, pr;
    public string name, due;
    public Task next;
    public Task(int i, string n, int p, string d) {
        id = i; name = n; pr = p; due = d; next = null;
    }
}

class Program {
    static void Main() {
        Task head = null;

        // Add tasks
        head = new Task(1, "Assignment", 2, "12 Jan");
        head.next = new Task(2, "Exam Prep", 1, "15 Jan");
        head.next.next = head;

        // Print circular list (2 nodes)
        Task t = head;
        for (int i = 0; i < 2; i++) {
            Console.WriteLine(t.id + " " + t.name + " P:" + t.pr);
            t = t.next;
        }
    }
}