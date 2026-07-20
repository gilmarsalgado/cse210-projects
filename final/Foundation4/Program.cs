using System;
using System.ComponentModel;


class Program
{
    static void Main(string[] args)
    {
        double totalDistance = 0; //Adding extra variables to calculate total distance and calories
        double totalCalories = 0;

        Running dailyRun= new Running("03 Nov 2022",30,3);

        Biking dailyBike= new Biking("04 Nov 2022",60,12);

        Swimming dailySwim= new Swimming("05 Nov 2022",20,10);

        List<Activity> activities = new List<Activity>();

        activities.Add(dailyRun);
        activities.Add(dailyBike);
        activities.Add(dailySwim);

        Console.WriteLine("");

       foreach(Activity activity in activities)
    {
        Console.WriteLine(activity.GetSummary(activity.GetType().Name));

        totalDistance += activity.GetDistance();
        totalCalories += activity.GetCalories();
    }

        Console.WriteLine("");
        Console.WriteLine($"Total Distance: {totalDistance} km");
        Console.WriteLine($"Total Calories Burned: {totalCalories} kcal");
        Console.WriteLine("");

}
}
