using System;
using System.Collections.Generic;

class Node
{
    public string Url;
    public Node Prev;
    public Node Next;

    public Node(string Url)
    {
        this.Url = Url;
        this.Prev = null;
        this.Next = null;
    }
}

class BrowserTab
{
    private Node head;
    private Node current;

    public BrowserTab(string homepage)
    {
        head = new Node(homepage);
        current = head;
        Console.WriteLine("Tab opened with: " + homepage);
    }

    public void Visit(string url)
    {
        Node newNode = new Node(url);
        current.Next = newNode;
        newNode.Prev = current;
        current = newNode;

        Console.WriteLine("Visited: " + url);
    }

    public void Back()
    {
        if (current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Back to: " + current.Url);
        }
        else
        {
            Console.WriteLine("No previous page");
        }
    }

    public void Forward()
    {
        if (current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Forward to: " + current.Url);
        }
        else
        {
            Console.WriteLine("No next page");
        }
    }

    public string CurrentPage()
    {
        return current.Url;
    }
}

class BrowserBuddy
{
    Stack<BrowserTab> closedTabs = new Stack<BrowserTab>();
    BrowserTab currentTab;

    public void OpenTab(string homepage)
    {
        currentTab = new BrowserTab(homepage);
    }

    public void CloseTab()
    {
        if (currentTab != null)
        {
            closedTabs.Push(currentTab);
            Console.WriteLine("Tab closed");
            currentTab = null;
        }
    }

    public void RestoreTab()
    {
        if (closedTabs.Count > 0)
        {
            currentTab = closedTabs.Pop();
            Console.WriteLine("Tab restored at: " + currentTab.CurrentPage());
        }
        else
        {
            Console.WriteLine("No tab to restore");
        }
    }

    public BrowserTab GetTab()
    {
        return currentTab;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BrowserBuddy browser = new BrowserBuddy();

        browser.OpenTab("google.com");

        BrowserTab tab = browser.GetTab();
        tab.Visit("youtube.com");
        tab.Visit("github.com");

        tab.Back();
        tab.Back();
        tab.Forward();

        browser.CloseTab();
        browser.RestoreTab();
    }
}