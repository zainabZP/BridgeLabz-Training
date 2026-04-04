using System;

public class Workout : ITrackable
{
    public string WorkoutName;
    public int Duration; // in minutes

    public Workout(string workoutName, int duration)
    {
        WorkoutName = workoutName;
        Duration = duration;
    }

    public virtual void StartWorkout()
    {
        Console.WriteLine(WorkoutName + " workout started.");
    }

    public virtual void EndWorkout()
    {
        Console.WriteLine(WorkoutName + " workout ended.");
    }
}
