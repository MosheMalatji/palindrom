using System;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, reverse = string.Empty;
            Console.Write("Enter a string : ");
            input = Console.ReadLine();
            if (input != null)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input[i].ToString();
                }
                if (reverse == input)
                {
                    Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", input, reverse);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", input, reverse);
                }
            }
            Console.ReadLine();
        }
    }
}
