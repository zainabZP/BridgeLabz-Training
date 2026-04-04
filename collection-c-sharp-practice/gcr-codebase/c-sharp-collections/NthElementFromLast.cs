using System;
class Node{
    public string val;
    public Node next;
    public Node(string val){
        this.val=val;
        this.next=null;
    }
}
class NthElementFromLast{
    static Node head;
    static Node tail;
    public static void Add(){
        Node nn=new Node(Console.ReadLine());
        if(head==null){
            head=nn;
            tail=nn;
        }
        else{
            tail.next=nn;
            tail=tail.next;
        }
    }
    public static void Main(){
        int n=int.Parse(Console.ReadLine());
        int k=int.Parse(Console.ReadLine());
        for(int i=0;i<n;i++){
            Add();
        }
        Node h=head;
        for(int i=0;i<n-k;i++){
            h=h.next;
        }
        Console.WriteLine(h.val);
    }
}