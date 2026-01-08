using System;

class Item {
    public int id, qty;
    public string name;
    public double price;
    public Item next;
    public Item(int i, string n, int q, double p) {
        id = i; name = n; qty = q; price = p; next = null;
    }
}

class Program {
    static void Main() {
        Item head = new Item(1, "Notebook", 5, 40);
        head.next = new Item(2, "Marker", 10, 15);

        // Total inventory value
        double sum = 0;
        Item t = head;
        while (t != null) {
            sum += t.qty * t.price;
            t = t.next;
        }
        Console.WriteLine("Total Value: " + sum);
    }
}