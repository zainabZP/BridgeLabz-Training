using System;
class Animal{
    int Age;
    string Name;
    public void Sound(){
        Console.WriteLine("Animal Sound");
    }
}

class Dog:Animal{
    public void Sound(){
        Console.WriteLine("Dog");
    }
}
class Cat:Animal{
    public void Sound(){
        Console.WriteLine("Cat Meow");
    }
}
class Bird:Animal{
    public void Sound(){
        Console.WriteLine("Bird Chirp");
    }
}
class program{
    public static void Main(String[] ar){
    Dog dog=new Dog();
    Cat cat=new Cat();
    Bird bird=new Bird();
    dog.Sound();
    cat.Sound();
    bird.Sound();
    }
}
