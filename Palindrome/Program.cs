using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine($"{s} ---> {Palindrome(s)}");
            }
        }
        public static bool Palindrome(string str)
        {
            if (str == null)
                //If the string is null
                throw new ArgumentNullException("Invalid string"); 
           
            else if (str.Length < 2) return true; //If string has less than 2 characters
            
            bool IsPalindrome(string s)
            {
                Queue<char> s1 = new Queue<char>(); //LIFO storage
                Stack<char> s2 = new Stack<char>(); //FIFO storage

                foreach (char c in s)
                {
                    //Puts each character in a queue and in a stack
                    s1.Enqueue(c);
                    s2.Push(c);
                }
                while (s1.Count > 0)
                {
                    //Gets the first character in the queue and in the stack 
                    //and compares them
                    if (s1.Dequeue() != s2.Pop()) return false; //If they're different
                }
                return true; //If they're the same
            }
            return IsPalindrome(str);
            
        }
    }
}
