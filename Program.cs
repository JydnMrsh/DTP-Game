using System;
using System.Collections.Generic;

namespace DTP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            bool invalid = false;

            int playerScore = 0;

            List<string> nonRecyclable = new List<string>()
            {
                "a used nappie",
                "some batteries",
                "a plastic bag",
                "some food scraps",
                "some garden waste",
                "some building waste",
                "some clothing",
                "a pair of shoes",
                "some electronics",
                "a polystyrene meat tray",
                "a lightbulb",
                "some window glass",
            };

            List<string> recyclable = new List<string>()
            {
                "a plastic bottle",
                "a plastic container",
                "a clear plastic food container",
                "a glass bottle",
                "an aluminuim can",
                "a tin can",
                "a newspaper",
                "some cardboard",
                "an egg carton",
                "an opened envolope",
            };

            Console.WriteLine("Your lifelong dream of working at the recycling plant has come true, you are working at the");
            Console.WriteLine("sorting facility and have to distinguish between if something can be recycled or not.");
            Console.WriteLine("==========================================================================================================");

            do
            {
                Console.WriteLine("Are you ready to begin work?");
                Console.WriteLine("Enter y for yes");
                Console.WriteLine("==========================================================================================================");
                string ready = Console.ReadLine();

                // User is ready to begin.
                if (ready == "y")
                {
                    break;
                }
            }
            while (true);

            // Choses a random object from one of the lists and then displays it in a question format and asks.
            do
            {
                Random rnd = new Random();
                int listNum = rnd.Next(1, 3);

                if (listNum == 1)
                {
                    var random = new Random();
                    int index = random.Next(recyclable.Count);

                    do
                    {
                        Console.WriteLine("==========================================================================================================");
                        Console.WriteLine(recyclable[index] + " needs to be sorted, which bin will you put it in?");
                        Console.WriteLine("Type 1 - Recycle bin");
                        Console.WriteLine("Type 2 - Waste bin");
                        Console.WriteLine("==========================================================================================================");
                        string answer = Console.ReadLine();

                        if (answer == "1")
                        {
                            Console.WriteLine("==========================================================================================================");
                            Console.WriteLine("That's correct!");
                            playerScore = playerScore + 1;
                            Console.WriteLine("score: " + playerScore);
                            invalid = false;
                        }
                        else if (answer == "2")
                        {
                            Console.WriteLine("==========================================================================================================");
                            Console.WriteLine("That's incorrect.");
                            playerScore = playerScore - 1;
                            Console.WriteLine("score: " + playerScore);
                            invalid = false;
                        }
                        else
                        {
                            Console.WriteLine("==========================================================================================================");
                            Console.WriteLine("Invalid!");
                            invalid = true;
                            continue;
                        }
                    }
                    while (invalid == true);

                }
                else
                {
                    var random = new Random();
                    int index = random.Next(nonRecyclable.Count);

                    do
                    {

                        Console.WriteLine("==========================================================================================================");
                        Console.WriteLine(nonRecyclable[index] +  " needs to be sorted, which bin will you put it in?");
                        Console.WriteLine("Type 1 - Recycle bin");
                        Console.WriteLine("Type 2 - Waste bin");
                        Console.WriteLine("==========================================================================================================");
                        string answer = Console.ReadLine();

                        if (answer == "2")
                        {
                            Console.WriteLine("==========================================================================================================");
                            Console.WriteLine("That's correct!");
                            playerScore = playerScore + 1;
                            Console.WriteLine("score: " + playerScore);
                            invalid = false;
                        }
                        else if (answer == "1")
                        {
                            Console.WriteLine("==========================================================================================================");
                            Console.WriteLine("That's incorrect.");
                            playerScore = playerScore - 1;
                            Console.WriteLine("score: " + playerScore);
                            invalid = false;
                        }
                        else
                        {
                            Console.WriteLine("==========================================================================================================");
                            Console.WriteLine("Invalid!");
                            invalid = true;
                            continue;
                        }
                    }
                    while (invalid == true);
                }

                if (playerScore == -5 || playerScore == 10)
                {
                    repeat = false;
                }
            }
            while (repeat == true);

            if (playerScore == -5)
            {
                Console.WriteLine("==========================================================================================================");
                Console.WriteLine("Your boss is" +
                    " not happy! You have been putting too many items in the wrong bins and are going to get fired!");
            }

            if (playerScore == 10)
            {
                Console.WriteLine("==========================================================================================================");
                Console.WriteLine("Congratulations! Your boss is happy with your work and you will be getting extra pay this week.");
            }
        }
    }
}
