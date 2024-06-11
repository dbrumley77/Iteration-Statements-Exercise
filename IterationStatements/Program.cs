namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintNumbersByThree()
        {
            for (int i = 3; i <= 999; i+= 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        public static bool AreTheyEqual (int number1, int number2)
        {
            if (number1 == number2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method to check whether a given number is even or odd
        
        public static void IsEvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void IsPositiveOrNegative(int number)
        {
            if(number > 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else if(number < 0)
            {
                Console.WriteLine($"{number} is negative");
            }
            else
            {
                Console.WriteLine($"{number} is neutral");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CheckAgeForVoting()
        {
            Console.WriteLine("What is your age");
            string userInput = Console.ReadLine();

            int age = int.Parse(userInput);

            if (age >= 18)
            {
                Console.WriteLine("Congrats, you can vote!");
            }
            else 
            {
                Console.WriteLine("Sorry, not old enough");
            }

        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void CheckIfInRange()
        {
            Console.WriteLine("Please enter a number and I will see if it is in range.");
            string userInput = Console.ReadLine();
            int answer = int.Parse(userInput);

            if (answer <= 10 && answer >=-10)
            {
                Console.WriteLine($"{answer} is in range");
            }
            else
            {
                Console.WriteLine($"{answer} is not in range");
            }

        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        public static void MultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }

        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintNumbers();
            //PrintNumbersByThree();
            //Console.WriteLine(AreTheyEqual(6, 8));
            //IsEvenOrOdd(625);
            //IsPositiveOrNegative(0);
            //CheckAgeForVoting();
            //CheckIfInRange();
            //MultiplicationTable(8);

        }
    }
}
