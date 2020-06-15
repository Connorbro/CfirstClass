using System;

namespace introduction
{
    class AgeCalculator
    {
        public void Calculator(int age)
        {
           
            if(age <= 17)
            {
                Console.WriteLine("Not allowed in mate too young!");
            }
            else if(age < 40 && age > 17)
            {
                Console.WriteLine("Allowed in all night");
            }
            else if(age < 65 && age > 39)
            {
                Console.WriteLine("Allowed in but you must leave by 11pm");
            }
            else if(age > 65 && age < 115)
            {
                Console.WriteLine("Must be accompanied by an adult!");
            }
            else
            {
                Console.WriteLine("No one is that old fella, stop lying!");
            }
        }
    }
}