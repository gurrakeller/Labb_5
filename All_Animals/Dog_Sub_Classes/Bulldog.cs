namespace Labb_5.Dog_Sub_Classes;

public class Bulldog : Dog
{
    public string HowManyBellyRubs { get;}
    public Bulldog(string name, int age, string sound, string size, int kgWeight,string autoMail, string howManyBellyRubs)
        : base(name, age, sound, size, kgWeight, autoMail)
    {
        HowManyBellyRubs = howManyBellyRubs;
    }

    public string BulldogFact()
    {
        return $"The {Name} is an animal that requires {HowManyBellyRubs} of belly rubs to stay healthy.";
    }
}