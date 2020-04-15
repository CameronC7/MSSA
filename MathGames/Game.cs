using System;
using System.Collections.Generic;
using System.Text;

namespace MathGames
{
    class Game
    {
        public static (int, int) Initialize()
        {
            Console.WriteLine("\tTo add, enter 1,");
            Console.WriteLine("\tTo subtract, enter 2,");
            Console.WriteLine("\tTo multiply, enter 3,");
            Console.WriteLine("\tTo divide, enter 4.");
            Console.Write("\nChoose your problem type: ");
            int probType = Int32.Parse(Console.ReadLine());
            if (probType < 1 || probType > 4)
            {
                Console.WriteLine("Sorry you made an invalid choice");
                Initialize();
            }
            Console.Write("Enter number of problems you want to solve between 1 and 12: ");
            int numbProb = Int32.Parse(Console.ReadLine());
            if (numbProb < 1 || numbProb > 12)
            {
                Console.WriteLine("Sorry you made an invalid choice");
                Initialize();
            }
            return (probType, numbProb);
        }

        public static int Add(int amount)
        {
            Console.WriteLine($"You are testing Addition and you have {amount} problems");
            Console.WriteLine("To begin your test, type any key:");
            Console.ReadKey();
            int score = 0;
            for (int i = 0; i < amount; i++)
            {
                Random random = new Random();
                int q1 = random.Next(13);
                int q2 = random.Next(13);
                if (q2 > q1)
                {
                    Console.Write($"{i + 1}. {q2} + {q1} = ");
                    int answer = Int32.Parse(Console.ReadLine());
                    int correctAnswer = q2 + q1;
                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
                    }
                }
                else
                {
                    Console.Write($"{i + 1}. {q1} + {q2} = ");
                    int answer = Int32.Parse(Console.ReadLine());
                    int correctAnswer = q1 + q2;
                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
                    }
                }
            }
            return score;
        }

        public static int Subtract(int amount)
        {
            Console.WriteLine($"You are testing Subtraction and you have {amount} problems");
            Console.WriteLine("To begin your test, type any key:");
            Console.ReadKey();
            int score = 0;
            for (int i = 0; i < amount; i++)
            {
                Random random = new Random();
                int q1 = random.Next(13);
                int q2 = random.Next(13);
                if (q2 > q1)
                {
                    Console.Write($"{i + 1}. {q2} - {q1} = ");
                    int answer = Int32.Parse(Console.ReadLine());
                    int correctAnswer = q2 - q1;
                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
                    }
                }
                else
                {
                    Console.Write($"{i + 1}. {q1} - {q2} = ");
                    int answer = Int32.Parse(Console.ReadLine());
                    int correctAnswer = q1 - q2;
                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
                    }
                }
            }
            return score;
        }

        public static int Multiply(int amount)
        {
            Console.WriteLine($"You are testing Multiplication and you have {amount} problems");
            Console.WriteLine("To begin your test, type any key:");
            Console.ReadKey();
            int score = 0;
            for (int i = 0; i < amount; i++)
            {
                Random random = new Random();
                int q1 = random.Next(13);
                int q2 = random.Next(13);
                if (q2 > q1)
                {
                    Console.Write($"{i + 1}. {q2} * {q1} = ");
                    int answer = Int32.Parse(Console.ReadLine());
                    int correctAnswer = q2 * q1;
                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
                    }
                }
                else
                {
                    Console.Write($"{i + 1}. {q1} * {q2} = ");
                    int answer = Int32.Parse(Console.ReadLine());
                    int correctAnswer = q1 * q2;
                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
                    }
                }
            }
            return score;
        }

        public static int Divide(int amount)
        {
            Console.WriteLine($"You are testing Division and you have {amount} problems");
            Console.WriteLine("To begin your test, type any key:");
            Console.ReadKey();
            int score = 0;
            for (int i = 0; i < amount; i++)
            {
                Random random = new Random();
                double q1 = random.Next(1, 13);
                double q2 = random.Next(1, 13);
                if (q2 > q1)
                {
                    Console.Write($"{i + 1}. {q2} / {q1} = ");
                    double answer = Convert.ToDouble(Console.ReadLine());
                    double correctAnswer = Math.Round((q2 / q1), 2);
                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
                    }
                }
                else
                {
                    Console.Write($"{i + 1}. {q1} / {q2} = ");
                    double answer = Convert.ToDouble(Console.ReadLine());
                    double correctAnswer = Math.Round((q1 / q2), 2);
                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
                    }
                }
            }
            return score;
        }

        public static string Report(int score, int numProb)
        {
            double grade = Math.Round(100 * ((double)score / (double)numProb));
            string report = $"\nYou got {score} out of {numProb} correct and your grade is {grade}%";
            return report;
        }
    }
}
