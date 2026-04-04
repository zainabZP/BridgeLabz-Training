using System;

class PersonInfo
{
    public string fullName;
    public int personAge;

    // parameterized constructor
    public PersonInfo(string name, int age)
    {
        fullName = name;
        personAge = age;
    }

    // copy constructor
    public PersonInfo(PersonInfo other)
    {
        fullName = other.fullName;
        personAge = other.personAge;
    }

    // method to display person info
    public void showPerson()
    {
        Console.WriteLine("Name : " + fullName);
        Console.WriteLine("Age  : " + personAge);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // original object
        PersonInfo person1 = new PersonInfo("Ana", 21);

        // copied object
        PersonInfo person2 = new PersonInfo(person1);

        // display copied data
        person2.showPerson();
    }
}
