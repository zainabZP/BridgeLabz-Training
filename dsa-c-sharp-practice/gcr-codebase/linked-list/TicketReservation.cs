using System;

class Ticket {
    public int id, seat;
    public string cust, movie, time;
    public Ticket next;
    public Ticket(int i, string c, string m, int s, string t) {
        id = i; cust = c; movie = m; seat = s; time = t; next = null;
    }
}

class Program {
    static void Main() {
        Ticket head = null, temp = null;

        void AddEnd(int i, string c, string m, int s, string t) {
            Ticket n = new Ticket(i, c, m, s, t);
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

        void Remove(int tid) {
            if (head == null) return;
            temp = head;
            Ticket prev = null;
            do {
                if (temp.id == tid) {
                    if (prev != null) prev.next = temp.next;
                    if (temp == head) {
                        Ticket last = head;
                        while (last.next != head)
                            last = last.next;
                        head = temp.next;
                        last.next = head;
                    }
                    return;
                }
                prev = temp;
                temp = temp.next;
            } while (temp != head);
        }

        AddEnd(1, "John", "Inception", 10, "5PM");
        AddEnd(2, "Sara", "Avatar", 3, "8PM");

        Console.WriteLine("Tickets:");
        temp = head;
        do {
            Console.WriteLine(temp.id + " " + temp.movie + " Seat:" + temp.seat);
            temp = temp.next;
        } while (temp != head);

        Console.WriteLine("Removing ticket 1");
        Remove(1);
    }
}