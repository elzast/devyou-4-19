﻿using System;

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

        }
    }
}