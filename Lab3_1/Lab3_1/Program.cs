using System;

namespace Lab3_1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ConcordanceCreator creator = new ConcordanceCreator("Peter Piper picked a peck of pickled peppers." + " A peck of pickled peppers Peter Piper picked. If Peter Piper picked a peck of pickled peppers, where is the peck that Peter Piper picked?");
    }
  }
}