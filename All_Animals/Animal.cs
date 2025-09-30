namespace Labb_5;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sound { get; set; }
    public string Size { get; set; }
    public int KgWeight { get; set; }

    public Animal(string  name, int age, string sound, string size, int kgWeight)
    {
        Name = name;
        Age = age;
        Sound = sound;
        Size = size;
        KgWeight = kgWeight;
    }

    public string MakeSound()
    {
        return $"{Name} says {Sound}!";
    }

    public string GetInfo()
    {
        return $"Here's your animal! \nName: {Name}\nAge: {Age}\nSound: {Sound}\nSize: {Size}\nWeight in kg: {KgWeight} ";
    }

    public string AnimalWeight()
    {
        if (KgWeight < 10 && KgWeight > 5)
        {
            return $"{Name} is quite heavy!";
        }
        else if(KgWeight < 5)
        {
            return $"{Name} is quite small!";
        }
            return $"{Name} very big!";
    }
    
    
}