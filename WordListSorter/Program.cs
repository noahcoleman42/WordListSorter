// Written by Noah Coleman
// 11/18/2020

// This program sorts words from a text file where words are seperated by a vertical line.

using System;
using System.Collections.Generic;

namespace WordListSorter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileGateway aFileGateway = new FileGateway();
            WordList aWordList = new WordList();
            List<String> aListOfWords;

            // Get the words from the file
            aListOfWords = aFileGateway.GetWordList(@"C:\Users\noahc\Desktop\Old School Stuff\CIS 122\Mine\WordsForTypingPractice.txt");

            // Sort the words and put them into a List
            aListOfWords = aWordList.SortWordList(aListOfWords);

            // Print the sorted list to console
            foreach (var w in aListOfWords)
            {
                Console.Write(w + "|");
            }

            // Save the file to the path location
            aFileGateway.SaveWordList(@"C:\Users\noahc\Desktop\Old School Stuff\CIS 122\Mine\WordsForTypingPractice.txt", aListOfWords);

            // Keep the console open
            Console.ReadLine();
        }
    }
}
