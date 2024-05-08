using System;
class Person 
{
    public string givenName;
    public string familyName;

    // Constructor (instantiates)
    public Person (string givenName, string familyName) 
    {
        // empty for now
        this.givenName = givenName;
        this.familyName = familyName;
    }

    public void EasternStyleName () 
    {
        Console.WriteLine($"{this.familyName}, {this.givenName}");
    }

    public void WesternStyleName () 
    {
        Console.WriteLine($"{this.givenName}, {this.familyName}");
    }
}