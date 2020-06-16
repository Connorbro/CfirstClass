using System;

namespace introduction
{
    class Encapsulation
    {
        private string name;
        private double age;
        private string favSport;
        private string jobType;

        public string favGame;
        public void information()
        {
            name = "Connor";
            age = 21;
            favSport = "Football";
            jobType = "Developer";

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"My favourite sport is {favSport}");
            Console.WriteLine($"my job is a {jobType} ");
        }
    }
}