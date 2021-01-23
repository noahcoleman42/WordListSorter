// Written by Noah Coleman
// 11/18/2020

using System;
using System.Collections.Generic;
using System.Linq;


namespace WordListSorter
{
    public class WordList
    {
        public List<String> SortWordList(List<String> aListOfWords)
        {
            // Sort word list
            aListOfWords.Sort();

            // Remove duplicate words
            aListOfWords = aListOfWords.Distinct().ToList();

            return aListOfWords;
        }
    }
}
