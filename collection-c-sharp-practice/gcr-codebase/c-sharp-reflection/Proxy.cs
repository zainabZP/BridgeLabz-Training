using System;

interface IGreeting
{
    void SayHello();
}

class Greeting : IGreeting
{
    public void SayHello() => Console.WriteLine("Hello, Luna!");
}

// Student-friendly "proxy" wrapper
class GreetingLogger : IGreeting
{
    private readonly IGreeting _inner;
    public GreetingLogger(IGreeting inner)
    {
        _inner = inner;
    }

    public void SayHello()
    {
        Console.WriteLine("Calling method: SayHello");
        _inner.SayHello();
    }
}

class Program
{
    static void Main()
    {
        IGreeting greeting = new Greeting();
        IGreeting loggingGreeting = new GreetingLogger(greeting);

        loggingGreeting.SayHello();
    }
}
