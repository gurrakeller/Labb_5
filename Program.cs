using System.Runtime.InteropServices.ComTypes;
using Labb_5.Dog_Sub_Classes;

namespace Labb_5;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Kalle", 3, "woof", "medium", 15);
        Cat myCat = new Cat("Sophie", 3, "Meow", "small", 3);
        Bird myBird = new Bird("Carrot", 2, "Caw Caw", "small", 1);
        //subclasses of dog V
        Bulldog myBulldog = new Bulldog("Brutus", 5, "WOOF WOOF WOOF", "medium", 10);
        Chihuahua myChihuahua = new Chihuahua("demon_spawn", 10, "WOOF WOOF WOOF WOOF WOOF WOOF", "small", 4);
        
        Console.WriteLine(myChihuahua.MakeSound());
        
    }
}