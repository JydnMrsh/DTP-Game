using System;
using System.Collections.Generic;

namespace DTP_Game
{
    class Program
    {

        static bool invalid = false;

        static int playerScore = 0;

        static List<string> nonRecyclable = new List<string>()
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

        static List<string> recyclable = new List<string>()
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

        public static void LineBreak()
        {
            for (int i = 0; i < 106; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }

        public static void ListPicker(List<string> list) // Takes whatever list is randomly chosen and chooses a random object from that list and asks a question with it and checks the users answer.
        {
            var random = new Random();
            int index = random.Next(list.Count);

            do
            {
                LineBreak();
                Console.WriteLine(list[index] + " needs to be sorted, which bin will you put it in?");
                Console.WriteLine("Type 1 - Recycle bin");
                Console.WriteLine("Type 2 - Waste bin");
                LineBreak();
                string answer = Console.ReadLine();

                if (answer == "1" && list == recyclable || answer == "2" && list == nonRecyclable)
                {
                    Console.Clear();
                    LineBreak();
                    Console.WriteLine("That's correct!");
                    playerScore = playerScore + 1;
                    Console.WriteLine("score: " + playerScore);
                    invalid = false;
                }
                else if (answer == "2" && list == recyclable || answer == "1" && list == nonRecyclable)
                {
                    Console.Clear();
                    LineBreak();
                    Console.WriteLine("That's incorrect.");
                    playerScore = playerScore - 1;
                    Console.WriteLine("score: " + playerScore);
                    invalid = false;
                }
                else
                {
                    Console.Clear();
                    LineBreak();
                    Console.WriteLine("Invalid!");
                    invalid = true;
                    continue;
                }
            }
            while (invalid == true);
        }

        static void Main(string[] args)
        {
            bool repeat = true;

            Console.WriteLine("Your lifelong dream of working at the recycling plant has come true, you are working at the");
            Console.WriteLine("sorting facility and have to distinguish between if something can be recycled or not.");
            LineBreak();

            do
            {
                Console.WriteLine("Are you ready to begin work?");
                Console.WriteLine("Enter y for yes");
                LineBreak();
                string ready = Console.ReadLine();

                // User is ready to begin.
                if (ready == "y")
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
                LineBreak();
            }
            while (true);

            // Choses a random list and inputs it into my list picker function
            do
            {
                Random rnd = new Random();
                int listNum = rnd.Next(1, 3);

                if (listNum == 1)
                {
                    ListPicker(recyclable);
                }
                else if (listNum == 2)
                {
                    ListPicker(nonRecyclable);
                }

                if (playerScore == -5 || playerScore == 10)
                {
                    repeat = false;
                }
            }
            while (repeat == true);


            if (playerScore == -5)
            {
                Console.Clear();
                LineBreak();
                Console.WriteLine("Your boss is" +
                    " not happy! You have been putting too many items in the wrong bins and are going to get fired!");
                LineBreak();
            }

            if (playerScore == 10)
            {
                Console.Clear();
                LineBreak();
                Console.WriteLine("Congratulations! Your boss is happy with your work and you will be getting extra pay this week.");
                LineBreak();
            }
        }
    }
}