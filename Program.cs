using System;
// a library that will be essential for the majority of the first week...
// without it... we will have lengthy paths

namespace introduction
// Any class inside of the namespace will be available...

{
    class Mathematics
    {
        // Encapsulation
        public int Addition(int numberOne, int numberTwo) //Capitalised Methods are best!
        {
            return numberOne + numberTwo;
        }

        public int Subtraction(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
        public double Division(double numberOne, double numberTwo)
        {
            return numberOne / numberTwo;
        }
        public int Multiplication(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Mathematics maths = new Mathematics();
            int subtractPlease = maths.Subtraction(200, 32);
            int addMePlease = maths.Addition(10, 40);
            int multiplyMePlease = maths.Multiplication(22, 3);
            double divideMePlease = maths.Division(33, 2.2);
            
            Console.WriteLine(subtractPlease);
            Console.WriteLine(divideMePlease);
        }
    }
}
