using System;

class Node {
    public int pid, bt, pr;
    public Node next;
    public Node(int p, int b, int r) {
        pid = p; bt = b; pr = r; next = null;
    }
}

class Program {
    static void Main() {
        Node head = null, temp = null;

        // Add process at end (circular)
        void AddEnd(int p, int b, int r) {
            Node n = new Node(p, b, r);
            if (head == null) {
                head = n;
                n.next = head;
            } else {
                temp = head;
                while (temp.next != head)
                    temp = temp.next;
                temp.next = n;
                n.next = head;
            }
        }

        AddEnd(1, 5, 2);
        AddEnd(2, 7, 1);
        AddEnd(3, 3, 3);

        int q = 2; // quantum
        temp = head;
        int round = 1;

        Console.WriteLine("Round Robin Simulation:");
        do {
            if (temp.bt > 0) {
                Console.WriteLine("Executing P" + temp.pid);
                temp.bt = temp.bt - q;
                if (temp.bt < 0) temp.bt = 0;
            }
            temp = temp.next;
            if (temp == head) round++;
        } while (round <= 3); // simulate 3 rounds
    }
}