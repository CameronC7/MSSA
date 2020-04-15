using System;

namespace EX6A_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            // Testing ComputingMean method with the given arrays
            Console.WriteLine("Calculating the mean of the array");
            Console.WriteLine(ComputingMean(arrayA));
            Console.WriteLine(ComputingMean(arrayB));
            Console.WriteLine(ComputingMean(arrayC));
            Console.WriteLine("\n");
            // Testing ReverseArray method with the given arrays
            Console.WriteLine("Reversing the array");
            ReverseArray(arrayA);
            ReverseArray(arrayB);
            ReverseArray(arrayC);
            Console.WriteLine("\n");

            Console.WriteLine("Rotating the array");
            RotatingArray("left", 2, arrayA);
        }

        /* 
           Method that takes the length of the array as count and a foreach loop that adds each item to the next to get the sum
           then converts those 2 numbers into doubles, divides by each other, to get the mean or average.
        */
        public static double ComputingMean(int[] inputArray)
        {
            int count = inputArray.Length;
            int sum = 0;
            foreach (var i in inputArray)
            {
                sum += i;
            }
            double mean = (double)sum / (double)count;
            return mean;
        }
        /*
           Method that takes the index of the last item in the array and uses that in a for loop to iterate backwards through
           the array and prints out each item.
        */
        public static void ReverseArray(int[] inputArray)
        {
            int last = inputArray.Length - 1;
            for (int i = last; i >= 0; i--)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine();
        }


        public static void RotatingArray2(string direction, int places, int[] inputArray)
        {
            int movement = inputArray.Length;
            int[] newArray = new int[inputArray.Length];
            for (int i = 0; i <= places; i++)
            {
                newArray[i] = inputArray[(inputArray.Length - places) + i];
                
            }
        }


        public static void RotatingArray(string direction, int places, int[] inputArray)
        {
            if (direction == "right")
            {
                int[] test = new int[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    test[(i + places) % test.Length] = inputArray[i];
                }
                foreach (var i in test)
                {
                    Console.Write(i + " ");
                }
            }
            if (direction == "left")
            {
                int[] test = new int[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    test[(i + places) % test.Length] = inputArray[i];
                }
                foreach (var i in test)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
