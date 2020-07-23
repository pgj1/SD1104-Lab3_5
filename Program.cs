using System;
using System.Text.RegularExpressions;

namespace Lab3_5_SpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string blackListWord = "spam";
            bool isSpam = false;
            Console.Write("Input your message here: ");
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The posted message is spam");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The posted message is good");
            }



        }
    }
}
