using System;
using System.Collections.Generic;
using System.Text;

namespace BaseNumberConversion
{
    class NumberConvert
    {
        public static string dec2bin(int number)
        {
            string current = "";
            do
            {
                int nextDigit = number % 2;
                number /= 2;
                int digitCode = '0' + nextDigit;
                char digit = Convert.ToChar(digitCode);
                current = digit + current;
            }
            while (number != 0);

            return current;
        }

        public static string dec2oct(int number)
        {
            string current = "";
            do
            {
                int nextDigit = number % 8;
                number /= 8;
                int digitCode = '0' + nextDigit;
                char digit = Convert.ToChar(digitCode);
                current = digit + current;
            }
            while (number != 0);

            return current;
        }

        public static int bin2dec(int number)
        {
            int decimalValue = 0;
            int base1 = 1;

            while (number > 0)
            {
                int reminder = number % 10;
                number /= 10;
                decimalValue += reminder * base1;
                base1 *= 2;
            }

            return decimalValue;
        }

        public static int bin2oct(int number)
        {
            int n1, p = 1;
            int dec = 0, i = 1, j, d;
            int ocno = 0;

            n1 = number;
            for (j = number; j > 0; j /= 10)
            {
                d = j % 10;
                if (i == 1)
                {
                    p *= 1;
                }
                else
                {
                    p *= 2;
                }
                dec = dec + (d * p);
                i++;
            }

            i = 1;

            for (j = dec; j > 0; j /= 8)
            {
                ocno = ocno + (j % 8) * i;
                i *= 10;
                number /= 8;
            }
            return ocno;
        }

        public static int oct2bin(int number)
        {
            int n5 = number, p = 1;
            int dec = 0, i = 1, j, d;
            int binno = 0;
            
            for (j = number; j > 0; j /= 10)
            {
                d = j % 10;
                if (i == 1)
                {
                    p *= 1;
                }
                else
                {
                    p *= 8;
                }

                dec = dec + (d * p);
                i++;
            }

            i = 1;

            for (j = dec; j > 0; j = j / 2)
            {
                binno = binno + (dec % 2) * i;
                i *= 10;
                dec /= 2;
            }
            return binno;
        }

        public static int oct2dec(int number)
        {
            int decValue = 0;
            int base1 = 1;

            int temp = number;
            while (temp > 0)
            {
                int lastDigit = temp % 10;
                temp /= 10;
                decValue += lastDigit * base1;
                base1 *= 8;
            }

            return decValue;
        }
    }
}
