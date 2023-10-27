using System;

namespace lab1_13
{
    public class ForWorkingWithAOneDimensionalArray
    {
        private int[] array;
        public uint size { get; private set; }

        public ForWorkingWithAOneDimensionalArray(uint arrayLength, string massiv)
        {
            size = arrayLength;
            array = new int[arrayLength];
            string[] separators = { ":"};
            string[] split = massiv.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    array[i] = int.Parse(split[i]);
                }
                catch 
                {
                  
                }
            }
        }

        public int FindSumOfNotNegativeElementThatIsLeftFirstNotNegativeElement()
        {
            var sum = 0;

            foreach (var element in array)
            {
                if (element > 0)
                {
                    break;
                   
                } 
                sum += element;
            }

            return sum;
        }
        
    }
}