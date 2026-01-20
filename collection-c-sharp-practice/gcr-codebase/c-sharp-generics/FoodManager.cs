using System;

interface IFoodPlan
{
    void DisplayPlan();
}

class VegFood : IFoodPlan
{
    public void DisplayPlan()
    {
        Console.WriteLine("Veg food selected");
    }
}

class VeganFood : IFoodPlan
{
    public void DisplayPlan()
    {
        Console.WriteLine("Vegan food selected");
    }
}

class FoodManager<T> where T : IFoodPlan, new()
{
    public void ShowFood()
    {
        T obj = new T();
        obj.DisplayPlan();
    }
}

class Program
{
    static void Main()
    {
        FoodManager<VeganFood> food = new FoodManager<VeganFood>();
        food.ShowFood();
    }
}
