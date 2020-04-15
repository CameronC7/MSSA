using System;

namespace MathGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Math Games");
            int probType;
            int numProb;
            int score = 0;
            (probType, numProb) = Game.Initialize();
            if (probType == 1)
            {
                score = Game.Add(numProb);
            }
            else if (probType == 2)
            {
                score = Game.Subtract(numProb);
            }
            else if (probType == 3)
            {
                score = Game.Multiply(numProb);
            }
            else if (probType == 4)
            {
                score = Game.Divide(numProb);
            }
            string report = Game.Report(score, numProb);
            Console.WriteLine(report);
        }
    }
}
