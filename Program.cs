using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace lab3._3Data_structures
{
    class Program
    {
        static string Reverse(string word) //declare method that will accept a string
        {
            Stack<char> st = new Stack<char>();

            char[] charReverse = word.ToCharArray(); //take the string passed from the main and convert it to a char array

            string reverseWord = null;

            foreach (char letter in charReverse)  //pass each letter from the char array into the stack
            {
                st.Push(letter);
            }
            while (st.TryPop(out char singleLetter)) //using a try pop which will attempt to pop out from the stack (filled with letters) back into single char(S)
            {
                reverseWord += singleLetter;  //fill the previously declared string with the letters stored in the stack
            }
            return reverseWord; //return the string that was created out of the characters pulled from the stack
        }
        static void Main()
        {
            
            Console.WriteLine("What word would you like to reverse?: ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, @"^[\p{L}]+$"))  //validate that the user is only using letters in their string
            {
                Console.Write(Reverse(input));
            }
            else  //if they use anything but letters, let the user know they failed you and return to the main
            {
                Console.WriteLine("Please enter valid input - letters only");
                Console.WriteLine();
                Main();
            }
            
            
        }
    }
}
