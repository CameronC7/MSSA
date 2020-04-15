using System;

namespace BaseNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the integer to convert: ");
            string n1 = Console.ReadLine();
            int number = int.Parse(n1);

            Console.Write("Please enter the base to convert from | 2 | 8 | 10 |: ");
            string n2 = Console.ReadLine();
            int from = int.Parse(n2);

            Console.WriteLine($"Number: {number}, base: {from}");

            int result = 0;
            string answer;
            if (from == 10)
            {
                answer = NumberConvert.dec2bin(number);
                Console.WriteLine($"binary conversion is {answer}");
                answer = NumberConvert.dec2oct(number);
                Console.WriteLine($"octal conversion is {answer}");
            }
            else if (from == 2)
            {
                result = NumberConvert.bin2dec(number);
                Console.WriteLine($"decimal conversion is {result}");
                result = NumberConvert.bin2oct(number);
                Console.WriteLine($"octal conversion is {result}");
            }
            else if (from == 8)
            {
                result = NumberConvert.oct2bin(number);
                Console.WriteLine($"binary conversion is {result}");
                result = NumberConvert.oct2dec(number);
                Console.WriteLine($"decimal conversion is {result}");
            }
            else
            {
                Console.WriteLine("Error in base to convert from");
            }
        }
    }
}
