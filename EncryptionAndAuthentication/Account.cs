using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionAndAuthentication
{
    class Account
    {
        public static Dictionary<string, byte[]> accounts = new Dictionary<string, byte[]>();
        public static Dictionary<string, byte[]> MakeAccount()
        {
            string accountName;
            string password;
            Console.WriteLine("\tAccount Creation Page");
            Console.WriteLine("\t---------------------\n");
            Console.Write("Enter your username: ");
            accountName = Console.ReadLine();
            while (accounts.ContainsKey(accountName))
            {
                Console.WriteLine("The username you entered already exists!");
                Console.Write("Please enter another username: ");
                accountName = Console.ReadLine();
            }
            Console.Write("Enter your password: ");
            password = Console.ReadLine();
            byte[] encryptedPassword = HashString(password);
            accounts.Add(accountName, encryptedPassword);
            Console.WriteLine("\nYour account has been created!");
            Console.WriteLine("Press any key to go to the main menu");
            Console.ReadKey();
            return accounts;
        }

        public static void ValidateAccount()
        {
            string accountName;
            string password;
            Console.WriteLine("\tAccount Validation Page");
            Console.WriteLine("\t---------------------\n");
            Console.Write("Enter your username name: ");
            accountName = Console.ReadLine();
            Console.Write("Enter your password: ");
            password = Console.ReadLine();
            byte[] encryptedPassword = HashString(password);
            if (accounts.ContainsKey(accountName) == true)
            {
                for (int i = 0; i < encryptedPassword.Length; i++)
                {
                    if (encryptedPassword[i] != accounts.GetValueOrDefault(accountName)[i])
                    {
                        Console.WriteLine("The username or password you entered doesn't match any combination in our system. Please try again");
                        ValidateAccount();
                    }
                }
                Console.WriteLine("\nYour account has been authorized");
                Console.Write("Press any key to go to the main menu");
                Console.ReadKey();
                
            }
            else
            {
                Console.WriteLine("The username or password you entered doesn't match any combination in our system. Please try again");
                ValidateAccount();
            }
        }

        public static byte[] HashString(string s)
        {
            byte[] encryptedString;
            using (SHA256 mySHA256 = SHA256.Create())
            {
                UnicodeEncoding ue = new UnicodeEncoding();
                byte[] stringBytes = ue.GetBytes(s);
                encryptedString = mySHA256.ComputeHash(stringBytes);
            }
            return encryptedString;
        }

        public static void PrintEncryption()
        {
            Console.WriteLine("\nHere are all of the stored accounts\n");
            foreach (KeyValuePair<string, byte[]> element in accounts)
            {
                string username = element.Key;
                Console.WriteLine($"\nUsername: {username}");
                Console.Write("Password: ");
                byte[] password = element.Value;
                foreach (var item in password)
                {
                    Console.Write(item);
                }
            }
        }
    }
}
