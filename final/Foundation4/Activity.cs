using System;

abstract class Activity{
    private string _date;
    private double _minutes;

    public Activity(string date, double minutes){
        _date = date;
        _minutes = minutes;
    }

    public virtual string GetSummary(string sport){
        return $"{_date} {sport} ({_minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} k/h, Pace: {GetPace()} min/km";
    }

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
}