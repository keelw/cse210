using System;

class Program
{
    static void Main(string[] args)
    {
        // create the address for the 3 events (will be the same but could use any address object)
        Address address = new Address("555 Evening Crest Dr.", "Herriman", "UT", "United States");

        // create the 3 events
        Lecture lecture = new Lecture("All About Cars", "Come learn how mechanics work on cars!", "March 11, 2011", "11AM MST", address, "Michael Carmichael", 1200);
        Reception reception = new Reception("Keel Wedding", "Come celebrate with us!", "Dec 28, 2021", "8PM MST", address, "john.appleseed@gmail.com");
        Outdoor outdoor = new Outdoor ("Garden Tour", "Come see our revolutionary gardens!", "May 11, 2015", "9AM-9PM EST", address, "Bring jackets! It's going to be raining!");

        // call each of the 3 methods for each of the 3 events
        Console.WriteLine("Lecture... ");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("");

        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("");

        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("");
        Console.WriteLine("");


        Console.WriteLine("Reception... ");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("");


        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("");

        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("");
        Console.WriteLine("");


        Console.WriteLine("Outdoor Activity... ");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine("");


        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine("");

        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine("");
    }
}