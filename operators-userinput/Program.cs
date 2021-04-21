using System;

namespace operators_userinput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting user for their first name
            Console.WriteLine("What is your first name?");

            //Taking users input and storing it in a string variable
            string firstName = Console.ReadLine();

            //Prompting user for their last name
            Console.WriteLine("What is your last name?");

            //Taking users input and storing it in a string variable
            string lastName = Console.ReadLine();

            //Using string interpolation to write a message to the Console using the user's first and last name

            Console.WriteLine($"Hello {firstName} {lastName}!");


            Console.WriteLine("Press ENTER to Exit");
            Console.ReadLine();

            //Prompting user for input
            Console.WriteLine("What is your age?");


            //This takes in a user's input, converts it to an integer, and then stores it into
            //an integer variable.
            int age = Convert.ToInt16(Console.ReadLine());

            //or

            //int age = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Press ENTER to Exit");
            Console.ReadLine();


            //Prompt the user for their weight and store their response in a double variable
            Console.WriteLine("What is your weight?");
            int weight = (int)double.Parse(Console.ReadLine());


            //Prompt the user for their middle initial and store their response in a character variable
            Console.WriteLine("What is your middle initial?");
            char middleInitial = char.Parse(Console.ReadLine());

            //Prompt the user to enter true of they have watched Harry Potter or false if they have not and store their reply in a boolean variable
            Console.WriteLine("True or False: You watched Harry Potter?");
            bool harryPotter = Convert.ToBoolean(Console.ReadLine());

            //Print all these values to the Console
            Console.WriteLine($"Your weight is {weight} and your middle initial is {middleInitial}. It is {harryPotter} that you have seen Harry Potter.");

            //Declare two integer variables
            int int1 = 45;
            int int2 = 26;
            Console.WriteLine($"This is the first declared interger: {int1} This is the second delcared interger: {int2}");
            //Find the sum of those two variables(+)
            int sum = int1 + int2;
            Console.WriteLine($"This is the sum of two declared intergers: {sum}");
            //Find the difference of those two variables(-)
            int difference = int1 - int2;
            Console.WriteLine($"This is the difference of two declared intergers: {difference}");
            //Find the product of those two variables(*)
            int product = int1 * int2;
            Console.WriteLine($"This is the product of two declared intergers: {product}");

            //Find the quotient of those two variables(/)
            int quotient = int1 / int2;
            Console.WriteLine($"This is the quotient of two declared intergers: {quotient}");
            //Find the remainder of those two variables(%)
            int remainder = int1 % int2;
            Console.WriteLine($"This is the remainder of two delcared intergers: {remainder}");

            Console.WriteLine("Press ENTER to Exit");
            Console.ReadLine();
        }
    }
}
