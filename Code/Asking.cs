using Microsoft.VisualBasic;
using System.ComponentModel;

namespace Chameleon
{
    class Asking
    {
        //Initialising variables for the Pointcounter
        public int pointsMax;
        public int points;

        //Method to Choose which method you want to make.
        public int Choosing()
        {
            //Selfexplainable
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Type 1 or 2\n"
                        + "1. Main to Forignlanguage\n" +
                          "2. Forignlanguage to Main\n");
                    int i = Convert.ToInt32(Console.ReadLine());
                    if (i == 1 || i == 2)
                    {
                        return i;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Please type a number between 1 and 2.");
                    Thread.Sleep(1500);
                }
            }
        }
        //This is the method if you've chosen 1 în the Choosing method
        public void MainToForign(List<string> main, List<string> forign) 
        {
            for (int i = 0; i < forign.Count; i++)
            {
                int tries = 0;
                while (true)
                {
                    //Writes a word from the main list and User answers
                    Console.Clear();
                    string answer;
                    Console.Write($"{main[i]} ---> ");
                    answer = Console.ReadLine();
                    tries++;
                    //Check if answer is right or not.
                    if (answer.ToLower() == forign[i].ToLower())
                    {
                        //Counts the tries for calculating the points
                        Console.WriteLine("Correct!");
                        //Refers to the Pointscounter method
                        PointsCounter(main, tries);
                        Thread.Sleep(250);
                        break;
                    }
                    //Changes the word if you had over 3 tries
                    else if (tries >= 3)
                    {
                        Console.WriteLine($"The answer was: \"{forign[i]}\" press enter to continue.");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                        Thread.Sleep(250);
                    }
                }
            }
        }
        //Pls look to the other method (MainToForign) its literally the same but with switched variables
        public void ForignToMain(List<string> main, List<string> forign)
        {
            for (int i = 0; i < forign.Count; i++)
            {
                int tries = 0;
                while (true)
                {
                    
                    Console.Clear();
                    string answer;
                    Console.Write($"{forign[i]} ---> ");
                    answer = Console.ReadLine();
                    tries++;

                    if (answer.ToLower() == main[i].ToLower())
                    {
                        Console.WriteLine("Correct!");
                        PointsCounter(main, tries);
                        Thread.Sleep(250);
                        break;
                    }
                    else if (tries >= 3)
                    {
                        Console.WriteLine($"The answer was: \"{main[i]}\" press enter to continue.");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                        Thread.Sleep(250);
                    }
                }
            }
        }
        public void PointsCounter(List<string> list, int tries)
        {
            //Calculates the maxpoints
            pointsMax = list.Count * 100;

            //Calculates the points
            points += 100 / tries;

        }
        public void DisplayPoints()
        {
            //Displays the earned points.
            Console.WriteLine($"You have {points} out of {pointsMax} points.");
        }
    }
}