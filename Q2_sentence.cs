using System;
using System.Collections.Generic;
using System.Text;

namespace MAY_250526
{
    internal class Q2_sentence
    {
// Accept a sentence from the user and reverse it
        public static void Run()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            char[] characters = sentence.ToCharArray();
            Array.Reverse(characters);

            string reversedSentence = new string(characters);

            Console.WriteLine("Reversed sentence: " + reversedSentence);
        }
    }
}
