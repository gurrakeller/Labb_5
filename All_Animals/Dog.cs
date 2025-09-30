namespace Labb_5;

    public class Dog : Animal
    {
        public string AutoMail { get; set; }
        public string CanFly { get; set; } = "Yes, dogs can indeed fly.";
        public Dog(string name, int age, string sound, string size, int kgWeight, string autoMail)
            : base(name, age, sound, size, kgWeight)
        {
            AutoMail = autoMail;
        }
        public string DogFact()
        {
            return $"Have you ever wondered, can dogs fly? Well, youre in luck because i have the answer. {CanFly} This is because all dogs go to heaven";
        }

    }