using System;

abstract class Activity{
    private string _date;
    private double _minutes;

    public Activity(string date, double minutes){
        _date = date;
        _minutes = minutes;
    }

    public virtual string GetSummary(string sport){
        return $"{_date} {sport} ({_minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km, Calories: {GetCalories()} kcal";    }

    public abstract double GetDistance();

    public double GetSpeed(){
        return GetDistance()/_minutes * 60;
    }

    public double GetPace(){
        return _minutes / GetDistance();
    }

    public double GetMinutes(){
    return _minutes;
}
    public double GetCalories(){ //Adding extra method to calculate calories burned during the activity
        return GetDistance() * 60;
    }
}