using System;

class Swimming : Activity{
    protected double _laps;

    public Swimming(string date,double minutes,double laps) : base(date,minutes){
            _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
}