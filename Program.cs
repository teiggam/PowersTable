using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while(goOn == true)
                {
                string num = GetUserInput("Please enter a whole number from 1 to 1290.");
                Console.WriteLine(num);
                int num1 = int.Parse(num);

                if(num1 >=1 && num1 <= 1290)
                { 
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("=====\t=====\t======");

                for (int c = 1; c <= num1; c++)
                {
                    Console.WriteLine($"{c}   \t{c * c }   \t{c * c * c}");
                }

                bool correctInput = true;
                    while (correctInput == true)
                    {
                        Console.WriteLine("Would you like to enter another number? Y/N");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "y")
                        {
                            correctInput = false;
                            goOn = true;
                        }
                        else if (input.ToLower() == "n")
                        {
                            Console.WriteLine("OK!  Thanks for playing!");
                            goOn = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry, I didn't understand, please try again.");

                        }
                    }
                }
                else
                { Console.WriteLine("That is not a whole number between 1 and 1290.");
                    goOn = true;

                }

            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;

        }
    }
}
