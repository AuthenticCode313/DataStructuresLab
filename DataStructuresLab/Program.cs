using System;

namespace DataStructuresLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word you would like to reverse: ");
            string input = Console.ReadLine();
            string reversed = ReverseString(input);
            Console.WriteLine(reversed);
        }
        static string ReverseString(string myString)
        {
            string reversed = "";
            for(int i = myString.Length - 1; i >= 0; i--)
            {
                reversed += myString[i];
            }
            return reversed;
        }
    }
}
