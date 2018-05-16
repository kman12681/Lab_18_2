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
            //TODO: make this better.. and correct!

            //1. START
            //2. declare an integer array called array            
            //3. initialize a LinkedList called list
            //4 .sort array
            //5. add each index of array to list
            //6. check if next node in list is equal to previous node and increment count if true
            //7. when next node is not equal to previous node, start count over
            //8. print number of occurrences

            LinkedList list = new LinkedList();
            
            int[] array = { 2, 4, 6, 3, 2, 5, 4, 2, 3 };
            Array.Sort(array, 0, array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                list.AddToEnd(array[i]);
            }
            
            list.CountOccurences();


            //list.PrintAllNodes();         







        }
    }

}
