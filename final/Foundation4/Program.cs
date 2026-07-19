using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Running running= new Running("03 Nov 2022",30,3);
        running.GetActivitySummary("Running");

        Biking biking= new Biking("04 Nov 2022",60,12);
        biking.GetActivitySummary("Biking");

        Swimming swimming= new Swimming("05 Nov 2022",20,10);
        swimming.GetActivitySummary("Swimming");
    }
}