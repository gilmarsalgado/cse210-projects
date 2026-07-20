using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        
Lecture lecture = new Lecture("The Life of a CompEng Student","Come hear about what life is like for a student of Computer Engineering","8/25/2026","10:00am",new Address("525 S Center St","Rexburg","ID","USA"),"Brother Gilmar Salgado",200);        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

Reception reception = new Reception("Returned Missionary Reunion","A gathering to welcome returned missionaries and their families","9/10/2026","6:00pm",new Address("50 E North Temple St","Salt Lake City","UT","USA"),"fakeevents@fakechurchemail.org");        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

Outdoor outdoor = new Outdoor("Brazil Youth Conference","A youth gathering with activities, games, and spiritual messages","12/15/2026","9:00am",new Address("Av. Paulista 1000","São Paulo","SP","Brazil"),"Warm weather with a chance of afternoon rain");        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetShortDescription());
    }
}