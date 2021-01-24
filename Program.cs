using System;

namespace While
{
    class Program
    {
        static void Main()
        {
            //Practicing while/do while loops
            Console.WriteLine("Please enter a Number: ");
            int UserNumber = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserNumber)
            {
                //Displayes each number added till the UserNumber is reached. In this case +6.
                //e.g. UserNumber is 50, 0 6 12 18 24 30 36 42 48 is returned to the console
                Console.Write(Start + " ");
                Start += 6;

            }


        }
    }

}

