using System;

public class StrengthWorkout : Workout
{
    public int Sets;

    public StrengthWorkout(string workoutName, int duration, int sets)
        : base(workoutName, duration)
    {
        Sets = sets;
    }

    public override void EndWorkout()
    {
        Console.WriteLine(WorkoutName + " workout completed.");
        Console.WriteLine("Total sets: " + Sets);
    }
}
