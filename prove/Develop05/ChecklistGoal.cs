using System;

class ChecklistGoal : Goal{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, int points,int target, int bonus):base(name, description, points){
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, int points,int bonus,int target,int amountCompleted):base(name, description, points){
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {   
        if(_amountCompleted == _target){
            return _bonus;
        } else if(_amountCompleted > _target){
            return _points;
        } else {
            _amountCompleted += 1;
            return _points;
        }
    }

    public override bool IsComplete()
    {
        if(_amountCompleted == _target){
            return true;
        } else {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string check = " ";
        if(IsComplete()){check = "X";}
        return $"[{check}] {_shortName} ({_description}) --- Currently Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return "Check List Goal:"+"|"+_shortName+"|"+_description+"|"+_points+"|"+_bonus+"|"+_target+"|"+_amountCompleted;
    }

}