using System;

class SimpleGoal : Goal{
    protected bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base (name,description,points){
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base (name,description,points){
        _isComplete = isComplete;
    }
    public override int RecordEvent(){
        if(_isComplete == true){
            return 0;
        } else {
            _isComplete = true;
            return _points;
        }
    }

    public override bool IsComplete(){
        return _isComplete;
    }
    public override string GetStringRepresentation(){
        return "Simple Goal:"+"|"+_shortName+"|"+_description+"|"+_points+"|"+_isComplete;
    }

}