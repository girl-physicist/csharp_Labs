using System;

namespace lab1_13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var classForWorkingWithAOneDimensionalArray = new ForWorkingWithAOneDimensionalArray(5, ":10:12:14");
            Console.Write(classForWorkingWithAOneDimensionalArray.FindSumOfNotNegativeElementThatIsLeftFirstNotNegativeElement());
            Console.WriteLine(classForWorkingWithAOneDimensionalArray.size);
        }
    }
}