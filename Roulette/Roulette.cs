using System;
using System.Threading;

namespace Roulette
{
    class Roulette
    {
        static void Main(string[] args)
        {
            //Creating a 2 second delay to use with the Thread.Sleep method
            int milliseconds = 2000;
            //Creating a random number from 1-38 to use on the wheel method
            var random = new Random();
            int randomColumn = 0;
            int randomIndex = random.Next(12);
            //Intro to the game
            Console.WriteLine("Welcome to Roulette!");
            //Console.WriteLine("Press any key to spin the wheel");
            //Console.ReadLine();
           // Console.WriteLine("The wheel is spinning...");
           //Thread.Sleep(milliseconds);
            //Winning number is selected and winning bets are printed
            int winningNumber = wheel(randomColumn, randomIndex);
            evenOddBet(winningNumber);
            lowHighBet(winningNumber);
            dozensBet(winningNumber);
            columnBet(randomColumn);
        }

        static int wheel(int column, int index)
        {
            int[][] numbersColumns = new int[3][];
            int[] column0 = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] column1 = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] column2 = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            numbersColumns[0] = column0;
            numbersColumns[1] = column1;
            numbersColumns[2] = column2;
            int[] winningColumn = numbersColumns[column];
            int winningNumber = winningColumn[index];

            string[][] colorsColumns = new string[3][];
            string[] colorColumn0 = new string[] { "Red", "Black", "Red", "Black", "Black", "Red", "Red", "Black", "Red", "Black", "Black", "Red" };
            string[] colorColumn1 = new string[] { "Black", "Red", "Black", "Black", "Red", "Black", "Black", "Red", "Black", "Black", "Red", "Black" };
            string[] colorColumn2 = new string[] { "Red", "Black", "Red", "Red", "Black", "Red", "Red", "Black", "Red", "Red", "Black", "Red" };
            colorsColumns[0] = colorColumn0;
            colorsColumns[1] = colorColumn1;
            colorsColumns[2] = colorColumn2;

            string[] winningColorColumn = colorsColumns[column];
            string winningColor = winningColorColumn[index];

            Console.WriteLine($"The winning number is {winningNumber} and the color is {winningColor}");
            return winningNumber;
        }

        static void evenOddBet(int number)
        {
            if (number == 0 || number == 00)
            {
                Console.WriteLine("Neither odd or even win!");
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("The even bet win!");
            }
            else
            {
                Console.WriteLine("The odd bet win!");
            }
        }
        static void lowHighBet(int number)
        {
            if (number == 0 || number == 00)
            {
                Console.WriteLine("Neither low or high win!");
            }
            if (number < 19)
            {
                Console.WriteLine("The low bet win!");
            }
            else
            {
                Console.WriteLine("The high bet win!");
            }
        }
        static void dozensBet(int number)
        {
            if (number == 0 || number == 00)
            {
                Console.WriteLine("No dozen bets win!");
            }
            if (number > 0 && number <= 12)
            {
                Console.WriteLine("First dozen bet win!");
            }
            if (number > 12 && number <= 24)
            {
                Console.WriteLine("Second dozen bet win!");
            }
            if (number > 24)
            {
                Console.WriteLine("Third dozen bet win!");
            }
        }
        static void columnBet(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("First column bet win!");
            }
            if (number == 1)
            {
                Console.WriteLine("Second column bet win!");
            }
            if (number == 2)
            {
                Console.WriteLine("Third column bet win!");
            }
        }
    }

}
