using System;

interface IStepsMarker{
    void BubbleSort(Person[] person);
}

class StepsRanking : IStepsMarker
{
    private Person[] person = new Person[20];

    public Person[] Get(){
        return person;
    }

    public void Set(Person p, int i){
        person[i] = p;
    }

    public void BubbleSort(Person[] person){
        for(int i = 0; i < person.Length - 1; i++){
            for(int j = 0; j < person.Length - i - 1; j++){
                if(person[j].steps > person[j + 1].steps){
                    Person t = person[j];
                    person[j] = person[j + 1];
                    person[j + 1] = t;
                }
            }
        }
    }

    public static void Display(Person[] person){
        Console.WriteLine("Top to Bottom Ranks : ");
        for(int i = person.Length - 1; i >= 0; i--){
            if(person[i] != null)
                Console.WriteLine("Roll No " + person[i].rollNo + " Steps : " + person[i].steps);
        }
    }

    public void Run(Person p, int n){
        p.steps += n;
        BubbleSort(person);
    }
}

class Person{
    public int steps;
    public int rollNo;

    public Person(int rollNo, int steps){
        this.rollNo = rollNo;
        this.steps = steps;
    }
}

class Program{
    public static void Main(){
        Console.WriteLine("Batch Formation with initial steps.....");

        StepsRanking batch = new StepsRanking();

        for(int i = 0; i < batch.Get().Length; i++){
            Person p = new Person(i + 1, 0);
            batch.Set(p, i);
            Console.WriteLine("Person " + (i + 1) + " Enrolled (Roll No " + p.rollNo + ")");
        }

        Console.WriteLine("Person 3 Running 12 steps");
        batch.Run(batch.Get()[3], 12);

        Console.WriteLine("Person 9 Running 6 steps");
        batch.Run(batch.Get()[9], 6);

        Console.WriteLine("Person 13 Running 13 steps");
        batch.Run(batch.Get()[13], 13);

        Console.WriteLine("Person 7 Running 48 steps");
        batch.Run(batch.Get()[7], 48);

        Console.WriteLine("Person 1 Running 12 steps");
        batch.Run(batch.Get()[1], 12);

        Console.WriteLine("Person 3 Running 5 steps");
        batch.Run(batch.Get()[3], 5);

        StepsRanking.Display(batch.Get());
    }
}
