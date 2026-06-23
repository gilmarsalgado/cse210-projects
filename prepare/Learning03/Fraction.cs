public class Fraction{
    //Attributes for the top and bottom numbers
    private int _top;
    private int _bottom;
    // Constructors
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;

    }
    public Fraction(int top,int bottom){
        _top = top;
        _bottom = bottom;
    }
    // Get and set for the top and bottom numbers
    public int GetTop(){
        return _top; // CHANGE
    }
    public void SetTop(int top){
        _top = top;
    }   
    public int GetBottom(){
        return _bottom;
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
    }
    // Methods to return representations of both the fractional and decimal views
    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }
    public double DecimalValue(){
        return (double)_top / (double)_bottom;  
    }
}