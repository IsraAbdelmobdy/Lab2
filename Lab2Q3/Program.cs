using System;

namespace Lab2Q3
{
    internal class Program
    {
        public static void ChangeString(string s)
        {
            s = "Bye!";
        }
        static void Main(string[] args)
        {
            string str = "Hi!";
            ChangeString(str); 
            Console.WriteLine(str); //the string str doesn't change

        }
    }
}