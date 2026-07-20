using System;

class Biking : Activity{
    private double _speed;

    public Biking(string date,double minutes,double speed) : base(date,minutes){
        _speed = speed;
    }

    public override double GetDistance()
    {
        return GetMinutes()/60 * _speed;
    }


}