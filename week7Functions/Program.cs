﻿using System;

namespace week7Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth: ");
            string userInput = Console.ReadLine();
            CalculateAge(userInput);
        }

        public static void CalculateAge(string yearOfBirth)
        {
            int usersYearOfBirth = Int32.Parse(yearOfBirth);
            Console.WriteLine($"you are {2020 - usersYearOfBirth} years old ");
        }


    }
}
