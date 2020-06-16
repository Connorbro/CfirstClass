using System;
// a library that will be essential for the majority of the first week...
// without it... we will have lengthy paths

namespace introduction
// Any class inside of the namespace will be available...

{
    
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics maths = new Mathematics();
            Encapsulation example = new Encapsulation();
            AgeCalculator checkAge = new AgeCalculator();
            
            example.information();
            example.favGame = "Call of duty";
            Console.WriteLine($"My favourite game is {example.favGame}");
            
            //Console.Write("Please enter your age for an ID check at our club: ");

            // string userInput = Console.ReadLine();
            //checkAge.Calculator(Convert.ToInt32(userInput));

            //double subtractPlease = maths.Subtraction(200, 32);
            
            //Console.WriteLine(subtractPlease);


        }
    }
}
