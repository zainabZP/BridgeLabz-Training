using System;

public class CardioWorkout : Workout
{
    public double Distance; // in km

    public CardioWorkout(string workoutName, int duration, double distance)
        : base(workoutName, duration)
    {
        Distance = distance;
    }

    public override void EndWorkout()
    {
        Console.WriteLine(WorkoutName + " workout completed.");
        Console.WriteLine("Distance covered: " + Distance + " km");
    }
}
