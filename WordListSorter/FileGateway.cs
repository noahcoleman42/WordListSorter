// Written by Noah Coleman
// 11/18/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WordListSorter
{
    public class FileGateway
    {
        public List<String> GetWordList(string aPath)
        {
            string[] allLines;
            string[] allWords = null;
            List<String> aListOfWords;
            int index = 0;

            // Read in all lines
            allLines = File.ReadAllLines(aPath);

            // Split the words by | character
            while (index < allLines.Length)
            {
                allWords = allLines[index].Split('|');
                index++;
            }
            // Add words from string array to a list
            aListOfWords = allWords.ToList();

            // Return an string array of all words
            return aListOfWords;
        }

        public void SaveWordList(string aPath, List<String> newListOfWords)
        {
            string content = "";

            // Add back in the vertical line character.
            foreach (var w in newListOfWords)
            {
                content += w + "|";
            }
            File.WriteAllText(aPath, content);
        }
    }
}
