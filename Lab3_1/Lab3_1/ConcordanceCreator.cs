using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_1
{
    public class ConcordanceCreator
    {
        private List<string> _textLines = new List<string>();

        public ConcordanceCreator(string originalText)
        {
            _textLines = CutTextToLines(originalText);
            
            OutputResult(CreateConcordance());
        }


        private List<string> CutTextToLines(string text)
        {
            List<string> lines = new List<string>();
            string line = String.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                line += text[i];
                if (text[i].ToString() == ".")
                {
                    lines.Add(line);
                    line = string.Empty;
                }
            }

            lines.Add(line);
            return lines;
        }


        private List<WordConcordanceInfo> CreateConcordance()
        {
            Dictionary<string, WordConcordanceInfo> concordanceInfo = new Dictionary<string, WordConcordanceInfo>();
            List<WordConcordanceInfo> wordListWithData = new List<WordConcordanceInfo>();

            string[] separators = { " ", ",", ".", ";", ":", "-", "!", "?" }; // Define word separators

            for (int lineNum = 0; lineNum < _textLines.Count; lineNum++)
            {
                string[] split = _textLines[lineNum].Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in split)
                {
                    var lower = word.ToLower();

                    if (concordanceInfo.ContainsKey(lower) == false)
                    {
                        WordConcordanceInfo newWord = new WordConcordanceInfo();
                        newWord.Setup(lower, lineNum);
                        concordanceInfo.Add(lower, newWord);
                        wordListWithData.Add(newWord);
                    }
                    else
                    {
                        WordConcordanceInfo newWord = new WordConcordanceInfo();
                        concordanceInfo.TryGetValue(lower, out newWord);
                        newWord.AddUses(lineNum);
                    }
                }
            }

            return wordListWithData;
        }

        public void OutputResult(List<WordConcordanceInfo> concordance)
        {
            List<WordConcordanceInfo> sortedList = concordance.OrderBy(c => c.Word).ToList();
            string currentFirstChar = sortedList[0].Word[0].ToString().ToUpper();
            
            Console.WriteLine(currentFirstChar);
            
            foreach (var wordData in sortedList)
            {
                if (wordData.Word[0].ToString().ToUpper() != currentFirstChar)
                {
                    currentFirstChar = wordData.Word[0].ToString().ToUpper();
                    Console.WriteLine(currentFirstChar);
                }
                Console.Write(wordData.Word + "...................." + wordData.NumberOfUses + ": ");
                foreach (var usesLines in wordData.LinesWhereUses)
                {
                    Console.Write(usesLines + " ");
                }
                Console.WriteLine();
            }
        }
    }
}