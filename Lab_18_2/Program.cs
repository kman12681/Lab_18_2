using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algorithm            

            //1. START
            //2. declare an integer array called array and fill with values          
            //3. declare an integer array called count and set its size to the max value of array + 1. Do not fill in values.
            //4. check each index of array and increment its corresponding index in count array at each occurence
            //5. declare an int variable called counter and set to 0
            //6. Iterate through count array, printing the counter and index, incrementing the counter at each iteration          
            
            int[] array = { 2, 4, 6, 3, 2, 5, 7000, 4, 2, 3 };
            int[] count = new int[array.Max() + 1];

            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }

            int counter = 0;

            foreach (int c in count)
            {
                if (c != 0)
                {
                    Console.WriteLine($"{counter}:{c}");
                }
                counter++;
            }
        }
    }
}
