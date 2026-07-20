using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Running dailyRun= new Running("03 Nov 2022",30,3);

        Biking dailyBike= new Biking("04 Nov 2022",60,12);

        Swimming dailySwim= new Swimming("05 Nov 2022",20,10);

        List<Activity> activities = new List<Activity>();

        activities.Add(dailyRun);
        activities.Add(dailyBike);
        activities.Add(dailySwim);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary(activity.GetType().Name));
        }
    }
}