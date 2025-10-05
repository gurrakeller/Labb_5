using System.Runtime.InteropServices.ComTypes;
using Labb_5.Dog_Sub_Classes;

namespace Labb_5;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Dog", 3, "woof", "medium", 15, "some breeds can have");
        Cat myCat = new Cat("Sophie (the name of my actual cat, based on howl's moving castle, fun fact)", 3, "Meow", "small", 3, "carnivore");
        Bird myBird = new Bird("Bird", 2, "Caw Caw", "small", 1, 100);
        //subclasses of dog V
        Bulldog myBulldog = new Bulldog("Bulldog", 5, "WOOF WOOF WOOF", "medium", 10, "can have (cause they are tought)", "ALOT");
        Chihuahua myChihuahua = new Chihuahua("Chihuahua", 10, "WOOF WOOF WOOF WOOF WOOF WOOF", "small", 4, "cannot have automail", "FOUL");
        
        Console.WriteLine(myDog.MakeSound());
        Console.WriteLine(myCat.MakeSound());
        Console.WriteLine(myBird.MakeSound());
        Console.WriteLine(myBulldog.MakeSound());
        Console.WriteLine(myChihuahua.MakeSound());
        
        
    }
}