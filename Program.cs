using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practicing while/do while loops
            Console.WriteLine("Please enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            int Begining = 0;

            //Is 0 greater then or equil to the user's input
            while (Begining <= userInput)
            {
                Console.WriteLine(Begining);
                Begining += 2;
            }
        }
    }
}
