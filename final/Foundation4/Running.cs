using System;

class Running : Activity{
    protected double _distance;

    public Running(string date,double minutes,double distance) : base(date,minutes){
        _distance = distance;
    }
    public override double GetDistance(){
        return _distance;
    }

}