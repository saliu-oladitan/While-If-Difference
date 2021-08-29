using System;

namespace While_If_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            //This is the while statement
            while (name == "")
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
            }

            // This is the if statement. Comment the while statement and Uncomment the following code and see the difference.
            //if (name == "")
            //    {
            //        Console.WriteLine("What is your name?");
            //        name = Console.ReadLine();
            //    }




        }
    }
}
