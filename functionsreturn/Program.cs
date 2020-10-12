using System;

namespace functionsreturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your year of birth: ");
            string userInput = Console.ReadLine();
            int userAge = CalculateAge(userInput);
            Console.WriteLine($"you are {userAge} years old");
        }
        public static int CalculateAge(string userInput)
        {
            int userAge = 2020 - Int32.Parse(userInput);
            return userAge;
        }
        public static void ValidateAge()
        {
            if(zzzzAge < 18)
            {
                Console.WriteLine("you are not old enough to drive a car.");
            }else
            {
                Console.WriteLine("go get it!");
            }
        }

    }
}
