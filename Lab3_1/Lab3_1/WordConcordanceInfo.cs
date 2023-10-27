using System;
using System.Collections.Generic;

namespace Lab3_1
{
    public class WordConcordanceInfo : IComparable
    {
        public string Word { get; private set; }
        public int NumberOfUses { get; private set; }
        public List<int> LinesWhereUses { get; private set; }

        public void Setup(string word, int line)
        {
            LinesWhereUses = new List<int>();
            Word = word;
            NumberOfUses = 1;
            LinesWhereUses.Add(line);
        }
       
        public void AddUses(int line)
        {
            NumberOfUses += 1;

            if (LinesWhereUses.Contains(line))
            {
                return;
            }
            LinesWhereUses.Add(line);
        }


        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}