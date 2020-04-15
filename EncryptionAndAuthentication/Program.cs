using System;

namespace EncryptionAndAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag == true)
            {
                Console.Clear();
                int choice = MainMenu();

                if (choice == 1)
                {
                    Console.Clear();
                    Account.MakeAccount();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Account.ValidateAccount();
                }
                else if (choice == 3)
                {
                    Account.PrintEncryption();
                    Environment.Exit(0);
                }
            }
        }

        static int MainMenu()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\n\tPASSWORD AUTHENTICATION SYSTEM\n");
            Console.WriteLine("\tPlease select one option:");
            Console.WriteLine("\t1. Establish an account");
            Console.WriteLine("\t2. Authenticate a user");
            Console.WriteLine("\t3. Exit the system\n");
            Console.WriteLine("\n-----------------------------------------------\n");
            Console.Write("\tEnter selection: ");
            int selection = Int32.Parse(Console.ReadLine());
            return selection;
        }
    }
}
