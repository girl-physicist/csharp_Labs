using System;

namespace lab1_13
{
    public class ForWorkingWithAOneDimensionalArray // Дать более адекватное имя. Например OneDimensionArrayWorker
        
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
                  // где обработка???????
                }
            }
        }

        public int FindSumOfNotNegativeElementThatIsLeftFirstNotNegativeElement() // дать более адекватное имя 
        {
            var sum = 0;

            foreach (var element in array)
            {
                if (element > 0)
                {
                    break;
                   
                } 
                sum += element; // в задании требовалось найти произведение
            }

            return sum;
        }
        
    }
}
