namespace Labb_5;

public class Bird : Animal
{
    public int FlapPS{get;set;}
    public Bird(string name, int age, string sound, string size, int kgWeight, int flapPS)
        : base(name, age, sound, size, kgWeight)
    {
        FlapPS = flapPS;
    }

    public override string ToString()
    {
        return "this bird can flap " + FlapPS.ToString() + " times per minute";
    }
}