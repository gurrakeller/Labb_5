namespace Labb_5.Dog_Sub_Classes;

public class Chihuahua : Dog
{
    public string Mood { get;}
    public Chihuahua(string name, int age, string sound, string size, int kgWeight,string autoMail, string mood)
        : base(name, age, sound, size, kgWeight, autoMail)
    {
        Mood = mood;
    }   

    public string ChihuahuaFact()
    {
        return $"{Name}, also known as son on Baphomet, neither demon nor angel; but balance, but well...\nin the Chihuahuas case, mostly demon.. which is why we class their mood as: {Mood}";
    }
    
}