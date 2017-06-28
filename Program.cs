using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {5,1,9,7,8,4,6,2,3 };

            printArray(myArray);

            mySelectSort(myArray);

            printArray(myArray);

            Console.WriteLine();
        }

        static void printArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }
        
        static void mySelectSort(int [] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexMin = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[indexMin] > array[j])
                    {
                        indexMin = j;
                    }
                }

                int tmp = array[indexMin];
                array[indexMin] = array[i];
                array[i] = tmp;
            }

        }        
    }
}
