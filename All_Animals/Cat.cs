namespace Labb_5;

public class Cat : Animal
{   
    public string Consumption { get;}
    public Cat(string name, int age, string sound, string size, int kgWeight, string consumption)
        : base(name, age, sound, size, kgWeight)
    {
        Consumption = consumption;
    }

    public string CatFact()
    {
        return $"The cat is a APEX predator, a {Consumption} of frightening power; Moving in the shadows, stalking its prey. As a close relative to the tiger\nthe cat demands respect.";
    }
    
}
