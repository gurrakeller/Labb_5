namespace Labb_5;

public class CustomAnimal : Animal
{
    public string makeAnimal()
    {
        Console.WriteLine("Name: ");
        string Name = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine("Age: ");
        int Age = int.Parse(Console.ReadLine());
        Console.Clear();
        
        Console.WriteLine("Sound: ");
        string Sound = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine("Size S/M/L: ");
        string Size = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine("Weight in kg:");
        int Weight = int.Parse(Console.ReadLine());
        Console.Clear();
        
        return $"{Name} {Age} {Sound} {Size} {Weight}";
    }
    

    public CustomAnimal(string name, int age, string sound, string size, int kgWeight) : base(name, age, sound, size, kgWeight)
    {
        
    }
}