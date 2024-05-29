using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public bool Palindrome(string str)
        {
            if (str == null)
                //If the string is null
                throw new ArgumentNullException("Invalid string"); 
            else if (str.Length < 2) return true; //If string has less than 2 characters
            return false;
        }
    }
}
