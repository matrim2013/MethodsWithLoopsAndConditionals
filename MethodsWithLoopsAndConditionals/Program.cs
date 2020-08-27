using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {

       
        static void Main(string[] args)
        {
            NumberRange1000();
            UpByThree();
            Console.WriteLine(AreNumbersEqual(2, 5));
            Console.WriteLine(EvenOrOdd(5));
            Console.WriteLine(PosOrNeg(-3));

            Console.WriteLine("How old are you?");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine(VotingAge(age));


        }





       public static void NumberRange1000()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine($"{i}");
            }
        }


        public static void UpByThree()
        {
            for (int i = 0; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }
        }


        public static bool AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }

            else return false;
        }


        public static string EvenOrOdd(int num3)
        {
            return (num3 % 2 == 0) ? "You are even" : "You are odd";
        }


        public static string PosOrNeg(int num4)
        {
             return (num4 > 0) ? "Positive" : "Negative";
        }


        public static string VotingAge(int age)
        {
              return (age >= 18) ? "Cast your vote" : "Go home child";
        }

    }
}
