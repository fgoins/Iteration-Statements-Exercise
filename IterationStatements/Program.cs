using System.Runtime.InteropServices;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void count() 
        {
         for (int i = -1000; i <=1000; i++)
         {
                Console.WriteLine($"{i}");
         }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void iterations() 
        {
          for ( int i = 3; i <= 999; i+=3)
          {
                Console.WriteLine($"{i}");
          }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void equalto(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("these numbers are equal");

            }
            else 
            {
                Console.WriteLine("these numbers are not equal");
            }
        }
        
        //Write a method to check whether a given number is even or odd
        public static void evenodd(int num) 
        {
            if (num % 2 ==0)
            {
                Console.WriteLine($"{num} is even");
            }
            else 
            {
                Console.WriteLine($"{num} is odd");
            }
        }
        
        //Write a method to check whether a given number is positive or negative
        public static void posneg(int num)
        {
            if (num <= 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else 
            {
                Console.WriteLine($"{num} is negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void vote() 
        {
            Console.WriteLine("how old are you?");
            int num =int.Parse(Console.ReadLine());
            if (num >= 18)
            {
                Console.WriteLine("you can vote!");
            }
            else 
            {
                Console.WriteLine("sorry your too young to vote at this time.");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void range() 
        {
            Console.WriteLine("pick a number between -10 and 10?");
            int num = int.Parse(Console.ReadLine());
            if (num >= -10 && num <= 10)
            {
                Console.WriteLine($"{num} you are with in range.");
            }
            else 
            {
                Console.WriteLine($"{num} is not within rage.");
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
    


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            count();
            iterations();
            equalto(40, 40);
            evenodd(8);
            posneg(55);
           vote();
           range();
        }
    }
}
