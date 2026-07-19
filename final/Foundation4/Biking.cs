using System;

class Biking : Activity{
    protected double _speed;

    public Biking(string date,double minutes,double speed) : base(date,minutes){
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _minutes/60 * _speed;
    }


}