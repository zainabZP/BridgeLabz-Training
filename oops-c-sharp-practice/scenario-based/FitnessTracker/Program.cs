using System;

class Program
{
    static void Main()
    {
        UserProfile user = new UserProfile("Zainab", 21);
        user.ShowDetails();

        CardioWorkout cardio = new CardioWorkout("Running", 30, 5.2);
        cardio.StartWorkout();
        cardio.EndWorkout();

        StrengthWorkout strength = new StrengthWorkout("Weight Training", 45, 4);
        strength.StartWorkout();
        strength.EndWorkout();
    }
}
